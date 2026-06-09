public class Solution {
    public int MaxProfit(int[] prices) {
      int minPrice=prices[0];int maxProfit=0;
      for(int right=0;right<=prices.Length-1;right++){
        minPrice=Math.Min(minPrice,prices[right]);
        int profit=prices[right]-minPrice;        
        maxProfit=Math.Max(maxProfit,profit);
        
      } 
      return maxProfit; 
    }
}
