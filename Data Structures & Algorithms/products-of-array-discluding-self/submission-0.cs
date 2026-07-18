public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] output = new int[n];
        
        // Initialize the output array with 1
        Array.Fill(output, 1);

        // Calculate left products
        int leftProduct = 1;
        for (int i = 0; i < n; i++)
        {
            output[i] = leftProduct;
            leftProduct *= nums[i];
        }

        // Calculate right products and multiply with left products
        int rightProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            output[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return output;
    }
}
