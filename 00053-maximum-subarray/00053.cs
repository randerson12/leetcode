public class Solution {
    public int MaxSubArray(int[] nums)
    {
        // Track the current and maximum sums.
        var sum = 0;
        var maxSum = nums[0];

        // Iterate through the nums array.
        for (int i = 0; i < nums.Length; i++)
        {
            // Add nums[i] to the current sum.
            sum += nums[i];

            // If nums[i] is greater than the current sum, set the sum to nums[i].
            if (nums[i] > sum)
            {
                sum = nums[i];
            }

            // If the current sum is greater than the maximum sum, update maxSum.
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        // Return the maximum sum.
        return maxSum;
    }
}
