//Link to Leetcode Problem: https://leetcode.com/problems/set-matrix-zeroes/

    public void SetZeroes(int[][] matrix) {

        if(matrix == null || matrix.Length == 0){
            return;
        }

        int m = matrix.Length;
        int n = matrix[0].Length;

        bool[] rows = new bool[m];
        bool[] cols = new bool[n];

        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                if(matrix[i][j] == 0){
                    rows[i] = true;
                    cols[j] = true;
                }
            }
        }


        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                if(rows[i] || cols[j]){
                    matrix[i][j] = 0;
                }
            }
        }
    }

