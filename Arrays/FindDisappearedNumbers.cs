//Link to Leetcode Problem: https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/

public IList<int> FindDisappearedNumbers(int[] nums) {
        // Initialize a list to store the disappeared numbers
        List<int> result = new List<int>();
        
        // Check if the input array is null or empty
        if (nums == null || nums.Length == 0) {
            return result; // Return an empty list if the array is empty
        }

        // Iterate through each number in the array
        foreach (int n in nums) {
            int index = Math.Abs(n); // Get the absolute value of the number as an index
            if (nums[index - 1] > 0) {
                // If the value at the calculated index is positive, negate it (mark it as visited)
                nums[index - 1] = nums[index - 1] * -1;
            }
        }

        // Iterate through the modified array to find positive values
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) {
                // If the value is positive, it means the corresponding index was not visited
                // Add the missing number to the result list (index + 1)
                result.Add(i + 1);
            }
        }

        // Return the list of disappeared numbers
        return result;
    }
