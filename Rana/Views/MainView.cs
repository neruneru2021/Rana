using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Rana.ViewModels;
using System;
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

        internal void SetTheme(MetroThemeStyle theme)
        {
            MainView.Instance.RanaStyleManager.Theme = theme;
        }

        internal MetroThemeStyle GetTheme()
        {
            return MainView.Instance.RanaStyleManager.Theme;
        }

        internal void SetColor(MetroColorStyle color)
        {
            MainView.Instance.RanaStyleManager.Style = color;
        }

        internal MetroColorStyle GetStyle()
        {
            return MainView.Instance.RanaStyleManager.Style;
        }

        public MainView()
        {
            InitializeComponent();
            _instance = this;
            _viewModel = new MainViewModel(Dispatcher.CurrentDispatcher);

            this.StyleManager = MainView.Instance.RanaStyleManager;

            this.Load += (sender, e) =>
            {
                RanaStyleManager.Theme = Properties.Settings.Default.Theme;
                RanaStyleManager.Style = Properties.Settings.Default.Style;
                ShowView(nameof(LoginView), true);
            };

            this.FormClosed += (_, __) =>
            {
                Properties.Settings.Default.Theme = RanaStyleManager.Theme;
                Properties.Settings.Default.Style = RanaStyleManager.Style;
                Properties.Settings.Default.Save();
            };

            _viewModel.CloseAction += () => this.Close();
            CloseButton.Click += (_, __) => _viewModel.Close();

            this.StartPosition = FormStartPosition.CenterScreen;

            TitleLink.Click += (_, __) =>
            {
                MainView.Instance.ShowView(nameof(LoginView), false);
            };
        }
    }
}