class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums: number[], k: number): number[] {

     const freq = new Map<number,number>();

     for(const num of nums){
        freq.set(num, (freq.get(num) ||0)+1);
     }
     const arr = [...freq];
     arr.sort((a,b) => b[1]-a[1]);

     return arr.slice(0,k).map(ele => ele[0]);

    }
}
