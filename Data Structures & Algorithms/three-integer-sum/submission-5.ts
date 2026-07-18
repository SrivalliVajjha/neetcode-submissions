class Solution {
    /**
     * @param {number[]} nums
     * @return {number[][]}
     */
    threeSum(nums: number[]): number[][] {

     const sorted : number[] = [...nums].sort((a,b) => a-b);
     const res: number[][] = []; 

    for(let i=0; i< nums.length; i++){
        if(i >0 && sorted[i] === sorted[i-1]) continue; 
       let l= i+1;
       let r = nums.length -1;
       while(l<r){
          const sum = sorted[i] + sorted[l] + sorted[r];
          if(sum > 0) r--;
          else if (sum < 0) l++;
          else {
              res.push([sorted[i],sorted[l],sorted[r]]);
              l++;
              r--;
              while (l < r && sorted[l] === sorted[l-1]) l++;
              while (l< r && sorted[r] === sorted[r+1]) r++;
          }
       }
    }
    return res;

    }
}
