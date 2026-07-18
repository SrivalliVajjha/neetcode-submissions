class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    longestConsecutive(nums: number[]): number {
        const sorted : number[] = [...nums].sort((a,b) => a-b);

        if(nums.length <=0) return 0;

        let count = 1;
        let result = 1;

        for(let i=1; i< nums.length; i++){
            if(sorted[i] === sorted[i-1]) continue;
            else if(sorted[i] === sorted[i-1]+1) count++;
            else count=1;
            result = Math.max(result, count);
        }
        return result;
    }
}
