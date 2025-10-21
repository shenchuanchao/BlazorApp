namespace BlazorApp.Service
{
    public class AppState
    {
        private int _counter;
        private string _userName = string.Empty;

        public int Counter
        {
            get => _counter;
            set
            {
                _counter = value;
                OnCounterChanged?.Invoke();
            }
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnUserNameChanged?.Invoke();
            }
        }

        public event Action? OnCounterChanged;
        public event Action? OnUserNameChanged;

        public void IncrementCounter()
        {
            Counter++;
        }
    }
}
