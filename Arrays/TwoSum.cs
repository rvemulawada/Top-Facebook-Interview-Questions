//Link to Leetcode Problem: https://leetcode.com/problems/two-sum/

    public int[] TwoSum(int[] nums, int target) {
       if(nums == null || nums.Length == 0){
           return new int[] {-1, -1};
       } 

       Dictionary<int, int> dict = new Dictionary<int, int>();

       for(int i=0; i< nums.Length; i++){
           int numToFind = target - nums[i];

           if(dict.ContainsKey(numToFind)){
               return new int[] {dict[numToFind], i};
           }
           else{
               if(!dict.ContainsKey(nums[i])){
                   dict.Add(nums[i], i);
               }
           }
       }
       return new int[] {-1, -1};
    }
