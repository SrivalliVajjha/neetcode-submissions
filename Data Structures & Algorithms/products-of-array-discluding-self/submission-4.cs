public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prefix =1,postfix =1;
       int[] numsPrefix = new int[nums.Length];
       int[] numsPostfix = new int[nums.Length];
       for(int i=0;i<nums.Length;i++){
           numsPrefix[i] = prefix;
           prefix = prefix * nums[i];
       }
    
       for(int i=nums.Length-1;i>=0;i--){
        numsPostfix[i] = postfix;
        postfix = postfix * nums[i];
       }

       for(int i=0;i<nums.Length;i++){
        nums[i] = numsPostfix[i] * numsPrefix[i];
       }
      return nums;
    }
}
