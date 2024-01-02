// Link to Leetcode problem: https://leetcode.com/problems/group-anagrams/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var result = new List<IList<string>>();
        if(strs == null || strs.Length == 0){
            return result;
        }

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach(string s in strs){
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            String sortedStr = new String(charArray);

            if(!map.ContainsKey(sortedStr)){
                map.Add(sortedStr, new List<string>() {s});
            }
            else{
                map[sortedStr].Add(s);
            }
        }

        foreach(var kvp in map.Values){
            result.Add(kvp);
        }
        return result; 
    }
}
