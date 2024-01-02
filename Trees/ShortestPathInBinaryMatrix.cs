//Link to Leetcode Problem Statement: https://leetcode.com/problems/shortest-path-in-binary-matrix/description/ 

public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if (grid == null || grid.Length == 0) {
            return 0;
        }

        int m = grid.Length;
        int n = grid[0].Length;

        // Check if the starting or ending cell is blocked
        if (grid[0][0] == 1 || grid[m - 1][n - 1] == 1) {
            return -1;
        }

        // Directions for 8-way movement: up, down, left, right, and diagonals
        int[][] dirs = new int[][] {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 },
            new int[] { 1, 1 },
            new int[] { -1, -1 },
            new int[] { 1, -1 },
            new int[] { -1, 1 }
        };

        Queue<int[]> q = new Queue<int[]>();
        q.Enqueue(new int[] { 0, 0, 1 }); // Enqueue the starting cell (row, col, distance)

        while (q.Count > 0) {
            int[] currentCell = q.Dequeue();
            int row = currentCell[0];
            int col = currentCell[1];
            int distance = currentCell[2];

            // Check if reached the destination
            if (row == m - 1 && col == n - 1) {
                return distance;
            }

            // Explore neighboring cells
            foreach (int[] dir in dirs) {
                int newRow = dir[0] + row;
                int newCol = dir[1] + col;

                // Check if the new position is within grid bounds and unblocked
                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && grid[newRow][newCol] == 0) {
                    q.Enqueue(new int[] { newRow, newCol, distance + 1 });
                    grid[newRow][newCol] = 1; // Mark cell as visited
                }
            }
        }
        return -1; // No valid path found
    }
}
