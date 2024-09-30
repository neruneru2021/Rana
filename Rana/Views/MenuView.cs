using MetroFramework.Controls;
using Rana.ViewModels;
using System.Windows.Threading;

namespace Rana.Views
{
    public partial class MenuView : MetroUserControl
    {
        private MenuViewModel _viewModel  = new MenuViewModel(Dispatcher.CurrentDispatcher);

        public MenuView()
        {
            InitializeComponent();

            TreeMetroTile.Click += (_, __) => _viewModel.TreeMetroTileClick();
            StyleMetroTile.Click += (_, __) => _viewModel.StyleMetroTileClick();
            ProductMetroTile.Click += (_, __) => _viewModel.ProductMetroTileClick();
        }
    }
}
