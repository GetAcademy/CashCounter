using CashCounter;

/*
    let coinCounts = [
        { value: 1, count: 7 },   // 7 stk. 1-kroninger
        { value: 5, count: 3 },   // 3 stk. 5-kroninger
        { value: 10, count: 2 },  // 2 stk. 10-kroninger
        { value: 10, count: 11 }, // 11 stk. 10-kroninger
    ];
*/

var coinCounts = new CoinCount[]
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

var totalValue = 0;
var totalCoinCount = 0;
foreach (var coinCount in coinCounts)
{
    totalValue += coinCount.GetValue();
    totalCoinCount += coinCount.Count;
}


//var everythings = new Everthing[]
//{
//    new Everthing{StringValue = "Terje"},
//    new Everthing{IntValue = 4},
//    new Everthing{BoolValue = true},
//};
