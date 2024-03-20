/* When you run this program, you will see output indicating that the investors
 * are notified of the stock price changes.  This demonstrates the loose 
 * coupling between the stock market and the investors.  The stock market does
 * not need to know anything about the investors, and the investors do not
 * need to know anything about the stock market.  The stock market simply
 * notifies the investors when the stock price changes.  The investors can
 * then decide what to do with that information.
 */


// Create a stock market
StockMarket stockMarket = new("Omni Consumer Products");

// Create investors
Investor investor1 = new("John");
Investor investor2 = new("Alice");

// Register investors with the stock market
stockMarket.RegisterObserver(investor1);
stockMarket.RegisterObserver(investor2);


// Simulate stock price changes
stockMarket.SetStockPrice(100.00);
stockMarket.SetStockPrice(115.50);

// Investor Alice loses interest and unsubscribes
stockMarket.RemoveObserver(investor2);

// More stock price changes
stockMarket.SetStockPrice(98.75);