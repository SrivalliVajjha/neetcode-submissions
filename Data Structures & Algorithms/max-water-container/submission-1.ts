class Solution {
    /**
     * @param {number[]} heights
     * @return {number}
     */
    maxArea(heights: number[]): number {
        let l=0;
        let r  = heights.length -1;
        let maxWater = 0;
        while( l < r){
          const waterCon = (r-l) * Math.min(heights[l],heights[r]);
          if(heights[l] > heights[r]) r--;
          else if(heights[l] < heights[r]) l++;
          else{
            r--;
            l++;
          }
           maxWater = Math.max(maxWater,waterCon);
        }
       return maxWater;
    }
}
