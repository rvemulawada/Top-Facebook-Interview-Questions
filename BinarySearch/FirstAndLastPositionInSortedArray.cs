//Link to Leetcode Problem - https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/

public class Solution {
    // Main function to search for the range of indices containing the target value
    public int[] SearchRange(int[] nums, int target) {
       if(nums == null || nums.Length == 0){
           return new int[] {-1, -1};
       } 

       int first = findFirst(nums, target);
       int last = findLast(nums, target);
       return new int[]{ first, last};
    }
      // Function to find the starting index of target value in nums array
    public int findFirst(int[] nums, int target){
        int idx = -1;
        int start = 0, end = nums.Length-1;

        while(start <= end){
            int mid = (start + end)/2;

            if(nums[mid] >= target){
                end = mid - 1;
            }
            else{
                start = mid + 1;
            }

            if(nums[mid] == target) idx = mid;
        }
        return idx;
    }

    // Function to find the ending index of target value in nums array
    public int findLast(int[] nums, int target){
        int idx = -1;
        int start = 0, end = nums.Length-1;

        while(start <= end){
            int mid = (start + end)/2;

            if(nums[mid] <= target){
                start = mid + 1;
            }
            else{
                end = mid - 1;
            }

            if(nums[mid] == target) idx = mid;
        }
        return idx;
    }
}
