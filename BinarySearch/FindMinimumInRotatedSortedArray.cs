//Link to Leetcode Problem: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/

public int findMin(int[] nums) {
    // Check for empty or null array
    if(nums == null || nums.length == 0)
        return -1;
    
    int left = 0, right = nums.length - 1;
    
    // Perform binary search
    while(left < right) {
        int mid = left + (right - left) / 2;
        
        // If the value at mid is greater than the value at right,
        // pivot lies in the right half; move left pointer
        if(nums[mid] > nums[right])
            left = mid + 1;
        else
            // Otherwise, pivot lies in the left half or mid itself;
            // move right pointer to mid
            right = mid;
    }
    
    // Return the minimum value found at the left pointer
    return nums[left];
}
