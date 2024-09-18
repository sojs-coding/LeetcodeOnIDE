namespace Leetcode;

public class CounttheNumberofConsistentStrings : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        string allowed = "ab";
        string[] words = ["ad", "bd", "aaab", "baa", "badab"];
        Console.WriteLine(solution.CountConsistentStrings(allowed, words));
        
        allowed = "abc";
        words = ["a", "b", "c", "ab", "ac", "bc", "abc"];
        Console.WriteLine(solution.CountConsistentStrings(allowed, words));
        
        allowed = "cad";
        words = ["cc", "acd", "b", "ba", "bac", "bad", "ac", "d"];
        Console.WriteLine(solution.CountConsistentStrings(allowed, words));
    }
    
    public class Solution {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            HashSet<char> allowedChar = new HashSet<char>(allowed);
            int total = 0;
            foreach (string str in words)
            {
                bool valid = true;
                foreach (char c in str)
                {
                    if (!allowedChar.Contains(c))
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    total++;
                }
            }

            return total;
        }
    }
}