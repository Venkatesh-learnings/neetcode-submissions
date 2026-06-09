public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string,List<string>> res=new ();
        foreach(string word in strs)
        {
            int[] count=new int[26];
            foreach(char c in word){
                count[c-'a']++;
            }
            string key=string.Join(",",count);
            
            if(!res.ContainsKey(key)){
                res[key]=new List<string>();
            }
            res[key].Add(word);
        }
      return res.Values.ToList();
    }
}
