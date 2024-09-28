using MetroFramework;
using MetroFramework.Controls;
using Rana.Entity;
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
    public partial class HelpView : MetroUserControl
    {
        private HelpViewModel _viewModel;

        public HelpView(HelpViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;

            ThemeComboBox.DataBindings.Add(nameof(ThemeComboBox.DataSource), _viewModel, nameof(_viewModel.ThemeComboBoxDataSource));
            ThemeComboBox.ValueMember = nameof(ObjectLv1<MetroThemeStyle, string>.Value1);
            ThemeComboBox.DisplayMember = nameof(ObjectLv1<MetroThemeStyle, string>.Value2);
            ThemeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ThemeComboBox.DataBindings.Add(nameof(ThemeComboBox.SelectedValue), _viewModel, nameof(_viewModel.ThemeComboBoxSelectedValue), false, DataSourceUpdateMode.OnPropertyChanged);

            ColorComboBox.DataBindings.Add(nameof(ColorComboBox.DataSource), _viewModel, nameof(_viewModel.ColorComboBoxDataSource));
            ColorComboBox.ValueMember = nameof(ObjectLv1<MetroColorStyle, string>.Value1);
            ColorComboBox.DisplayMember = nameof(ObjectLv1<MetroColorStyle, string>.Value2);
            ColorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorComboBox.DataBindings.Add(nameof(ColorComboBox.SelectedValue), _viewModel, nameof(_viewModel.ColorComboBoxSelectedValue), false, DataSourceUpdateMode.OnPropertyChanged);

        }
    }
}
