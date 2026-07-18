class Solution {
    /**
     * @param {string} s
     * @param {number} k
     * @return {number}
     */
    characterReplacement(s: string, k: number): number {
        // variable window
        // use map
        let str = s.toUpperCase().split(" ").join("").trim();

        let l=0; 
        let count =0;
        let maxCount =0;
        let freq = new Map<string,number>();
        
        for(let r=0; r< str.length; r++){
            freq.set(str[r], (freq.get(str[r]) || 0)+1);
            maxCount = Math.max(maxCount, freq.get(str[r]!));
            while((r-l+1) - maxCount > k){
                freq.set(s[l],freq.get(s[l]!) - 1);
                l++;
            }
            count = Math.max(count, r-l+1);
        }
        return count;
    }
}
