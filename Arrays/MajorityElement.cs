//Link to Leetcode Problem:

    public int MajorityElement(int[] nums) {
       Dictionary<int, int> dict = new Dictionary<int, int>();
       for(int i=0; i< nums.Length; i++){
           if(dict.ContainsKey(nums[i])){
               dict[nums[i]] = dict[nums[i]] + 1;
           }
           else{
               dict.Add(nums[i], 1);
           }
       }
        
      int len = nums.Length;
        
      for(int i=0; i< len; i++){
          if(dict[nums[i]] > len/2){
              return nums[i];
          }
      }
        return -1;
    }
