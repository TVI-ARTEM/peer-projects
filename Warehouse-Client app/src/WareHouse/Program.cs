using System;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using WareHouse.AppResources;
using WareHouse.Forms;

namespace WareHouse
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            while (true)
                try
                {
                    var culture = ConfigurationManager.AppSettings["culture"];
                    if (string.IsNullOrEmpty(culture)) culture = "en-US";

                    Thread.CurrentThread.CurrentCulture =
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Application.Run(new LoginForm());
                    var login = ConfigurationManager.AppSettings["login"];

                    if (string.IsNullOrEmpty(login)) login = "exit";

                    switch (login)
                    {
                        case "worker":
                            Application.Run(new Main());
                            break;
                        case "user":
                            Application.Run(new MainUser());
                            break;
                    }

                    break;
                }
                catch (Exception exception)
                {
                    if (MessageBox.Show(exception.Message, ApplicationStrings.FatalErrorMessage,
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error) == DialogResult.Retry) continue;

                    break;
                }
        }
    }
}