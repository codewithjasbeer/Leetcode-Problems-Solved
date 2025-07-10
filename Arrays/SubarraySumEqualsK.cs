public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int,int>();
        map[0]=1;
        int count=0, sum=0;

        foreach(int num in nums){
            sum += num;
            if(map.ContainsKey(sum-k)){
                count += map[sum-k];
            }
            if(map.ContainsKey(sum)){
                map[sum]++;
            }
            else
            {
                map[sum]=1;
            }
        }
        return count;
    }
}
