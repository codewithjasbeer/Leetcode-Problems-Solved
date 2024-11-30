public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int str1Length = str1.Length;
        int str2Length = str2.Length;
        if((str1 + str2).Equals(str2 + str1))
        {
        BigInteger gcd = BigInteger.GreatestCommonDivisor(str1Length, str2Length);
       int index=(int)gcd;
        return str1.Substring(0,index);

        }
        else
        {
            return "";
        }
    }
}
