public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int n = height.Length;
        int i=0, j=n-1;

        while(i<j)
        {
            int width = j-i;
            int currentheight = Math.Min(height[i], height[j]);
            maxArea = Math.Max(maxArea, width * currentheight);

            if(height[i] <= height[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return maxArea;
    }
}
