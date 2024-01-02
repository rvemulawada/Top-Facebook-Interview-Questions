//Link to Leetcode Problem: https://leetcode.com/problems/basic-calculator-ii/description/

public class Solution {
    public int Calculate(string s) {
        // Check if the input string is null or empty, return 0 if so
        if (s == null || s.Length == 0) {
            return 0;
        }

        int num = 0; // Variable to store the current number being formed
        char sign = '+'; // Initialize the sign as positive

        Stack<int> st = new Stack<int>(); // Stack to store intermediate calculation results
        int len = s.Length; // Store the length of the input string

        for (int i = 0; i < len; i++) {
            char c = s[i]; // Get the current character

            // If the character is a digit, continue forming the number
            if (Char.IsDigit(c)) {
                num = num * 10 + (c - '0');
            }

            // Check for non-digit characters (operators or end of string)
            if ((!Char.IsDigit(c) && c != ' ') || i == len - 1) {
                // Push the current number based on the previous sign
                if (c == '+') {
                    st.Push(num);
                } else if (c == '-') {
                    st.Push(-num); // Negate the number for subtraction
                } else if (sign == '*') {
                    if (st.Count > 0) {
                        st.Push(st.Pop() * num); // Perform multiplication
                    }
                } else if (sign == '/') {
                    if (st.Count > 0) {
                        int operand = st.Pop();
                        st.Push(operand / num); // Perform division
                    }
                }

                sign = c; // Update the sign for the next iteration
                num = 0; // Reset the number for the next calculation
            }
        }

        int result = 0;
        // Calculate the final result by summing up the values in the stack
        foreach (int n in st) {
            result += n;
        }
        
        return result; // Return the final calculated result
    }
}
