//Link to Leetcode Problem: https://leetcode.com/problems/reverse-words-in-a-string/

public class Solution {
    public string ReverseWords(string s) {
        if (s == null) return null;

        char[] a = s.ToCharArray();
        int n = a.Length;

        // Step 1: Reverse the whole string
        Reverse(a, 0, n - 1);
        // Step 2: Reverse each word
        ReverseWords(a, n);
        // Step 3: Clean up spaces
        return CleanSpaces(a, n);
    }

    // Reverse characters in the range [i, j]
    private void Reverse(char[] a, int i, int j) {
        while (i < j) {
            char t = a[i];
            a[i++] = a[j];
            a[j--] = t;
        }
    }
    
    // Reverse each word in the given character array
    void ReverseWords(char[] a, int n) {
        int i = 0, j = 0;

        while (i < n) {
            while (j < n && a[j] != ' ') {
                j++;
            }
            Reverse(a, i, j - 1); // Reverse the word
            i = j + 1;
            j++;
        }
    }

    // Trim leading, trailing, and multiple spaces
    string CleanSpaces(char[] a, int n) {
        int i = 0, j = 0;

        while (j < n) {
            while (j < n && a[j] == ' ') j++; // Skip spaces
            while (j < n && a[j] != ' ') a[i++] = a[j++]; // Keep non-spaces
            while (j < n && a[j] == ' ') j++; // Skip spaces
            if (j < n) a[i++] = ' '; // Keep only one space
        }

        return new string(a).Substring(0, i); // Convert modified character array to string
    }
}
