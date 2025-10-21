using Fluxor;

namespace BlazorApp.Store
{
    [FeatureState]
    public record CounterState
    {
        public int CurrentCount { get; } = 0;

        // 必须有无参构造函数
        public CounterState() { }

        public CounterState(int currentCount)
        {
            CurrentCount = currentCount;
        }

        // 初始状态创建方法
        public static CounterState Initialize()
        {
            return new CounterState(0);
        }
    }

}
