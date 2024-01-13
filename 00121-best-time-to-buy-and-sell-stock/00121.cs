public class Solution {
    public int MaxProfit(int[] prices) {
        // If there aren't at least two items in the prices array, then there is no valid answer.
        if (prices == null || prices.Length < 2)
        {
            return 0;
        }

        // Create left and right pointers starting at the first two positions of the prices array.
        int left = 0;
        int right = 1;

        // Track the maximum profit.
        int maxProfit = 0;

        // Iterate through prices until the right pointer reaches the end of the prices array.
        while (right < prices.Length)
        {
            // We have a profit if the price at the left pointer is less than the price at the right pointer.
            // Compare this profit against the current maximum profit. If it's greater, this is now the new maximum profit.
            if (prices[left] < prices[right])
            {
                int profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            // If the profit is not greater than the maximum profit, then move the left pointer to the right pointer's location.
            else
            {
                left = right;
            }

            // Increment the right pointer
            right++;
        }

        // Return the maximum profit found. If no profit was found, return 0.
        return maxProfit;
    }
}
