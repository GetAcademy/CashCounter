namespace CashCounter
{
    internal class CoinCount
    {
        private readonly int _value;
        public int Count { get; }

        public CoinCount(int value, int count)
        {
            _value = value;
            Count = count;
        }

        public int GetValue()
        {
            return _value * Count;
        }

        //public void AddCount(int count)
        //{
        //    Count += count;
        //}
    }
}
