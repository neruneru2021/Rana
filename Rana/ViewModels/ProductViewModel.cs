using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Rana.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        public ProductViewModel(Dispatcher dispatcher)
        {
            base.Dispatcher = dispatcher;
        }
    }
}
