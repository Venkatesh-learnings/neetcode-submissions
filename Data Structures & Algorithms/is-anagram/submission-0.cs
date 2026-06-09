
public class Solution {
    public bool IsAnagram(string s, string t) {
    if (s.Length != t.Length) return false;
    Dictionary<char, int> freq = new();
    foreach (char c in s.ToLower()) freq[c] = freq.GetValueOrDefault(c, 0) + 1;
    foreach (char c in t.ToLower()) {
        freq[c] = freq.GetValueOrDefault(c, 0) - 1;
        if (freq[c] < 0) return false;
    }
    return freq.Values.All(v => v == 0);  // Or iterate keys
}
}
