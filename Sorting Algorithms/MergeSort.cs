//Link to Leetcode Problem: https://leetcode.com/problems/sort-an-array/description/

    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    public void MergeSort(int[] nums, int start, int end) {
        if (start < end) {
            int mid = (start + end) / 2;
            MergeSort(nums, start, mid);
            MergeSort(nums, mid + 1, end);
            Merge(nums, start, mid, end);
        }
    }

    public void Merge(int[] nums, int start, int mid, int end) {
        int i = start, j = mid + 1, k = 0;
        int[] temp = new int[end - start + 1];
        while (i <= mid && j <= end) {
            if (nums[i] < nums[j])
                temp[k++] = nums[i++];
            else
                temp[k++] = nums[j++];
        }
        while (i <= mid) { temp[k++] = nums[i++]; } // copy remaining elements
        while (j <= end) { temp[k++] = nums[j++]; } // copy remaining elements
        for (int pointer = start; pointer <= end; pointer++) {
            nums[pointer] = temp[pointer - start];
        }
    }
