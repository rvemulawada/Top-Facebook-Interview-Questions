//Link to Leetcode problem: https://leetcode.com/problems/valid-parentheses/description/

public class Solution {
    public bool IsValid(string s) {
        // Check for invalid input
        if(s == null || s.Length == 0) {
            return false;
        }

        // Initialize a stack to hold opening brackets
        Stack<char> st = new Stack<char>();

        // Convert the input string to a character array
        char[] ch = s.ToCharArray();

        // Iterate through each character in the string
        foreach(char c in ch) {
            // Push the corresponding closing bracket onto the stack for each opening bracket encountered
            if(c == '(') {
                st.Push(')');
            } else if(c == '[') {
                st.Push(']');
            } else if(c == '{') {
                st.Push('}');
            } else {
                // If a closing bracket is encountered and the stack is empty or the closing bracket doesn't match the top of the stack, return false
                if(st.Count == 0 || st.Pop() != c) {
                    return false;
                }
            }
        }

        // Return true if the stack is empty (all opening brackets were properly closed)
        return st.Count == 0;
    }
}
