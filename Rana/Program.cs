using Rana.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rana
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += ApplicationThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }

        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            string msg =
                string.Format(
                    "{0}\r\n\r\n{1}",
                    e.Exception.Message,
                    string.Join("\r\n", e.Exception.StackTrace.Replace("場所", "@").Split('@').ToList().Where(t => t.Trim() != "")));

            MessageBox.Show(msg);
        }
    }
}