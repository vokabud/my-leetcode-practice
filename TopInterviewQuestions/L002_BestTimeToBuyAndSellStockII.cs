namespace TopInterviewQuestions;

// You are given an integer array prices where prices[i]
// is the price of a given stock on the ith day.

// On each day, you may decide to buy and/or sell
// the stock.You can only hold at most one share of
// the stock at any time.However, you can buy it
// then immediately sell it on the same day.

// Find and return the maximum profit you can achieve.

public class L002_BestTimeToBuyAndSellStockII
{
    public int MaxProfit(int[] prices)
    {
        var sum = 0;
        var startIndex = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i - 1] > prices[i])
            {
                sum += prices[i - 1] - prices[startIndex];
                startIndex = i;
                continue;
            }
        }

        if (startIndex < prices.Length)
        {
            sum += prices[prices.Length - 1] - prices[startIndex];
        }

        return sum;
    }
}
