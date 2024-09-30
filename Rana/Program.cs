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

        private static void EnumForeach()
        {
            foreach (ResultEnum result in Enum.GetValues(typeof(ResultEnum)))
                MessageBox.Show(result.ToMsgString());
        }
    }

    public enum ResultEnum
    {
        Success,
        failure,
        Warning
    }

    public static class ResultExtention
    {
        public static string ToMsgString(this ResultEnum result)
        {
            switch (result)
            {
                case ResultEnum.Success:
                    return "The process has been successfully completed.";
                case ResultEnum.failure:
                    return "An exception has occurred";
                case ResultEnum.Warning:
                    return "There is a warning.";
                default:
                    throw new ArgumentException("Undefined parameter detected!");
            }
        }
    }




}