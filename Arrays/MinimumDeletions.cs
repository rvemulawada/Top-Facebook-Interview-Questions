//Link to Leetcode Problem: https://leetcode.com/problems/removing-minimum-and-maximum-from-array/description/

public class Solution {
    public int MinimumDeletions(int[] arr) {
        int min = arr[0], max = arr[0];
        int minIdx = 0, maxIdx = 0;

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] < min) {
                min = arr[i];
                minIdx = i;
            }
            if (arr[i] > max) {
                max = arr[i];
                maxIdx = i;
            }
        }

        if (minIdx == maxIdx) return 1;

        int left = Math.Min(minIdx, maxIdx);
        int right = Math.Max(minIdx, maxIdx);

        int a = right + 1;
        int b = arr.Length - left;
        int c = (left + 1) + (arr.Length  - right);

        return Math.Min(Math.Min(a, b), c);
    }
}
