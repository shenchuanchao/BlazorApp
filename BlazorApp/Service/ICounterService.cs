namespace BlazorApp.Service
{
    public interface ICounterService
    {
        int Increment(int currentValue);
        int Decrement(int currentValue);
        void Reset();
    }
}
