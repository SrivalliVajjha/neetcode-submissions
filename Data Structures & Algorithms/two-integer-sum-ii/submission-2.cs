public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=0;
        int r= numbers.Length -1;
        while(l<=r){
            int sum = numbers[l]+numbers[r];
            if(sum == target){
                int min = Math.Min(l,r);
                int max = Math.Max(l,r);
                return new int[]{min+1,max+1};
            }
            else if(sum > target){
                r--;
            }
            else{
                l++;
            }
        }
        return null;
    }
}
