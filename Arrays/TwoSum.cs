public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int sum =0;
        for( int i=0; i<nums.Length; i++)
        {
            sum = target-nums[i];
            if(map.ContainsKey(sum))
            {
                return new int[] {map[sum], i};
            }
            map[nums[i]] = i;
        }
        return new int[] {};
    }
}
