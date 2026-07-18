public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int prefix =1, postfix =1;
       int[] result = new int[nums.Length];

       for(int i=0;i<nums.Length;i++){
        result[i] = prefix;
        prefix = prefix * nums[i];
       }

       for(int i = nums.Length-1 ;i >=0 ;i--){
        result[i] *=  postfix;
        postfix = postfix * nums[i];
       }
       return result;
    }
}
