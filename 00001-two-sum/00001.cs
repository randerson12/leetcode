public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // If there are fewer than two numbers in the nums array, no solution exists. Return [0, 0].
        if (nums == null || nums.Length < 2)
        {
            return new int[2];
        }

        // Initialize a hash table to track unique numbers in the nums input array and iterate through nums.
        // There is no need to track the same number from nums multiple times.
        // The key of uniqueNumbers is the number from nums, and the value is the index.
        // For example, if nums[1] = 5, then uniqueNumbers[5] = 1.
        var uniqueNumbers = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            // Look for a complement to nums[i] in uniqueNumbers. If it exists, we've found the solution.
            // For example, if target = 3, nums[1] = 2, and uniqueNumbers[0] = 1, then the solution is [0, 1]
            if (uniqueNumbers.ContainsKey(target - nums[i]))
            {
                return new int[] { uniqueNumbers[target - nums[i]], i };
            }

            // Add nums[i] to uniqueNumbers if it isn't already there.
            if (!uniqueNumbers.ContainsKey(nums[i]))
            {
                uniqueNumbers.Add(nums[i], i);
            }
        }

        // If no complement was found above, then no solution exists. Return [0, 0].
        return new int[2];
    }
}
