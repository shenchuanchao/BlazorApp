
using Fluxor;

namespace BlazorApp.Store
{
    public static class CounterReducers
    {
        [ReducerMethod]
        public static CounterState OnIncrementCount(CounterState state, IncrementCounterAction action)
        {
            return new CounterState(state.CurrentCount + 1);
        }

        [ReducerMethod]
        public static CounterState OnDecrementCount(CounterState state, DecrementCounterAction action)
        {
            return new CounterState(state.CurrentCount - 1);
        }

        [ReducerMethod]
        public static CounterState OnSetCount(CounterState state, SetCountAction action)
        {
            return new CounterState(action.Count);
        }
    }
}
