class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums: number[], target: number): number[] {
      const freqMap = new Map<number, number>();

      for(let i=0;i< nums.length; i++){
        const diff = target - nums[i];
        if(freqMap.has(diff)) return [freqMap.get(diff), i];
        freqMap.set(nums[i],i);
      }
      return [-1,-1];
    }
}
