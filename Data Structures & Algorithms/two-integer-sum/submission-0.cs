public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int index=0;
        Dictionary<int,int> complemantryDt=new();
        foreach(int num in nums){
            
            if(complemantryDt.ContainsKey(target-num))
            {
                 return new int[]{complemantryDt[target-num],index};
               
            }
            else
            {
                complemantryDt.Add(num,index);
                index++;
            }
        }
        return new int[]{};

    }
}
