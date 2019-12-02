using LinkedContacts.Properties;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.Identity.Client;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace LinkedContacts
{
    public partial class LinkedContacts : Form
    {
        public LinkedContacts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates all child tree nodes recursively.
        /// </summary>
        /// <param name="treeNode">The tree node</param>
        /// <param name="nodeChecked">The current value of the tree node</param>
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode tnNode in treeNode.Nodes)
            {
                tnNode.Checked = nodeChecked;
            }
        }

        /// <summary>
        /// Reset the elements on the LinkedContactsForm and clear the listview
        /// </summary>
        private void ClearResults()
        {
            lvContacts.Items.Clear();
            lvContacts.Visible = false;
            lblConnection.Text = "Nothing to show";
            lblConnection.ForeColor = Color.Red;
            lblConnectedTo.Text = string.Empty;
            lblTotalResults.Text = string.Empty;
            lblTotalResults.Visible = false;
            errorMessage.Clear();
            tvContacts.Nodes.Clear();
            pbLoading.Value = 0;
            pbLoading.Visible = false;
            lblProgress.Visible = false;

        }

        /// <summary>
        /// Validates if the redirection is HTTPS or not.
        /// </summary>
        /// <param name="redirectionUrl"></param>
        /// <returns></returns>
        private static bool RedirectionUrlValidationCallback(string redirectionUrl)
        {
            // The default for the validation callback is to reject the URL.
            Logger Log = Logger.Instance;
            Log.CreateLog("Performing redirection URL validation.", false);
            bool result = false;
            Uri redirectionUri = new Uri(redirectionUrl);
            //Log.CreateLog(redirectionUrl, false);
            // Validate the contents of the redirection URL. In this simple validation
            // callback, the redirection URL is considered valid if it is using HTTPS
            // to encrypt the authentication credentials. 
            if (redirectionUri.Scheme == "https")
            {
                result = true;
            }
            return result;
        }

        private static async System.Threading.Tasks.Task<AuthenticationResult> DoOAuthAsync()
        {
            AuthenticationResult authResult = null;
            Logger Log = Logger.Instance;

            // Configure the MSAL client to get tokens
            var pcaOptions = new PublicClientApplicationOptions
            {
                ClientId = ConfigurationManager.AppSettings["appId"],
                TenantId = ConfigurationManager.AppSettings["tenantId"]
            };

            var pca = PublicClientApplicationBuilder.CreateWithApplicationOptions(pcaOptions).Build();
            var accounts = await pca.GetAccountsAsync();
            var ewsScopes = new string[] { "https://outlook.office.com/EWS.AccessAsUser.All" };

            try
            {
                // Make the interactive token request
                Log.CreateLog("Prompting user to perform authentication.", false);
                authResult = await pca.AcquireTokenInteractive(ewsScopes)
                   .WithPrompt(Prompt.SelectAccount)
                   .ExecuteAsync();
                return authResult;
            }
            catch (MsalException msalex)
            {
                Log.CreateLog($"Error acquiring access token: {msalex.ToString()}", false);
                return authResult;
            }
            catch (Exception ex)
            {
                Log.CreateLog($"Error: {ex.ToString()}", false);
                return authResult;
            }
        }

        /// <summary>
        /// This function tests if the SSL certificate for a given endpoint is valid or not.
        /// If there are any other errors other than Self-signed certificates with an untrusted root, the return will be false therefore the certificate is invalid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="sslPolicyErrors"></param>
        /// <returns></returns>
        private static bool CertificateValidationCallBack(
         object sender,
         X509Certificate certificate,
         X509Chain chain,
         SslPolicyErrors sslPolicyErrors)
        {
            Logger Log = Logger.Instance;
            Log.CreateLog("Performing certificate validation check.", false);
            // If the certificate is a valid, signed certificate, return true.
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                Log.CreateLog("Certificate is valid.", false);
                return true;
            }

            // If there are errors in the certificate chain, look at each error to determine the cause.
            if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateChainErrors) != 0)
            {
                if (chain != null && chain.ChainStatus != null)
                {
                    foreach (X509ChainStatus status in chain.ChainStatus)
                    {
                        if ((certificate.Subject == certificate.Issuer) &&
                           (status.Status == X509ChainStatusFlags.UntrustedRoot))
                        {
                            // Self-signed certificates with an untrusted root are valid.
                            Log.CreateLog("Certificate is self-signed with an untrusted root.", false);
                            continue;
                        }
                        else
                        {
                            if (status.Status != X509ChainStatusFlags.NoError)
                            {
                                // If there are any other errors in the certificate chain, the certificate is invalid,
                                // so the method returns false.
                                Log.CreateLog("Erros with the certificate.", false);
                                return false;
                            }
                        }
                    }
                }

                // When processing reaches this line, the only errors in the certificate chain are 
                // untrusted root errors for self-signed certificates. These certificates are valid
                // for default Exchange server installations, so return true.
                return true;
            }
            else
            {
                // In all other cases, return false.
                return false;
            }
        }

        private void LinkedContacts_Load(object sender, EventArgs e)
        {
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            //Calling AppSettings form.
            AppSettings SettingsForm = new AppSettings();
            SettingsForm.Show();
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            //Calling About form.
            About AboutForm = new About();
            AboutForm.Show();
        }

        private async void MenuFetchResults_Click(object sender, EventArgs e)
        {
            try
            {

                #region Cleanup code
                //Clearing any previous information in case any results are being shown.
                if (lvContacts.Visible) ClearResults();
                pbLoading.Visible = true;
                lblProgress.Visible = true;
                #endregion

                //Reading User Settings:
                string userPrincipalName = Settings.Default["UserPrincipalName"].ToString();
                string userEmailAddress = Settings.Default["EmailAddress"].ToString();
                string userPassword = Settings.Default["Password"].ToString();
                bool shouldUseOAuth = Boolean.Parse(Settings.Default["UseOAuth"].ToString());
                bool directConnectionToEXO = Boolean.Parse(Settings.Default["DirectConnection"].ToString());
                bool showLinkedOnly = Boolean.Parse(Settings.Default["ShowLinkedOnly"].ToString());
                bool loggingEnabled = Boolean.Parse(Settings.Default["LoggingEnabled"].ToString());

                //Instantiating my log object
                Logger Log = Logger.Instance;

                //Setting up connection with Exchange. Selecting Exchange2010_SP2, although this is for ExO.
                ExchangeService NewConnection = new ExchangeService(ExchangeVersion.Exchange2010_SP2);
                Log.CreateLog("Setting up Exchange connection " + ExchangeVersion.Exchange2010_SP2, true);

                //Enabling Exchange logs for the connection according to user's choice.
                if (NewConnection.TraceEnabled = loggingEnabled)
                {
                    TraceListener ITListener = new TraceListener();
                    NewConnection.TraceListener = ITListener;
                    NewConnection.TraceFlags = TraceFlags.All;
                }

                //Calling modern auth
                if (shouldUseOAuth)
                {
                    Log.CreateLog("OAuth 2.0 will be used.", false);
                    AuthenticationResult OAuthResult = await DoOAuthAsync();
                    Log.CreateLog("Session details:" +Environment.NewLine + $"Username: {OAuthResult.Account.Username}" + Environment.NewLine +
                        $"Token Expires: {OAuthResult.ExpiresOn.ToLocalTime()}" + Environment.NewLine, false);
                    NewConnection.Credentials = new OAuthCredentials(OAuthResult.AccessToken);
                }
                else
                {
                    //Getting credentials from the user's settings.
                    NewConnection.Credentials = new WebCredentials(userPrincipalName, userPassword);
                }

                //Performing the check before the autod call.
                ServicePointManager.ServerCertificateValidationCallback = CertificateValidationCallBack;
                //Performing Autodiscover for the given SMTP address or direct connection to O365 depending on the user's choice.
                if (directConnectionToEXO)
                {
                    NewConnection.Url = new Uri("https://outlook.office365.com/EWS/Exchange.asmx");
                }
                else
                {
                    Log.CreateLog("Performing Autodiscover for " + userEmailAddress, false);
                    NewConnection.AutodiscoverUrl(userEmailAddress, RedirectionUrlValidationCallback);
                }
                Log.CreateLog("EWS Endpoint: " + NewConnection.Url, false);

                // Get the number of items in the Contacts folder.
                ContactsFolder contactsfolder = ContactsFolder.Bind(NewConnection, WellKnownFolderName.Contacts);

                // Set the number of items to the number of items in the Contacts folder or 500(testing with 500 for now), whichever is smaller.
                int numItems = contactsfolder.TotalCount < 500 ? contactsfolder.TotalCount : 500;

                //Commonly used Property sets - Contact GUID
                //At this point I'm specifying the extended props that I need to get in the FindItem request
                //This is one {00062004-0000-0000-C000-000000000046} / 80E0000B
                //also this one {00062004-0000-0000-C000-000000000046} / 80E3101F
                //also this one {00062004-0000-0000-C000-000000000046} / 80E60003.
                Guid propertySetId = new Guid("{00062004-0000-0000-C000-000000000046}");
                var contactLinkedProp = new ExtendedPropertyDefinition(propertySetId, 0x80E0, MapiPropertyType.Boolean);
                var contactLinkedGALSMTPProp = new ExtendedPropertyDefinition(propertySetId, 0x80E3, MapiPropertyType.StringArray);
                var contactLinkedGALProp = new ExtendedPropertyDefinition(propertySetId, 0x80E6, MapiPropertyType.Integer);
                ExtendedPropertyDefinition[] extendedProperty = new ExtendedPropertyDefinition[] { contactLinkedProp, contactLinkedGALSMTPProp, contactLinkedGALProp };

                //Requesting all remaining base properties we want to see.
                //REVIEWED (21/07/2019): The payload is full of unnecessary data due to the use of "FirstClassProperties" which returns all properties
                //https://docs.microsoft.com/en-us/exchange/client-developer/exchange-web-services/property-sets-and-response-shapes-in-ews-in-exchange
                //I need to think of a better way of using "IdOnly" and add only the necessary data that we need to consume
                PropertySet extendedPropertySet = new PropertySet(BasePropertySet.FirstClassProperties, extendedProperty);
                ItemView view = new ItemView(numItems) { PropertySet = extendedPropertySet };
                view.OrderBy.Add(ContactSchema.DisplayName, SortDirection.Ascending);

                //Setting the progress bar maximum to the total number of items.
                pbLoading.Maximum = numItems;

                // Retrieve the items in the Contacts folder that have the properties that we selected.
                FindItemsResults<Item> contactItems = NewConnection.FindItems(WellKnownFolderName.Contacts, view);

                // Display the list of contacts. 
                int i = 0;
                int isGalLinked = 0;
                object objGalSmtpAddress = null;
                bool isLinked = false;
                EmailAddress email = "";
                string strPhone = string.Empty;
                foreach (Item item in contactItems)
                {
                    if (item is Contact)
                    {
                        Contact contact = item as Contact;
                        contact.TryGetProperty(contactLinkedProp, out isLinked);
                        contact.TryGetProperty(contactLinkedGALProp, out isGalLinked);
                        if ((showLinkedOnly && isLinked) || !showLinkedOnly)
                        {
                            //Adding the DisplayName to the first column.
                            if (!string.IsNullOrEmpty(contact.DisplayName))
                            {
                                lvContacts.Items.Add(contact.DisplayName);
                            }
                            else
                            {
                                lvContacts.Items.Add("");
                            }
                            //Adding the First Email address to the second column.
                            if (contact.EmailAddresses.TryGetValue(EmailAddressKey.EmailAddress1, out email))
                            {
                                if ((isGalLinked == 1) && (email.ToString().Substring(0, 3) == "/o="))
                                {
                                    Log.CreateLog("Contact " + contact.DisplayName + " is linked to GAL. EmailAddress: " + email, false);
                                    contact.TryGetProperty(contactLinkedGALSMTPProp, out objGalSmtpAddress);
                                    string[] SMTP = (string[])objGalSmtpAddress;
                                    lvContacts.Items[i].SubItems.Add(SMTP[0]);
                                }
                                else
                                {
                                    lvContacts.Items[i].SubItems.Add(email.ToString());
                                }
                            }
                            else
                            {
                                lvContacts.Items[i].SubItems.Add("");
                            }
                            //Adding the Phone Number to the third column.
                            if (contact.PhoneNumbers.TryGetValue(PhoneNumberKey.BusinessPhone, out strPhone))
                            {
                                lvContacts.Items[i].SubItems.Add(strPhone);
                            }
                            else
                            {
                                lvContacts.Items[i].SubItems.Add("");
                            }
                            //Adding the LinkedContact value to the column.
                            lvContacts.Items[i].SubItems.Add(isLinked.ToString());
                            //Adding GAL Link value to the column.
                            lvContacts.Items[i].SubItems.Add(isGalLinked.ToString());
                            //Testing convID
                            lvContacts.Items[i].SubItems.Add(contact.ConversationId);
                            //Adding the ID of the item to the tag property of the listviewitem
                            lvContacts.Items[i].Tag = contact.ConversationId; //replace with "Id" for the item when I need to update
                            //tvContacts.Nodes.Add(contact.DisplayName);
                            //tvContacts.Nodes[i].Nodes.Add(contact.DisplayName);
                            i++;
                            pbLoading.Value++;
                        }
                        else
                        {
                            Log.CreateLog("Skipping contact " + contact.DisplayName + ". It's not linked.", false);
                            pbLoading.Value++;
                        }

                    }
                    //Controlling the visible components for the user
                    //to make sure we display some useful information while getting information.
                    lvContacts.Visible = true;
                    lblConnection.Text = "Successfully fetched results for";
                    lblConnectedTo.Text = "(" + userEmailAddress + ")";
                    lblConnection.ForeColor = Color.Green;
                    lblTotalResults.Visible = true;
                    if (showLinkedOnly)
                    {
                        lblTotalResults.Text = "Total of linked contacts: " + i;
                    }
                    else
                    {
                        lblTotalResults.Text = "Total of contacts: " + numItems;
                    }
                }
                //Build up the treeview
                DoTreeView();
            }
            catch (Exception ex)
            {
                errorMessage.SetError(lblError, ex.Message);
                if (Boolean.Parse(Settings.Default["LoggingEnabled"].ToString()))
                {
                    Logger Log = Logger.Instance;
                    Log.CreateLog(ex.Message, false);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuClearResults_Click(object sender, EventArgs e)
        {
            if (lvContacts.Visible)
            {
                ClearResults();
            }

        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DoTreeView()
        {
            try
            {
                int i = 0;
                bool isNodeCompleted = false;
                TreeNode[] tnNode;
                //This was a previous feature to allow creation of the treeview for selected items only.
                //ListView.CheckedListViewItemCollection checkedItems = this.lvContacts.CheckedItems;
                ListView.ListViewItemCollection allItems = this.lvContacts.Items;
                //foreach (ListViewItem item in checkedItems)
                foreach (ListViewItem item in allItems)
                {
                    //CreateLog("Selected items: " + item + " Id: " + item.Tag);
                    foreach (ListViewItem list in lvContacts.Items)
                    {

                        if ((item.Tag.ToString() == list.Tag.ToString()) && (item.Text.ToString() != list.Text.ToString()))
                        {
                            tnNode = tvContacts.Nodes.Find(item.Text, true);
                            if (tnNode.Length == 0)
                                tvContacts.Nodes.Add(item.Text);
                            tvContacts.Nodes[i].Nodes.Add(item.Text, list.Text, 3, 3);
                            isNodeCompleted = true;
                        }
                    }
                    if (isNodeCompleted)
                    {
                        i++;
                        isNodeCompleted = false;
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage.SetError(lblError, ex.Message);
                if (Boolean.Parse(Settings.Default["LoggingEnabled"].ToString()))
                {
                    Logger Log = Logger.Instance;
                    Log.CreateLog(ex.Message, false);
                }
            }
        }

        private void lvContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Validating if settings are not empty, otherwise connect button will be greyed out
            if (!string.IsNullOrEmpty(Settings.Default["UserPrincipalName"].ToString())
                && !string.IsNullOrEmpty(Settings.Default["EmailAddress"].ToString())
                    && !string.IsNullOrEmpty(Settings.Default["Password"].ToString())
                    || Boolean.Parse(Settings.Default["UseOAuth"].ToString()))
            {
                MenuFetchResults.Enabled = true;
                MenuFetchResults.ToolTipText = "";
            }
            else
            {
                MenuFetchResults.Enabled = false;
                MenuFetchResults.ToolTipText = "Settings are empty";
            }
        }

        /// <summary>
        /// After a tree node's Checked property is changed, all its child nodes are updated to the same value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvContacts_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }

        private void tcPages_Selected(object sender, TabControlEventArgs e)
        {
            if (tcPages.SelectedTab.Text == "TreeView")
                btnExpandNodes.Visible = true;
            else
                btnExpandNodes.Visible = false;
        }

        private void btnExpandNodes_Click(object sender, EventArgs e)
        {
            if (btnExpandNodes.Text == "Expand all")
            {
                tvContacts.ExpandAll();
                btnExpandNodes.Text = "Collapse all";
            }
            else
            {
                tvContacts.CollapseAll();
                btnExpandNodes.Text = "Expand all";
            }
        }
    }
}
