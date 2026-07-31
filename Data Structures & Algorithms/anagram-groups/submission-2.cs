public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> set = new();
        foreach(var str in strs){
         int[] count = new int[26];
         foreach(var s in str){
            count[s - 'a']++;
         }
         string key = string.Join(",", count);
         if(!set.ContainsKey(key)){
            set[key] = new List<string>();
         }
         set[key].Add(str);
        }
        return set.Values.ToList<List<string>>();
    }
}
