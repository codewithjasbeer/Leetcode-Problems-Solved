public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Array.Sort(nums);
        int i = 0, j=nums.Length-1;
        int pairs = 0;
         while(i<j)
         {
            int pairNum = nums[i] + nums[j] ;
            if(pairNum == k)
            {
                i++;
                j--;
                pairs++;
            }
            else if(pairNum > k)
            {
                j--;
            }
            else
            {
                i++;
            }

         }
         return pairs;
    }
}
