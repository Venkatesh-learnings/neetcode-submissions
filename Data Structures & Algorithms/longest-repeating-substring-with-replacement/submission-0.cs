public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left=0,right=0;
        int maxLength=0;int maxFrequency=0;
        int[] charCount=new int[26];
        for(;right<s.Length;right++)
        {
            charCount[s[right] - 'A']++;
            maxFrequency=Math.Max(maxFrequency, charCount[s[right] - 'A']);
            
            if((right-left+1)-maxFrequency>k){
                charCount[s[left] - 'A']--;
                left++;
            }
            maxLength=Math.Max(maxLength,right-left+1);
        }
        return maxLength;
    }
}
