public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> set = new();
        foreach(var str in strs){
         char[] arr = str.ToCharArray();
         Array.Sort(arr);
         string s = new string(arr);
         if(!set.ContainsKey(s)){
            set[s] = new List<string>();
         }
         set[s].Add(str);
        }
        return set.Values.ToList<List<string>>();
    }
}
