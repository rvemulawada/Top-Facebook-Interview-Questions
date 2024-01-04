//Link to Leetcode Problem: https://leetcode.com/problems/insert-interval/description/

public int[][] Insert(int[][] intervals, int[] newInterval) {
    // Initialize a list to store the merged intervals
    List<int[]> result = new List<int[]>();

    // Iterate through each interval in the given array
    foreach(int[] interval in intervals) {
        // If the current interval's start is after the newInterval's end, add newInterval and update it
        if(interval[0] > newInterval[1]) {
            result.Add(newInterval);
            newInterval = interval;
        }
        // If the current interval's end is before newInterval's start, add the interval
        else if(interval[1] < newInterval[0]) {
            result.Add(interval);
        }
        // If there is an overlap between intervals, merge them by updating newInterval
        else {
            newInterval[0] = Math.Min(interval[0], newInterval[0]);
            newInterval[1] = Math.Max(interval[1], newInterval[1]);
        }
    }
    
    // Add the final merged interval to the result list
    result.Add(newInterval);
    
    // Convert the list of intervals to a 2D array and return
    return result.ToArray();
}
