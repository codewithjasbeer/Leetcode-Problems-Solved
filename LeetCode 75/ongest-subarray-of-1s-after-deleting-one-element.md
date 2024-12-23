# Find the Longest Subarrays of 1s in a binary array after deleting exactly one elemeny.
You can use the sliding window technique here.

# Approach
1. Use a two-pointer-sliding window to traverse the array
2. Maintain a count of zeroes (zeroCount) in the current window
3. if the zeroCount exceeds 1 (i.e., more than one 0 in the window), move the left pointer of the window until zeroCount becomes 1 again
4. Track the maximum size of the window during the traversal

```
public class Solution {
    public int LongestSubarray(int[] nums) {
        int n = nums.Length;
 int left = 0, zeroCount = 0, maxLength = 0;

 for (int right = 0; right < n; right++)
 {
     if (nums[right] == 0)
     {
         zeroCount++;
     }

     if (zeroCount > 1)
     {
         if (nums[left] == 0)
             zeroCount--;
         left++;
     }

     maxLength = Math.Max(maxLength, right-left);
     
 }
 return maxLength; 
    }
}

```


# How it works
1. Track Zeros - As you iterate, count how many 0s are in the current window
2. Adjust Window - If more than one 0 is present, shift the left pointer until the window is valid
3. Update Maximum Length - For every valid window, calculate its length and update the maximum
   
