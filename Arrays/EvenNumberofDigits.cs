//Given an array number of integers, return how many of them contain an even number of digits.

public class Solution {
    public int FindNumbers(int[] nums) {
         int evenNumbers;
 int ListNumbers;
 List<int> numbers = new List<int>();
 foreach (int num in nums)
 {
     int n = num;
     int digits = Math.Abs(n).ToString().Length;
     if(digits%2 == 0 )
     {
         evenNumbers = n;
         numbers.Add(n);
     }
 }
 ListNumbers = numbers.Count;
 return ListNumbers;
    }
}
