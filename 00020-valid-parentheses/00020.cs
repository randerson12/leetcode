public class Solution {
    public bool IsValid(string s) {
        // If the string contains an odd number of characters, the string is invalid because there will be at least one unmatched parenthesis.
        // We can use the modulo operator to determine if the string length is odd.
        if (s.Length % 2 != 0)
        {
            return false;
        }

        // Use a stack to track each parenthesis character.
        var parentheses = new Stack<char>();

        // Use a hash table to track pairs of parentheses.
        // Set the closing parenthesis as the key for easier access when comparing parentheses.
        var parenthesesPairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        // Iterate through each character in the input string s.
        foreach (char c in s)
        {
            // Check if the current character is a closing parenthesis.
            if (parenthesesPairs.ContainsKey(c))
            {
                // Check if the top-most item in the stack is a matching open parenthesis.
                // For example, if c is ')' and the top-most stack item is '('
                if (parentheses.Count > 0 && parentheses.Peek() == parenthesesPairs[c])
                {
                    // If there is a matching open parenthesis in the stack for the current closing parenthesis, remove the opening parenthesis from the stack.
                    parentheses.Pop();
                }
                else
                {
                    // If there is no open parenthesis in the parentheses stack matching the current closing parenthesis, the string is invalid.
                    return false;
                }
            }
            // If the current character is not a closing parenthesis, then it must be an opening parenthesis per the problem constraints.
            else {
                // Any number of opening parentheses are acceptable in the input string, so add this character to the parentheses stack.
                parentheses.Push(c);
            }
        }

        // The string is valid if the parentheses stack is empty.
        // If the stack not empty, it means there is still an opening parenthesis that does not have a matching closing parenthesis.
        return parentheses.Count == 0;
    }
}
