//Link to Leetcode Problem: https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/description/

public string MinRemoveToMakeValid(string s) {
    Stack<int> st = new Stack<int>();       // Stack to store indices of '('
    HashSet<int> set = new HashSet<int>();  // Set to store indices to be removed

    // Traverse the string and process '(' and ')'
    for (int i = 0; i < s.Length; i++) {
        if (s[i] == '(') {
            st.Push(i);  // Push index of '(' to the stack
        } else if (s[i] == ')') {
            if (st.Count > 0) {
                st.Pop();  // Pop if a matching '(' is found
            } else {
                set.Add(i); // If no matching '(', add index of ')' to the set
            }
        }
    }

    // Add remaining unmatched '(' indices to the set
    while (st.Count > 0) {
        set.Add(st.Pop());
    }

    StringBuilder sb = new StringBuilder();
    // Construct the final string excluding indices present in the set
    for (int i = 0; i < s.Length; i++) {
        if (!set.Contains(i)) {
            sb.Append(s[i]);
        }
    }
    return sb.ToString(); // Return the modified string
}


