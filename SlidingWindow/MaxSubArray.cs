//Link to Leetcode Problem: https://leetcode.com/problems/maximum-size-subarray-sum-equals-k/

public class Solution {
    public int MaxSubArray(int[] nums, int k) {
        int maxSum = int.MinValue;  // Variable to store the maximum sum found
        int windowSum = 0;          // Sum of elements within the sliding window
        int windowStart = 0;        // Start of the sliding window

        for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++) {
            windowSum += nums[windowEnd];  // Expand the sliding window by adding the next element

            if (windowEnd >= k - 1) {  // Check if the window size has reached 'k'
                maxSum = Math.Max(maxSum, windowSum);  // Update the maximum sum found so far
                windowSum -= nums[windowStart];  // Shrink the window by subtracting the element at windowStart
                windowStart++;  // Move the window's start to the right
            }
        }

        return maxSum;  // Return the maximum sum of any contiguous subarray of size 'k'
    }
}
