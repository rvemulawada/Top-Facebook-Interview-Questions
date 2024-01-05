//Link to Leetcode Problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue,  maxProfit = 0;
        
        foreach(int price in prices){
            minPrice = Math.Min(price, minPrice);
            maxProfit = Math.Max(maxProfit, price-minPrice);
        }

        return maxProfit;
    }
