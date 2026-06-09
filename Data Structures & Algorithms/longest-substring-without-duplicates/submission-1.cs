public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> duplicates=new();
        int left=0;int maxLength=0;

        for(int right=0;right<s.Length;right++){
            while(duplicates.Contains(s[right])){
                duplicates.Remove(s[left]);
                left++;
            }
            duplicates.Add(s[right]);
            maxLength=Math.Max(maxLength,right-left+1);
        }
        return maxLength;
    }
}
