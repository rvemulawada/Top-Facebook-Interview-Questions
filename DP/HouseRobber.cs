//Link to Leetcode Problem: https://leetcode.com/problems/house-robber/

    public int Rob(int[] nums) {
        if(nums == null || nums.Length == 0) {
            return 0;
        }
        
        int n = nums.Length;
        int[] dp = new int[n];
        
        dp[0] = nums[0];
        if(n > 1) {
            dp[1] = Math.Max(nums[0], nums[1]);
        }

        for(int i = 2; i < n; i++) {
            dp[i] = Math.Max(dp[i - 1], nums[i] + dp[i - 2]);
        }
        
        return dp[n - 1];
    }
