public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string finalWord = "";
        int maxLength = Math.Max(word1.Length, word2.Length);
        for(int i=0; i< maxLength; i++)
        {
            if(i<word1.Length)
            {
                finalWord += word1[i].ToString();
            }
             if(i<word2.Length)
            {
                finalWord += word2[i].ToString();
            }
        }
        return finalWord;
    }
}
