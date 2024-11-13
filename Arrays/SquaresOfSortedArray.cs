//Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
//Constraints:
  //1 <= nums.length <= 104
  //-104 <= nums[i] <= 104
  //nums is sorted in non-decreasing order.

public class Solution {
    public int[] SortedSquares(int[] nums) {
          int[] squaredArray = new int[nums.Length];

  for (int i = 0; i<nums.Length; i++)
  {
      squaredArray[i] = nums[i] * nums[i];
  }
  Array.Sort(squaredArray);

       return squaredArray;
    }
}
