public class Solution {
    public string ReplaceDigits(string s) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < s.Length; i += 2){
            sb.Append(s[i]);
            if(i + 1 < s.Length) sb.Append((char)(s[i] + (s[i + 1] - '0')));
        }

        return(sb.ToString());
    }
}
