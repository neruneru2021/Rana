using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
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
using System.Windows.Threading;

namespace Rana.Views
{
    public partial class MainView : MetroForm
    {
        private MainViewModel _viewModel;

        private static MainView _instance;

        public static MainView Instance
        {
            get { return _instance ?? new MainView(); }
        }

        internal void ShowView(string argViewName, bool isCreate)
        {
            //文字からインスタンスを生成
            string fullName = "Rana.Views." + argViewName;
            Type type = Type.GetType(fullName);
            var uc = (MetroUserControl)Activator.CreateInstance(type);

            if (MainPanel.Controls.ContainsKey(argViewName))
            {
                if (isCreate)
                {
                    MainPanel.Controls.RemoveByKey(argViewName);
                }
                else
                {
                    MainPanel.Controls[argViewName].BringToFront();
                    return;
                }
            }

            MainPanel.Controls.Add(uc);
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            uc.Parent = this;
            uc.BringToFront();
        }

        public MainView()
        {
            InitializeComponent();
            _instance = this;

            _viewModel = new MainViewModel(Dispatcher.CurrentDispatcher);
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;

            this.StyleManager = RanaStyleManager;
            //this.StyleManager = MainView.Instance.StyleManager;

            this.FormClosed += (_, __) => _viewModel.Dispose();

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

            _viewModel.CloseAction += () => this.Close();
            CloseButton.Click += (_, __) => _viewModel.Close();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Load += (sender, e) =>
            {
                _viewModel.Load();
                ThemeComboBox.SelectedIndexChanged += (__, _) => RanaStyleManager.Theme = _viewModel.RanaMetroThemeStyle.Value1;
                ColorComboBox.SelectedIndexChanged += (__, _) => RanaStyleManager.Style = _viewModel.RanaMetroColorStyle.Value1;

                ShowView(nameof(LoginView), true);
            };

            TitleLink.Click += (_, __) =>
            {
                MainView.Instance.ShowView(nameof(LoginView), false);
            };
        }

        private void _viewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(_viewModel.ThemeComboBoxSelectedValue):
                    RanaStyleManager.Theme = (MetroThemeStyle)_viewModel.ThemeComboBoxSelectedValue;
                    break;
                case nameof(_viewModel.ColorComboBoxSelectedValue):
                    RanaStyleManager.Style = (MetroColorStyle)_viewModel.ColorComboBoxSelectedValue;
                    break;
                default:
                    break;
            }
        }

        private void MainView_Shown(object sender, EventArgs e)
        {
            //初回の画面描画処理時だけでいい
            _viewModel.PropertyChanged -= _viewModel_PropertyChanged;
        }
    }
}