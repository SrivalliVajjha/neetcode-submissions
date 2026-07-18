
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        int[] alphabets = new int[26];

        for(int i=0;i<s.Length;i++){
            alphabets[s[i] - 'a']++;
            alphabets[t[i] - 'a']--;
        }

        foreach(int c in alphabets)
            if(c != 0)
                return false;
        return true;

    }
}


