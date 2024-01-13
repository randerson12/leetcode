public class Solution {
    public int Search(int[] nums, int target) {
        // Initialize the result at -1 in case it is not found.
        var result = -1;

        // Initialize left and right pointers at the edges of the nums array.
        var left = 0;
        var right = nums.Length - 1;

        // Continue comparing values of the nums array at the left and right pointers until the target is reached.
        while (left <= right)
        {
            // Find the midway point of the nums array.
            // Instead of (left + right) / 2, we use (left + (right - left) / 2) to avoid integer overflow.
            // That gives us half of the distance between left and right.
            var mid = left + ((right - left) / 2);
            var midValue = nums[mid];

            // If midValue is equal to our target, return the result immediately.
            if (midValue == target)
            {
                result = mid;
                break;
            }
            // Move the left pointer to the right of the mid pointer if the current value is less than the target.
            else if (midValue < target)
            {
                left = mid + 1;
            }
            // Move the right pointer to the left of the mid pointer if the current value is greater than the target.
            else
            {
                right = mid - 1;
            }
        }

        // After the value comparison is done, return the result.
        return result;
    }
}
