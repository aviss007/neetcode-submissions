public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int n = nums.Length;
       int[] output = new int[n];
       output[0] = 1;
       for(int i= 1;i<n;i++){
        output[i] = output[i-1] * nums[i-1];
       }
       int suffix = 1;
       for(int j= n-1; j>=0;j--){
        output[j] *= suffix;
        suffix *= nums[j];
       }
       return output;
    }
}
