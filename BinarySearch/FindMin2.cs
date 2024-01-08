//Link to Leetcode Problem: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/description/

    public int FindMin(int[] nums) {
         if(nums == null || nums.Length == 0)
            return -1;
        int left = 0, right = nums.Length - 1;
        
        while(left < right){
            int mid = left + (right - left )/2;
            if(nums[mid] > nums[right])
                left = mid + 1;
            else if(nums[mid] < nums[right])
                right = mid;
            else
                right--;
        }
        return nums[left];
    } 
