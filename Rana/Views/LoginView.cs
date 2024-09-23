using MetroFramework.Controls;
using Rana.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Rana.Views
{
    public partial class LoginView : MetroUserControl
    {
        private LoginViewModel _viewModel = new LoginViewModel(Dispatcher.CurrentDispatcher);

        public LoginView()
        {
            InitializeComponent();

            LoginTextBox.DataBindings.Add(nameof(LoginTextBox.Text), _viewModel, nameof(_viewModel.LoginTextBoxText));
            PasswordTextBox.DataBindings.Add(nameof(PasswordTextBox.Text), _viewModel, nameof(_viewModel.PasswordTextBoxText));
            LoginButton.Click += (_, __) => _viewModel.LoginButtonClick();
        }
    }
}