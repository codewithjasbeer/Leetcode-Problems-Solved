public class Solution {
    public string ReverseVowels(string s) {
        int length = s.Length;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u',  'A', 'E', 'I', 'O', 'U'};  
        var finalStr = new StringBuilder();
        var stackVow = new Stack<char>();                 
        foreach(var x in s)
        {
          if(vowels.Contains(x))
        stackVow.Push(x);
         }

            foreach(var x in s)
                {
                if(vowels.Contains(x))
            finalStr.Append(stackVow.Pop());
       else
            finalStr.Append(x);
                }
        return finalStr.ToString();
                 }
}
