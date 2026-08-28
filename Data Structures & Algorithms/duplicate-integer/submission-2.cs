public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> duplicateSet=new  HashSet<int>();
        foreach(int num in nums){
            if(duplicateSet.Contains(num))
                return true;
            duplicateSet.Add(num);
        }  
        return false; 
    }
}