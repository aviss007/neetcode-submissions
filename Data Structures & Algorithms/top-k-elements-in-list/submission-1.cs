public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> numsFreq  = new();
        foreach(int num in nums){
         if(numsFreq.ContainsKey(num)){
            numsFreq[num]++;
         }
         else
         {
            numsFreq[num] = 1;
         }
        }
        List<int>[] bucket = new List<int>[nums.Length + 1];
        foreach(var n in numsFreq){
         var freq = n.Value;
         if(bucket[freq] is null){
            bucket[freq] = new List<int>();
         }
         bucket[freq].Add(n.Key);
        }
        List<int> result = new();
        for(int i = bucket.Length - 1; i > 0 && result.Count < k; i--){
         if(bucket[i] != null){
            result.AddRange(bucket[i]);
         }
        }
        return result.Take(k).ToArray();
    }
}
