# LinkedContacts
This tool is under development. This tool is intended to help users and admins out there to identify Linked Contacts for a given user with an Exchange mailbox.

## Requirements

* [.NET Framework version 4.5+](https://dotnet.microsoft.com/download/dotnet-framework)

## OAuth 2.0 - How to

To be able to use Oauth 2.0, you'll need to register the application in Azure. To do so, follow these steps:

**1**. Sign in to the [Azure Portal](https://portal.azure.com/) using either a work or school account or a personal Microsoft account.

**2**. If your account gives you access to more than one tenant, select your account in the top right corner, and set your portal session to the Azure AD tenant that you want.

**3**. Search for and select **Azure Active Directory**. On the Active Directory page, select **App registrations** and then select **New registration**.

**4**. When the Register an application page appears, enter your application's registration information (see image below):

![app registration](https://user-images.githubusercontent.com/1156257/69982293-0089da00-152c-11ea-8a1c-fdf96576a013.png)

In Redirect URI section, make sure you select **"Public client/native (mobile & desktop)"** and type **"urn:ietf:wg:oauth:2.0:oob"** as the redirection URI.

**5**. Click **Register** to complete. 

Now you should be in the Application's overview page, copy both **Application (client)  ID** and **Directory (tenant) ID** to the LinkedContacts settings.

**6**. Run **LinkedContacts.exe** and in the menu select **Options** -> **Settings**.

Check the checkbox "Use OAuth 2.0" and fill in the ID's you got from previous step.

![app registration - linkedcontacts](https://user-images.githubusercontent.com/1156257/69988639-f078f700-1539-11ea-9286-adba4293bb7d.png)

Save the settings and you are ready to go.

## Checking contacts

**1.** Make sure you have set either the credentials for Basic auth or performed OAuth 2.0 registration.

**2.** Run **LinkedContacts.exe** and in the menu select **Actions** -> **Fetch Results**.

![fetch results](https://user-images.githubusercontent.com/1156257/70035615-18547300-15ab-11ea-9378-378006c5fda7.png)

**3.** Contacts will be split into 2 separate tabs. 
Basic information about all the contacts will be shown in the "All Contacts" tab, whereas the "Linked Contacts" tab will only show the linked contacts and its links:

#### All contacts Tab:

![allcontacts](https://user-images.githubusercontent.com/1156257/70088219-baa54280-160d-11ea-8eb4-a4ede6510ef8.png)

#### Linked Contacts Tab:

![treeview](https://user-images.githubusercontent.com/1156257/70088218-baa54280-160d-11ea-88b3-f292e6995268.png)


