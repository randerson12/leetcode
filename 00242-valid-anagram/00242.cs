public class Solution {
    public bool IsAnagram(string s, string t) {
        // It is impossible for the strings to be anagrams if they are not of equal length.
        if (s.Length != t.Length)
        {
            return false;
        }

        // Create character arrays to represent each string s and t
        char[] sChars = s.ToArray();
        char[] tChars = t.ToArray();

        // Sort each character array
        Array.Sort(sChars);
        Array.Sort(tChars);

        // If each sorted character array is equal, the strings are anagrams.
        return sChars.SequenceEqual(tChars);
    }
}
