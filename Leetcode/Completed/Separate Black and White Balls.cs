namespace Leetcode;

public class Separate_Black_and_White_Balls : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        string s = "101";
        long result;
        result = solution.MinimumSteps(s);
        Console.WriteLine($"{s} : {result}");
        s = "100";
        result = solution.MinimumSteps(s);
        Console.WriteLine($"{s} : {result}");
        s = "0111";
        result = solution.MinimumSteps(s);
        Console.WriteLine($"{s} : {result}");
    }
    
    public class Solution {
        public long MinimumSteps(string s)
        {
            long numberOfBlackBallsBeforeWhite = 0;
            long totalSwaps = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('1')) // Black ball
                {
                    numberOfBlackBallsBeforeWhite += 1;
                }
                else // White ball
                {
                    totalSwaps += numberOfBlackBallsBeforeWhite;
                }
            }

            return totalSwaps;
        }
    }
}