using SecureCredentialsLibrary;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExpenseTracker.Controllers
{
    class LoginController
    {
        public static bool Login(string name)
        {
            bool value = false;
            try
            {
                CredentialsDialog dialog = new CredentialsDialog(Properties.Resources.APPLICATION_NAME,
                    null, Properties.Resources.LOGIN_MESSAGE);

                if (name != null)
                {
                    dialog.AlwaysDisplay = true; // prevent an infinite loop
                    dialog.KeepName = true; // constant username
                }

                if (dialog.Show(name) == DialogResult.OK)
                {
                    if (Authenticate(dialog.Name, dialog.Password))
                    {
                        value = true;
                        if (dialog.SaveChecked) dialog.Confirm(true);
                    }
                    else
                    {
                        try
                        {
                            MessageBox.Show(Properties.Resources.LOGIN_FAILED_MESSAGE,
                                Properties.Resources.LOGIN_FAILED_CAPTION,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dialog.Confirm(false);
                        }
                        catch (ApplicationException)
                        {
                            // TODO: Add logging
                        }
                        value = Login(dialog.Name);
                    }
                }
            }
            catch (ApplicationException)
            {
                // TODO: Add logging
            }
            return value;
        }

        private static bool Authenticate(string username, string password)
        {
            string domain = null;
            if (username.Contains('\\'))
            {
                string[] domainUser = username.Split('\\');
                username = domainUser[1];
                domain = domainUser[0];
            }
            IntPtr tokenHandler = IntPtr.Zero;
            return LogonUser(username, domain, password, (int)LogonType.LOGON32_LOGON_INTERACTIVE,
                (int)LogonProvider.LOGON32_PROVIDER_DEFAULT, ref tokenHandler);
        }

        #region Runtime Injected Methods

        [System.Runtime.InteropServices.DllImport("advapi32.dll")]
        private static extern bool LogonUser(string userName, string domainName, string password,
            int LogonType, int LogonProvider, ref IntPtr phToken);

        #endregion
    }
}
