public class Solution {
    public bool IsAnagram(string s, string t) {
       if(s.Length != t.Length){
        return false;
       }
       int[] charArr = new int[26];
       foreach(char c in s){
         charArr[c - 'a'] ++;
       }
       foreach(char c in t){
         charArr[c - 'a']--;
         if(charArr[c - 'a'] < 0){
            return false;
         }
       }
       return true;
    }
}
