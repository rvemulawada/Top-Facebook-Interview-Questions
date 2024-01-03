//Link to Leetcode Problem: https://leetcode.com/problems/product-of-array-except-self/

public int[] ProductExceptSelf(int[] nums) {
    // Check for empty or null input
    if (nums == null || nums.Length == 0) return null;

    int leftProduct = 1, rightProduct = 1;
    int[] result = new int[nums.Length];

    // Calculate products to the left of each element
    for (int i = 0; i < nums.Length; i++) {
        result[i] = leftProduct;
        leftProduct *= nums[i];
    }

    // Calculate products to the right of each element and update result
    for (int j = nums.Length - 1; j >= 0; j--) {
        result[j] *= rightProduct;
        rightProduct *= nums[j];
    }

    return result;
}
