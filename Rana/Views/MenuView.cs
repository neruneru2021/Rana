using MetroFramework.Controls;
using Rana.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Rana.Views
{
    public partial class MenuView : MetroUserControl
    {
        public MenuViewModel _viewModel { get; set; }

        public MenuView()
        {
            InitializeComponent();

            _viewModel = new MenuViewModel(Dispatcher.CurrentDispatcher);

            TreeMetroTile.Click += (_, __) => _viewModel.TreeMetroTileClick();
        }
    }
}
