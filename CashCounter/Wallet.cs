namespace CashCounter
{
    internal class Wallet
    {
        private CoinCount[] _coinCounts;

        public Wallet()
        {
            _coinCounts = new CoinCount[]
            {
                new CoinCount(1, 7),
                new CoinCount(5, 3),
                new CoinCount(10, 2),
                new CoinCount(10, 11),
                //new CoinCount { Value = 1, Count = 7 },
                //new CoinCount { Value = 5, Count = 3 },
                //new CoinCount { Value = 10, Count = 2 },
                //new CoinCount { Value = 10, Count = 11 },
            };
        }

        public Stats GetStats()
        {
            var totalValue = 0;
            var totalCoinCount = 0;
            foreach (var coinCount in _coinCounts)
            {
                totalValue += coinCount.GetValue();
                totalCoinCount += coinCount.Count;
            }
            return new Stats
            {
                TotalCoinCount = totalCoinCount, 
                TotalValue = totalValue
            };
        }
    }
}
