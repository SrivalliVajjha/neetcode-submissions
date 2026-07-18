public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int prefix =1, postfix =1;
       int[] numsPrefix = new int[nums.Length];
       int[] numsPostfix = new int[nums.Length];
       for(int i=0;i<nums.Length;i++){
           if(i==0){
            numsPrefix[i] = 1; 
           }
           else{
            numsPrefix[i] = (numsPrefix[i-1] * nums[i-1]);
           }
           Console.WriteLine("i:"+i+"value:"+ numsPrefix[i]);
       }
    
       for(int i=nums.Length-1;i>=0;i--){
        if(i==nums.Length-1){
            numsPostfix[i] = 1 ; 
        }
        else{
            numsPostfix[i] = numsPostfix[i+1] * nums[i+1];
        }
        Console.WriteLine("i:"+i+"value:"+numsPostfix[i]);
       }

       for(int i=0;i<nums.Length;i++){
        nums[i] = numsPostfix[i] * numsPrefix[i];
        
        Console.WriteLine("i:"+i+"value:"+nums[i]);
       }
      return nums;
    }
}
