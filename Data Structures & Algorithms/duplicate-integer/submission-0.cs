public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numsCount = new();
        for(int i=0;i<nums.Length;i++){
            if(numsCount.Contains(nums[i])){
                return true;
            }else{
                numsCount.Add(nums[i]);
            }
        }
        return false;
    }
}