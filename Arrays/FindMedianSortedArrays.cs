//Link to Leetcode Problem: https://leetcode.com/problems/median-of-two-sorted-arrays/description/

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length > nums2.Length){
            return FindMedianSortedArrays(nums2, nums1);
        }

        int x = nums1.Length, y = nums2.Length;

        int low = 0, high = x;
        while(low <= high){
            int partitionX = (low + high)/2;
            int partitionY = (x+y+1)/2 - partitionX;

       int maxLeftX = (partitionX == 0) ?int.MinValue : nums1[partitionX-1];
            int minRightX = (partitionX == x) ? int.MaxValue : nums1[partitionX];
            int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY-1];
            int minRightY = (partitionY == y) ? int.MaxValue : nums2[partitionY];
            
           if(maxLeftX <= minRightY && maxLeftY <= minRightX) {
                if((x+y)%2 ==0) 
                    return (double)(Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY))/2;
                else
                    return (double)Math.Max(maxLeftX, maxLeftY);
            } else if(maxLeftX > minRightY){
                high = partitionX-1;
            } else{
                low = partitionX+1;
            }    
        }
        return 0.0;
    }
}
