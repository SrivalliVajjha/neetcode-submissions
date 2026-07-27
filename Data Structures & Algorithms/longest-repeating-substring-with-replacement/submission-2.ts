class Solution {
    /**
     * @param {string} s
     * @param {number} k
     * @return {number}
     */
    characterReplacement(s: string, k: number): number {
        let l=0;
        let freq = new Map<string, number>();
        let maxFreq = 0;
        let maxCount =0;

        for(let r=0; r<s.length; r++){
            freq.set(s[r],(freq.get(s[r]) || 0) + 1);
            maxFreq = Math.max(maxFreq, freq.get(s[r]));
            while((r-l+1) - maxFreq > k){
                freq.set(s[l] , freq.get(s[l]) - 1);
                l++;
            }
            maxCount = Math.max(maxCount , r-l+1);
        }
        return maxCount;
    }
}
