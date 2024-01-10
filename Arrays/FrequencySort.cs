//Link to Leetcode Problem: https://leetcode.com/problems/sort-characters-by-frequency/

public string FrequencySort(string s) {
        if (string.IsNullOrEmpty(s))
            return s;

        Dictionary<char, int> charFrequency = new Dictionary<char, int>();

        // Count the frequency of each character in the string
        foreach (char c in s) {
        if (charFrequency.ContainsKey(c))
            charFrequency[c]++;
        else
            charFrequency[c] = 1;
        }

         var bucket = new List<int>[s.Length +1];
        for (int i = 0; i < bucket.Length; i++)
        {
            bucket[i] = new List<int>();
        }

        foreach (var pair in charFrequency)
        {
            bucket[pair.Value].Add(pair.Key);
        }

        StringBuilder sortedString = new StringBuilder();
        for (int i = bucket.Length - 1; i >= 0; i--) {
            if (bucket[i] != null) {
                foreach (char c in bucket[i]) {
                    sortedString.Append(c, charFrequency[c]);
                }
            }
        }

        return sortedString.ToString();
    }
