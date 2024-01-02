//Link to leetcode Problem: https://leetcode.com/problems/move-zeroes/

public class Solution {
    public void MoveZeroes(int[] nums) {
       int insertPos = 0;
       if(nums == null || nums.Length == 0){
           return;
       } 

       for(int i=0; i<nums.Length; i++){ //traverse 0 to end
           if(nums[i] != 0){ //if it's not zero
               nums[insertPos] = nums[i]; //insert it at the start and increment index
               insertPos++;
           }
       }

        //insert zeroes in remaining positions
       while(insertPos < nums.Length){
           nums[insertPos] = 0;
           insertPos++;
       }
    }
}
