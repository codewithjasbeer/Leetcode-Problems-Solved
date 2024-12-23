# Find the Highest Altitude - A Simple Prefix SUM

# Intuition
Using Prefix sum, it can be solved easily

# Approach
1. Start with an initial altitude of 0;
2. Use a cumulative sum approach to calculate the alt at each step;
3. Keep track of the max altitude during each step


# How it Works
- Start with currentAlt as 0 and maxAlt as 0;
- For each altitude change
    currentAlt = currentAlt + gain at each step
- Update the maximum altitude
    maxAlt = Math.max(maxAlt + currentAlt);

# Complexity
Time complexity: O(n)
  The array is traversed once.
Space complexity: O(1)
  Few variables are used only.

```

public class Solution {
    public int LargestAltitude(int[] gain) {
        int currentAlt = 0;
        int maxAlt =0;

        foreach(int i in gain)
        {
            currentAlt += i;
            maxAlt = Math.Max(maxAlt, currentAlt);
        }
        return maxAlt;
    }
}

```

