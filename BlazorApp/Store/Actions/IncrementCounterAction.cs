namespace BlazorApp.Store
{
    public class IncrementCounterAction
    {
        public IncrementCounterAction()
        {
            Console.WriteLine("IncrementCountAction created");
        }
        public override string ToString() => "IncrementCounterAction";
    }


    public class DecrementCounterAction
    {
        public override string ToString() => "DecrementCounterAction";
    }

    public class SetCountAction
    {
        public int Count { get; }

        public SetCountAction(int count)
        {
            Count = count;
        }
    }

}
