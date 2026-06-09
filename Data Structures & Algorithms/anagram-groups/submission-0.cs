public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new();
        foreach(var str in strs)
        {
            int[] count = new int[26];
            foreach(char c in str){
                count[c - 'a']++;
            }
            StringBuilder s = new();
            foreach(int a in count)
            {
               s.Append("#");
               s.Append(a);
            }
            string key = s.ToString();
            if(!map.ContainsKey(key)){
                map[key] = new List<string>();
            }
            map[key].Add(str);
        }
        return map.Values.Cast<List<string>>().ToList();
    }
}
