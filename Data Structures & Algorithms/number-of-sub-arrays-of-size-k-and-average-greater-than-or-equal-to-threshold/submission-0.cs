public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
      int count=0;
      threshold*=k;
      int curSum=0;
      for(int r=0;r<arr.Length;r++)
      {
         curSum+=arr[r];
        if(r >=k-1){
            if(curSum>=threshold)
                 count+=1;
             curSum-=arr[r-k+1];
        }
       
       
      } 
      return count; 
    }
}