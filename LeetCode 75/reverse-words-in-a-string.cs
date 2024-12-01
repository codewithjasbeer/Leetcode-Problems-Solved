public class Solution {
    public string ReverseWords(string s) {
        string reverseString = string.Empty;
       var words = s.Trim().Split(' ');
        foreach(var x in words)
        {   
               
           reverseString = x.Trim() + " " + reverseString.Trim();
           
         }
         return reverseString.Trim();
         
    }
}
