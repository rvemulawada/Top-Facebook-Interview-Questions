//Link to Leetcode Problem: https://leetcode.com/problems/maximum-average-subarray-i/description/

    public double FindMaxAverage(int[] nums, int k) {
        double result = 0.0, sum = 0.0;
        int start = 0, end = 0;   // start is inclusive, end is exclusive, end - start is the size of the current window.

        while (end < nums.Length) {
            sum += nums[end];

            if (end - start + 1 == k) {
                result = result == 0 ? sum / k : Math.Max(result, sum / k);
                sum -= nums[start];
                start++;
            }

            end++;
        }

        return result;
    }
