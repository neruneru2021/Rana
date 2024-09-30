using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace Rana.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Dispatcher Dispatcher { get; set; }

        protected bool SetProperty<T>(ref T field,
            T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            var h = this.PropertyChanged;
            if (h != null)
            {
                if (Dispatcher != null)
                {
                    Dispatcher.Invoke(
                        () => h(this, new PropertyChangedEventArgs(propertyName)));
                }
                else
                {
                    h(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            return true;
        }
    }
}