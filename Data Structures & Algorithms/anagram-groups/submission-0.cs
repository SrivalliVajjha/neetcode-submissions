public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string,List<string>> groupAnagrams = new Dictionary<string,List<string>>();

        foreach(string str in strs){
            string key = String.Concat(str.OrderBy(c=>c));

            if(!groupAnagrams.ContainsKey(key))
            {
                groupAnagrams[key] = new List<string>();
            }
            groupAnagrams[key].Add(str);
        }

        return new List<List<string>>(groupAnagrams.Values);
    }
}
