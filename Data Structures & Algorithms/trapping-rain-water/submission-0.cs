public class Solution {
    public int Trap(int[] height) {
        int left=0,right=height.Length-1;
        int maxwater=0;
          int maxL=height[left],maxR=height[right];
        while(left<right){
          
           
        
            if(maxL<maxR)
            {
                left++;
                maxL=Math.Max(maxL,height[left]);
                maxwater +=maxL-height[left];
            }
            else {
                right--;
                maxR=Math.Max(maxR,height[right]);
                maxwater += maxR-height[right];
            }
            
        }
        return maxwater;

    }
}
