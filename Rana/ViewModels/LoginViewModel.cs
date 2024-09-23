using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Rana.ViewModels
{
    public sealed class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(Dispatcher dispatcher)
        {
            base.Dispatcher = dispatcher;
        }

        private string _loginTextBoxText = string.Empty;
        public string LoginTextBoxText
        {
            get { return _loginTextBoxText; }
            set
            {
                SetProperty(ref _loginTextBoxText, value);
            }
        }

        private string _passwordTextBoxText = string.Empty;
        public string PasswordTextBoxText
        {
            get { return _passwordTextBoxText; }
            set
            {
                SetProperty(ref _passwordTextBoxText, value);
            }
        }

        internal void LoginButtonClick()
        {
            
        }
    }
}
