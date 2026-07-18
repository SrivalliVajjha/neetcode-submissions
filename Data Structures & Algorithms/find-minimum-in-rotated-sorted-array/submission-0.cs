public class Solution {
    public int FindMin(int[] nums) {
     int min = nums[0];
     int l = 0 ;int r = nums.Length -1;
     while (l<=r){
        if(nums[l] <= nums[r] ){
            return nums[l];
        }
        int mid = l + (r-l) /2 ;
        if(nums[mid] >= nums[l]){
            l = mid+1;
        } 
        else{
            r = mid;
        }
     }
    return 0;
    }
}
