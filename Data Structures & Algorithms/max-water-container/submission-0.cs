public class Solution {
    public int MaxArea(int[] heights) {
        int left=0,right=heights.Length-1;
        int maxwater=0;
        while(left<right){
            int minheight=Math.Min(heights[left],heights[right]);
             int water=minheight*(right-left);
             maxwater=Math.Max(maxwater,water);
           if(heights[left]>heights[right]){
            right--;
           }
           else if(heights[left]<heights[right])
           {
            left++;
           }
           else{
            left++;
            right--;
           }

        }
        return maxwater;

    }
}
