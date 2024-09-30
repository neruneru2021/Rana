using MetroFramework;
using MetroFramework.Controls;
using Rana.Entity;
using Rana.ViewModels;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Rana.Views
{
    public partial class StyleView : MetroUserControl
    {
        private StyleViewModel _viewModel = new StyleViewModel(Dispatcher.CurrentDispatcher);

        public StyleView()
        {
            InitializeComponent();

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

            //ThemeComboBox.SelectedIndexChanged += (__, _) => MainView.Instance.RanaStyleManager.Theme = _viewModel.RanaMetroThemeStyle.Value1;
            ThemeComboBox.SelectedIndexChanged += (__, _) => MainView.Instance.SetTheme(_viewModel.RanaMetroThemeStyle.Value1);
            //ColorComboBox.SelectedIndexChanged += (__, _) => MainView.Instance.RanaStyleManager.Style = _viewModel.RanaMetroColorStyle.Value1;
            ColorComboBox.SelectedIndexChanged += (__, _) => MainView.Instance.SetColor(_viewModel.RanaMetroColorStyle.Value1);
        }
    }
}