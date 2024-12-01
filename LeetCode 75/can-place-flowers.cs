public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int bedLength = flowerbed.Length;
      int count = 0;

      for(int i=0; i<bedLength;)
      {
        if(flowerbed[i]==0 && (i == 0 || flowerbed[i-1] == 0) && (i == bedLength-1 || flowerbed[i+1] ==0))
        {
          count = count+1;
          i = i+2;
        }
        else
        {
            i++;
        }
      }
      return n <= count;
       
        }
    }

