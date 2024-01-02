//Link to Leetcode Probelm: https://leetcode.com/problems/basic-calculator/description/

public int Calculate(string s) {
    int curr = 0, result = 0, sign = 1;
    Stack<int> st = new Stack<int>();
    st.Push(sign); // Initialize stack with default sign value

    for (int i = 0; i < s.Length; i++) {
        char c = s[i];

        if (Char.IsDigit(c)) {
            // Calculate the numeric value of the current character
            curr = curr * 10 + (c - '0');
        } else if (c == '+' || c == '-') {
            // Update result with the current value taking into account the current sign
            result = result + (sign * curr);
            
            // Update sign based on the sign from the stack
            sign = st.Peek() * ((c == '+') ? 1 : -1);
            
            // Reset current value for the next sequence of digits
            curr = 0;
        } else if (c == '(') {
            // Push the current sign to the stack for nested parentheses
            st.Push(sign);
        } else if (c == ')') {
            // Remove the last sign when exiting the current parentheses scope
            st.Pop();
        }
    }

    // Add the final result considering the last sequence of digits and sign
    result = result + (sign * curr);
    return result;
}
