using MetroFramework.Controls;
using Rana.ViewModels;
using System.Windows.Threading;

namespace Rana.Views
{
    public partial class ProductView : MetroUserControl
    {
        public ProductViewModel _viewModel = new ProductViewModel(Dispatcher.CurrentDispatcher);

        public ProductView()
        {
            InitializeComponent();
        }
    }
}
