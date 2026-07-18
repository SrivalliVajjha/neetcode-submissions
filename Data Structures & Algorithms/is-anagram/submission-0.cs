
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        var sortedS = String.Concat(s.OrderBy(c=>c));
        var sortedT = String.Concat(t.OrderBy(c=>c));

        return sortedS.Equals(sortedT);
    }
}
