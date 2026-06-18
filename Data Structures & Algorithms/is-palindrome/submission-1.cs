public class Solution {
    public bool IsPalindrome(string s) {
        int low = 0;
        int high = s.Length - 1;
         while(low<high){
            if(!char.IsLetterOrDigit(s[low])){
               low++;
            }
            else if(!char.IsLetterOrDigit(s[high])){
                high --;
            }
            else if(char.ToLower(s[low]) == char.ToLower(s[high])){
                low++;
                high--;
            }
            else {
                return false;
            }
         }
         return true;
    }
}
