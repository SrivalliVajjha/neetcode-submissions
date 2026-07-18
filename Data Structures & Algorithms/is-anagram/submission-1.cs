
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        string sortedS = String.Concat(s.OrderBy(c=>c));
        string sortedT = String.Concat(t.OrderBy(c=>c));

        return sortedS.Equals(sortedT);
    }
}

// public class Solution {
//     public bool IsAnagram(string s, string t) {
//         if (s.Length != t.Length) return false;

//         int[] store = new int[26];

//         for (int i = 0; i < s.Length; i++) {
//             store[s[i] - 'a']++;
//             store[t[i] - 'a']--;
//         }

//         foreach (int n in store) if (n != 0) return false;

//         return true;
//     }
// }
