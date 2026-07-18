public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int longestCount =0;
        
        foreach(int n in set){
            if(!set.Contains(n-1)){
                int len = 1;
                while(set.Contains(n+len)){
                    len++;
                }
                longestCount = Math.Max(longestCount,len);
            }
        }
        return longestCount;
    }
}
