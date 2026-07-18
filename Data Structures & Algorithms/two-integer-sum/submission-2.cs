public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     Dictionary<int,int> indices = new Dictionary<int,int>();

    for(int i=0;i<nums.Length;i++){
        int diff = target - nums[i];
        if(indices.ContainsKey(diff))
        {
            int max = Math.Max(indices[diff],i);
            int min = Math.Min(indices[diff],i);
            return new int[]{min,max};
        }
        indices[nums[i]] = i;
    }
    return null;

    }
}
