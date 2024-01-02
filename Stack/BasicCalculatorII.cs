//Link to Leetcode Problem: https://leetcode.com/problems/basic-calculator-ii/description/

public class Solution {
    public int Calculate(string s) {
        if (s == null || s.Length == 0) {
            return 0;
        }

        int num = 0;
        char sign = '+';
        Stack<int> st = new Stack<int>();
        int len = s.Length;

        for (int i = 0; i < len; i++) {
            char c = s[i];
            if (Char.IsDigit(c)) {
                num = num * 10 + (c - '0');
            }
            if ((!Char.IsDigit(c) && c != ' ') || i == len - 1) {
                if (sign == '+') {
                    st.Push(num);
                } else if (sign == '-') {
                    st.Push(-num);
                } else if (sign == '*') {
                    int operand = st.Pop();
                    st.Push(operand * num);
                } else if (sign == '/') {
                    int operand = st.Pop();
                    st.Push(operand / num);
                }
                sign = c;
                num = 0;
            }
        }

        int result = 0;
        while (st.Count > 0) {
            result += st.Pop();
        }
        return result;
    }
}
