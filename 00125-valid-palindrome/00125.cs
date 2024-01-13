public class Solution {
    public bool IsPalindrome(string s) {
        // Create pointers at the start and end of the character array.
        int leftPointer = 0;
        int rightPointer = s.Length - 1;

        // Continue moving the pointers until they meet in the middle.
        while (leftPointer < rightPointer)
        {
            // If characters at each pointer location aren't valid characters, adjust the corresponding pointer.
            // When a pointer is adjusted, restart the comparison.
            // If both pointers point to alphanumeric characters, then check if they are equal.
            // As long as both characters are equal, continue the comparison.
            if (!char.IsLetterOrDigit(s[leftPointer]))
            {
                leftPointer++;
            }
            else if (!char.IsLetterOrDigit(s[rightPointer]))
            {
                rightPointer--;
            }
            else if (char.ToLower(s[leftPointer++]) != char.ToLower(s[rightPointer--]))
            {
                return false;
            }
        }

        // If all comparisons are compete and all character pairs match, s is a palindrome.
        return true;
    }
}
