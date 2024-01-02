//Link to LeetCode Problem: https://leetcode.com/problems/plus-one/description/

public int[] PlusOne(int[] digits) {
    // Iterate through the digits array from right to left
    for (int i = digits.Length - 1; i >= 0; i--) {
        // If the current digit is less than 9, add 1 to it and return the updated array
        if (digits[i] < 9) {
            digits[i] = digits[i] + 1;
            return digits;
        }
        // If the current digit is 9, set it to 0 and continue to the next digit
        digits[i] = 0;
    }

    // If all digits are 9, create a new array with a length one greater than the original
    int[] result = new int[digits.Length + 1];
    result[0] = 1; // Set the most significant digit to 1 (as the entire number was 999...9)
    return result;
}
