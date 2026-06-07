public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
      Dictionary<char,int> firstStringCharCounts = new();
      Dictionary<char,int> secondStringCharCounts = new();
      for(int i=0;i<s.Length;i++){
        if(firstStringCharCounts.ContainsKey(s[i])){
            firstStringCharCounts[s[i]] = firstStringCharCounts[s[i]] + 1;
        }
        else{
           firstStringCharCounts.Add(s[i],1); 
        }
      }
      for(int j=0;j<t.Length;j++){
        if(secondStringCharCounts.ContainsKey(t[j])){
            secondStringCharCounts[t[j]] = secondStringCharCounts[t[j]] + 1;
        }
        else{
           secondStringCharCounts.Add(t[j],1); 
        }
      }
      bool result = true;
      foreach(var v in firstStringCharCounts){
        if(!secondStringCharCounts.ContainsKey(v.Key)){
            result = false;  
            break;
        }
        else {
            if(secondStringCharCounts[v.Key] != v.Value){
              result = false;  
              break;
            }
        }
      }
      return result;
    }
}
