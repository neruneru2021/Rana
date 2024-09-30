using MetroFramework;
using Rana.BindHelpers;
using Rana.Entity;
using Rana.Views;
using System;
using System.Linq;
using System.Windows.Threading;

namespace Rana.ViewModels
{
    public sealed class StyleViewModel : ViewModelBase
    {
        public StyleViewModel(Dispatcher dispatcher)
        {
            base.Dispatcher = dispatcher;

            ThemeComboBoxDataSource = new BindingListAsync<ObjectLv1<MetroThemeStyle, string>>(base.Dispatcher);
            foreach (MetroThemeStyle style in Enum.GetValues(typeof(MetroThemeStyle)))
                ThemeComboBoxDataSource.Add(new ObjectLv1<MetroThemeStyle, string>(style, style.ToString()));

            //RanaMetroThemeStyle = new ObjectLv1<MetroThemeStyle, string>(MetroThemeStyle.Default, MetroThemeStyle.Default.ToString());
            ThemeComboBoxSelectedValue = MainView.Instance.GetTheme();



            ColorComboBoxDataSource = new BindingListAsync<ObjectLv1<MetroColorStyle, string>>(base.Dispatcher);
            foreach (MetroColorStyle style in Enum.GetValues(typeof(MetroColorStyle)))
                ColorComboBoxDataSource.Add(new ObjectLv1<MetroColorStyle, string>(style, style.ToString()));

            //RanaMetroColorStyle = new ObjectLv1<MetroColorStyle, string>(MetroColorStyle.Default, MetroColorStyle.Default.ToString());
            ColorComboBoxSelectedValue = MainView.Instance.GetStyle();
        }

        public BindingListAsync<ObjectLv1<MetroThemeStyle, string>> ThemeComboBoxDataSource { get; set; }

        private object _themeComboBoxSelectedValue;
        public object ThemeComboBoxSelectedValue
        {
            get { return _themeComboBoxSelectedValue; }
            set
            {
                SetProperty(ref _themeComboBoxSelectedValue, value);

                RanaMetroThemeStyle =
                    (from t in ThemeComboBoxDataSource
                     where t.Value1 == (MetroThemeStyle)value
                     select t).FirstOrDefault();
            }
        }

        public ObjectLv1<MetroThemeStyle, string> RanaMetroThemeStyle { get; set; }

        public BindingListAsync<ObjectLv1<MetroColorStyle, string>> ColorComboBoxDataSource { get; set; }

        private object _colorComboBoxSelectedValue;
        public object ColorComboBoxSelectedValue
        {
            get { return _colorComboBoxSelectedValue; }
            set
            {
                SetProperty(ref _colorComboBoxSelectedValue, value);

                RanaMetroColorStyle =
                    (from t in ColorComboBoxDataSource
                     where t.Value1 == (MetroColorStyle)value
                     select t).FirstOrDefault();
            }
        }

        public ObjectLv1<MetroColorStyle, string> RanaMetroColorStyle { get; set; }
    }
}