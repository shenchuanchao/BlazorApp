namespace BlazorApp.Service
{
    public class CounterService : ICounterService
    {
        public int Increment(int currentValue)
        {
            return currentValue + 1;
        }

        public int Decrement(int currentValue)
        {
            return currentValue - 1;
        }

        public void Reset()
        {
            // 重置逻辑
        }
    }
}
