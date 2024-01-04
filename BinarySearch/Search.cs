//Link to Leetcode Problem: https://leetcode.com/problems/search-in-rotated-sorted-array/description/

public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0, high = nums.Length - 1;

        // Binary search loop
        while (low <= high) {
            int mid = low + (high - low) / 2;

            if (nums[mid] == target) {
                return mid; // Found the index
            }

            if (nums[low] <= nums[mid]) {
                // Left half is sorted
                if (nums[low] <= target && target < nums[mid]) {
                    high = mid - 1; // Adjusting high to search left side
                } else {
                    low = mid + 1; // Adjusting low to search right side
                }
            } else {
                // Right half is sorted
                if (nums[mid] < target && target <= nums[high]) {
                    low = mid + 1; // Adjusting low to search right side
                } else {
                    high = mid - 1; // Adjusting high to search left side
                }
            }
        }

        return -1; // Target not found
    }
}
