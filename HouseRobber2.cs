//Link to Leetcode Problem: https://leetcode.com/problems/house-robber-ii/

    public int Rob(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        } else if (nums.Length == 1) {
            return nums[0];
        }

        int n = nums.Length;

        // Calculate maximum profit considering two cases: including the first house and excluding the first house
        int maxProfitWithFirst = RobHelper(nums, 0, n - 2); // Exclude last house
        int maxProfitWithoutFirst = RobHelper(nums, 1, n - 1); // Exclude first house

        // Return the maximum of the two scenarios
        return Math.Max(maxProfitWithFirst, maxProfitWithoutFirst);
    }

    private int RobHelper(int[] nums, int start, int end) {
        int prevMax = 0;
        int currMax = 0;

        for (int i = start; i <= end; i++) {
            int temp = currMax;
            currMax = Math.Max(prevMax + nums[i], currMax);
            prevMax = temp;
        }

        return currMax;
    }
