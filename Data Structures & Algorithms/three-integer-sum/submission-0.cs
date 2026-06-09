public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result=new();
        for(int L=0;L<nums.Length-2;L++)
        {
            if(nums[L]>0) 
             break;
            if(L>0 && nums[L]==nums[L-1]){
               continue;
            }
         
            TwoPairSum(nums,-nums[L],L+1,result);
        }
        return result;
    }
    public void TwoPairSum(int[] input,int target,int left, List<List<int>> result){
        int right=input.Length-1;
        int startLeft = left;
        while(left<right){
            if(left > startLeft && input[left] == input[left-1])
            {
                left++;
                continue;
            }
            int currentSum= input[left]+input[right];
            if(currentSum<target)
                left++;
            else if(currentSum>target){
                right--;
            }
            else {
              result.Add(new List<int>(){ -target, input[left], input[right] });
              left++;
              right--;
            }
        }
    }
}