public class Solution {
    public bool IsPalindrome(string s) {
        s = s.Replace(" ","").ToLower();
        int l = 0;
        int r = s.Length -1;
        while(l<r){
            if(!char.IsLetterOrDigit(s[l])){
                l++;
            }
            else if(!char.IsLetterOrDigit(s[r])){
                r--;
            }
            else{
                if(s[l] != s[r])
                    return false;
                else{
                    l++;
                    r--;
                }
            }
        }
        return true;
    }
}
