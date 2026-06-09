public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new();
        foreach(int n in nums){
            if(map.ContainsKey(n)){
                map[n] = map[n] + 1;
            }
            else{
                map[n] = 1;
            }
        }
        map = map.OrderByDescending(k=> k.Value).ToDictionary();
        return map.Keys.Take(k).ToList().ToArray();
    }
}
