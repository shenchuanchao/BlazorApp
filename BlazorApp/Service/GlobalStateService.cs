using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorApp.Service
{
    public class GlobalStateService : INotifyPropertyChanged
    {
        private int _counter;

        public int Counter
        {
            get => _counter;
            set
            {
                _counter = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
