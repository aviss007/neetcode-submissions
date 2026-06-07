public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       for(int i=0;i<nums.Length;i++) {
        if(i == (nums.Length - 1)) {
            if(nums[i] == target){
                return new int[]{i};
            }
         }
         for(int j = i + 1; j < nums.Length; j++){
            if(nums[i] + nums[j] == target){
                return new int[]{i, j};
            }
         }
       }
       return [];
    }
}
