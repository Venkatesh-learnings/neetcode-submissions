public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
      Dictionary<int,int> res=new Dictionary<int,int>();
      List<int>[] freq=new List<int>[nums.Length + 1];

      for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }
      foreach(int num in nums)
        res[num]=res.GetValueOrDefault(num,0)+1;
     
      foreach(var entry in res)
      {
       
        freq[entry.Value].Add(entry.Key);}
      
      int[] result=new int[k];
      int index=0;

      for(int i=freq.Length-1;i>0&& index<k;i--){
        foreach(int n in freq[i])
          {
            result[index++]=n;
            if(index==k)
             return result;
          }

      }
      return new int[]{};
    }
}
