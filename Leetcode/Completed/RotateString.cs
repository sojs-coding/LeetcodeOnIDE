namespace Leetcode;

public class RotateString : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        string s;
        string goal;
        bool result;
        bool answer;

        s = "abcde";
        goal = "cdeab";
        answer = true;
        result = solution.RotateString(s, goal);
        solution.PrintResult(answer, result);
        
        s = "abcde";
        goal = "abced";
        answer = false;
        result = solution.RotateString(s, goal);
        solution.PrintResult(answer, result);
        
        s = "cccdd";
        goal = "ccddc";
        answer = true;
        result = solution.RotateString(s, goal);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution {
        public bool RotateString(string s, string goal)
        {
            if (s.Length != goal.Length) return false;
            return (s + s).Contains(goal);
        }
    }
}