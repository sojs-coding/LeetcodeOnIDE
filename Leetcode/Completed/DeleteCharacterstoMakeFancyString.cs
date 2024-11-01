namespace Leetcode;

public class DeleteCharacterstoMakeFancyString : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        string s;
        string answer;
        string result;
        
        s = "leeetcode";
        answer = "leetcode";
        result = solution.MakeFancyString(s);
        solution.PrintResult(answer, result);
        
        s = "aaabaaaa";
        answer = "aabaa";
        result = solution.MakeFancyString(s);
        solution.PrintResult(answer, result);
        
        s = "aab";
        answer = "aab";
        result = solution.MakeFancyString(s);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution {
        public string MakeFancyString(string s)
        {
            List<char> newString = new List<char>();
            char oldChar = s[0];
            int count = 1;
            newString.Add(oldChar);
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i].Equals(oldChar))
                {
                    count++;
                }
                else
                {
                    oldChar = s[i];
                    count = 1;
                }

                if (count < 3)
                {
                    newString.Add(s[i]);
                }
            }

            return new string(newString.ToArray());
        }
    }
}