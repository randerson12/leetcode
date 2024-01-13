public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        // If the intervals array is empty, return newInterval.
        if (intervals.Length == 0)
        {
            return new int[][] { newInterval };
        }

        // Initialize the result array.
        var result = new List<int[]>();

        // Iterate through the intervals array.
        foreach (var interval in intervals)
        {
            // If the first new interval is greater than the next interval, add the next interval to the result array.
            if (newInterval[0] > interval[1])
            {
                result.Add(interval);
            }
            // If the next new interval is less than the start value of the current interval, then add the new interval to the result.
            // All the intervals that come after this will be non-overlapping, so we can set the new interval to the current interval.
            else if (newInterval[1] < interval[0])
            {
                result.Add(newInterval);
                newInterval = interval;
            }
            // The new interval must be overlapping with the current interval.
            // Merge the new interval with the current interval.
            else
            {
                newInterval[0] = Math.Min(interval[0], newInterval[0]);
                newInterval[1] = Math.Max(interval[1], newInterval[1]);
            }
        }

        // Add the final new interval to the result and return it.
        result.Add(newInterval);
        return result.ToArray();
    }
}
