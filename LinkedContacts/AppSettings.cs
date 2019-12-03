using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinkedContacts.Properties;

namespace LinkedContacts
{
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //Saving user scope settings for the application
            Settings.Default["UserPrincipalName"] = tbUPN.Text;
            Settings.Default["EmailAddress"] = tbEmail.Text;
            Settings.Default["Password"] = tbPassword.Text;
            Settings.Default["LogsLocation"] = tbLocation.Text;
            Settings.Default["DirectConnection"] = ckbDirectConnection.Checked;
            Settings.Default["LoggingEnabled"] = ckbLogging.Checked;
            Settings.Default["UseOAuth"] = ckbOAuth.Checked;
            Settings.Default.Save();
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("appId");
            config.AppSettings.Settings.Remove("tenantId");
            config.AppSettings.Settings.Add("appId", tbClientId.Text);
            config.AppSettings.Settings.Add("tenantId", tbTenant.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
        }

        private void btnLoggingLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                tbLocation.Text = folderBrowser.SelectedPath;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //Reading all saved settings from the application settings (user scope)
            if (!string.IsNullOrEmpty(Settings.Default["UserPrincipalName"].ToString()))
            {
                tbUPN.Text = Settings.Default["UserPrincipalName"].ToString();
            }
            if (!string.IsNullOrEmpty(Settings.Default["EmailAddress"].ToString()))
            {
                tbEmail.Text = Settings.Default["EmailAddress"].ToString();
            }
            if (!string.IsNullOrEmpty(Settings.Default["Password"].ToString()))
            {
                tbPassword.Text = Settings.Default["Password"].ToString();
            }

            ckbDirectConnection.Checked = Boolean.Parse(Settings.Default["DirectConnection"].ToString());
            ckbLogging.Checked = Boolean.Parse(Settings.Default["LoggingEnabled"].ToString());
            ckbOAuth.Checked = Boolean.Parse(Settings.Default["UseOAuth"].ToString());

            if (!string.IsNullOrEmpty(Settings.Default["LogsLocation"].ToString()))
            {
                tbLocation.Text = Settings.Default["LogsLocation"].ToString();
            }

            tbClientId.Text = ConfigurationManager.AppSettings["appId"];
            tbTenant.Text = ConfigurationManager.AppSettings["tenantId"];
        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            tbUPN.Clear();
            tbEmail.Clear();
            tbPassword.Clear();
            ckbDirectConnection.Checked = false;
            ckbLogging.Checked = false;
            tbClientId.Clear();
            tbTenant.Clear();
            tbLocation.Clear();
        }

        private void ckbOAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOAuth.Checked)
                gbAppRegistration.Enabled = true;
            else
                gbAppRegistration.Enabled = false;
        }
    }
}
