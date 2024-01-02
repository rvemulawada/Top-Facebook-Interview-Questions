//Link to Leetcode Problem: https://leetcode.com/problems/merge-intervals/

public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals.Length <= 1){
            return intervals;
        }

        // Sort the intervals based on the start time
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

        // List to store merged intervals
        List<int[]> merged = new List<int[]>();
        merged.Add(intervals[0]); // Add the first interval to the list
        int currIndex = 0; // Track the current index in the merged list

        for(int i = 1; i < intervals.Length; i++) {
            // Check for overlap between current and previous intervals
            if(merged[currIndex][1] >= intervals[i][0]) {
                // Merge the intervals by updating the end time of the current interval in merged list
                merged[currIndex][1] = Math.Max(merged[currIndex][1], intervals[i][1]);
            } else {
                // Add a new interval as there's no overlap
                merged.Add(intervals[i]);
                currIndex++;
            }
        }

        return merged.ToArray(); // Convert the merged list to array and return
    }
}


