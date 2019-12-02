# LinkedContacts
This tool is under development. This tool is intended to help users and admins out there to identify Linked Contacts for a given user with an Exchange mailbox.

## Requirements

* [.NET Framework version 4.5+](https://dotnet.microsoft.com/download/dotnet-framework)

## OAuth 2.0 - How to

To be able to use Oauth 2.0, you'll need to register the application in Azure. To do so, follow these steps:

**1**. Sign in to the **Azure portal** using either a work or school account or a personal Microsoft account.

**2**. If your account gives you access to more than one tenant, select your account in the top right corner, and set your portal session to the Azure AD tenant that you want.

**3**. Search for and select **Azure Active Directory**. On the Active Directory page, select **App registrations** and then select **New registration**.

**4**. When the Register an application page appears, enter your application's registration information (see image below):

![app registration](https://user-images.githubusercontent.com/1156257/69982293-0089da00-152c-11ea-8a1c-fdf96576a013.png)

In Redirect URI section, make sure you select **"Public client/native (mobile & desktop)"** and type **"urn:ietf:wg:oauth:2.0:oob"** as the redirection URI.

**5**. Click **Register** to complete. 

Now you should be in the Application's overview page, copy both **Application (client)  ID** and **Directory (tenant) ID** to the LinkedContacts settings.

**6**. Run **LinkedContacts.exe** and in the menu select **Options** -> **Settings**.

Check the checkbox "Use OAuth 2.0" and filling the ID's you got from previous step.

![app registration - linkedcontacts](https://user-images.githubusercontent.com/1156257/69988639-f078f700-1539-11ea-9286-adba4293bb7d.png)

Save the settings and you are ready to go.
