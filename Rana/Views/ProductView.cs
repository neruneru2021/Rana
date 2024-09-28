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

namespace Rana.Views
{
    public partial class ProductView : MetroUserControl
    {
        public ProductViewModel _viewModel;

        public ProductView()
        {
            InitializeComponent();
        }
    }
}
