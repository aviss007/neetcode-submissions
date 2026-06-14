public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder s =  new();
        foreach(var item in strs){
            s.Append(item.Length);
            s.Append("#");
            s.Append(item);
        }
        return s.ToString();
    }

    public List<string> Decode(string s) {
     List<string> result  = new();
     int i= 0;
     while(i<s.Length){
        int j = i;
        while(s[j]!='#'){
            j++;
        }
        int length = int.Parse(s.Substring(i,j-i));
        j++;
        string word = s.Substring(j,length);
        i = j + length;
        result.Add(word);
     }
     return result;
   }
}
