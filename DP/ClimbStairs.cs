//Link to Leetcode Problem: https://leetcode.com/problems/climbing-stairs/

public int ClimbStairs(int n) {
    // If n is less than or equal to 2, return n (as there are only n ways to climb for these values)
    if (n <= 2) {
        return n;
    }

    // Initialize an array to store the number of ways to climb for each step up to 'n'
    int[] dp = new int[n + 1];

    // Base cases for the number of ways to climb for the first two steps
    dp[0] = 0; // No steps, so no ways to climb
    dp[1] = 1; // Only one step, one way to climb
    dp[2] = 2; // Two steps, two ways to climb

    // Iteratively calculate the number of ways to climb for each step from 3 to 'n'
    for (int i = 3; i <= n; i++) {
        // The number of ways to reach the current step 'i' is the sum of ways to reach the two preceding steps
        dp[i] = dp[i - 1] + dp[i - 2];
    }

    // Return the number of ways to climb to the nth step
    return dp[n];
}
