public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0){
            return false;
        }
        Stack<char> chars = new Stack<char>();
        foreach(char c in s){
            if(c == '(' || c == '{' || c == '['){
                chars.Push(c);
            }else{
               if(chars.Count == 0){
                return false;
               }
               char pop = chars.Pop();
               if(c == ')' && pop !='(' || c == '}' && pop !='{' || c == ']' && pop !='['){
                return false;
               }
            }
        }
        return chars.Count == 0;
    }
}
