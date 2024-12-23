# Intuition
This problem can be solved using Prefix sum concpet..
The Pivot index problem involves finding the index of an array such that the sum of elements to the left of the index is equal to the sum of the elements of the right.

Sum of elements on the left of the index = sum of the elements on the right of the index

# Approach
To solve this problem efficiently

1. Compute the total sum of the array
2. Traverse the array while maintaining a leftSum of elements to the left of the current index.
3. For the current index i"
 - Calculate the right sum using:
 rightSum = totalSum - leftSum - nums[i];
- if leftSum == rightSum, i is the pivot index.
4. If no pivot index is found, return -1

This approach avoids recomputing the sums repeatedly, making it efficient.

# Complexity
- Time complexity: O(n)

Traverse the array once in O(n)
- Space complexity: O(1)


# Code
```csharp []
public class Solution {
    public int PivotIndex(int[] nums) {
        int n = nums.Length;
        int leftSum=0, rightSum=0;
        int totalSum = nums.Sum();
        // totalSum = rightSum + leftSum + nums[i];
        //rightSum = totalSum-leftSum - nums[i];
        for(int i=0; i<n; i++)
        {
            rightSum = totalSum - leftSum - nums[i];

            if(leftSum == rightSum)
            {
                return i;
            }

            leftSum = leftSum + nums[i];
        }

        return -1;
    }
}
```
