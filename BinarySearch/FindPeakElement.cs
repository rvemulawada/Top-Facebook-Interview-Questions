//Link to Leetcode Problem:https://leetcode.com/problems/find-peak-element/description/

    public int FindPeakElement(int[] nums) {
        int left = 0, right = nums.Length - 1;

        // Binary search to find the peak element
        while (left < right) {
            int mid = (left + right) / 2; // Calculate the middle index

            // Check if the current element is greater than the next element
            if (nums[mid] > nums[mid + 1]) {
                right = mid; // If true, move the 'right' pointer to the left side
            } else {
                left = mid + 1; // If false, move the 'left' pointer to the right side
            }
        }

        return left; // Return the index of the peak element
    }
