using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using Rana.BindHelpers;
using Rana.Entity;
using Rana.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Rana.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public event Action CloseAction;

        public MainViewModel(Dispatcher dispatcher)
        {
            base.Dispatcher = dispatcher;
        }

        internal void Close()
        {
            CloseAction?.Invoke();
        }
    }
}