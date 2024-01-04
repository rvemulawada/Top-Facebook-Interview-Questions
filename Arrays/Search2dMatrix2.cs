//Link to Leetcode Problem:https://leetcode.com/problems/search-a-2d-matrix-ii/description/

//Java
public boolean searchMatrix(int[][] matrix, int target) {
        if(matrix == null || matrix.length == 0) return false; 
        int rows = 0, cols = matrix[0].length-1;   //start at the top-right most corner as shown in above image
        while(rows <= matrix.length-1 && cols >= 0) {
            if(target == matrix[rows][cols]) return true;
            else if(target < matrix[rows][cols]) 
                cols--;
            else 
                rows++;
        }
        return false;
    }
