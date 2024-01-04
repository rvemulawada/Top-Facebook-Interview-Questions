//Link to Leetcode Problem: https://leetcode.com/problems/search-a-2d-matrix/description/

    public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix == null || matrix.Length == 0){
          return false;
        }
        int m=matrix.Length;
        int n=matrix[0].Length;

        int left =0, right = m*n-1;
        while(left <= right){
          int mid = left + (right-left)/2;
          int mid_point = matrix[mid/n][mid%n];

          if(mid_point == target){
            return true;
          }else if(mid_point > target){
            right = mid - 1;
          }else{
            left = mid + 1;
          }
        }
        return false;
    }
