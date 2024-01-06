//Link to Leetcode Problem:https://leetcode.com/problems/minimum-size-subarray-sum/description/

    public int MinSubArrayLen(int target, int[] nums) {
        int minLength = int.MaxValue;

         // Initialize variables for window
        int windowStart =0, windowSum = 0;

        for(int windowEnd=0; windowEnd< nums.Length; windowEnd++){
            //Expand the window
            windowSum = windowSum + nums[windowEnd];

            // Update minLength when the current window matches the target
            //Shrink window
            while(windowSum >= target){
                minLength = Math.Min(minLength, windowEnd - windowStart + 1);
                windowSum -= nums[windowStart];
                windowStart++;
            }
        }
        return minLength == int.MaxValue ? 0 : minLength;
    }
