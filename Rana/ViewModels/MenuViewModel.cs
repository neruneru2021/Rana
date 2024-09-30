using Rana.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Rana.ViewModels
{
    public sealed class MenuViewModel : ViewModelBase
    {
        public MenuViewModel(Dispatcher dispatcher)
        {
            base.Dispatcher = dispatcher;
        }

        internal void ProductMetroTileClick()
        {
            MainView.Instance.ShowView(nameof(ProductView), true);
        }

        internal void StyleMetroTileClick()
        {
            MainView.Instance.ShowView(nameof(StyleView), true);
        }

        internal void TreeMetroTileClick()
        {
            MainView.Instance.ShowView(nameof(TreeView), true);
        }
    }
}
