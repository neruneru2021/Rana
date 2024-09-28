using Rana.Area;
using Rana.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Rana.ViewModels
{
    public class TreeViewModel : ViewModelBase
    {
        public TreeViewModel(Dispatcher dispatcher)
        {
            base.Dispatcher = dispatcher;
        }
    }
}