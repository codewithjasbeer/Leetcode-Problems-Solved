public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
       int maxNum = candies.Max();
      return candies.Select( amount => amount + extraCandies >= maxNum).ToList();

    }
}
