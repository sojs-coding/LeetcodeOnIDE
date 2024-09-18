namespace Leetcode;

public class MinimumBitFlipstoConvertNumber : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int start = 10;
        int goal = 7;
        Console.WriteLine(solution.MinBitFlips(start, goal));
        
        start = 3;
        goal = 4;
        Console.WriteLine(solution.MinBitFlips(start, goal));
    }
    
    public class Solution {
        public int MinBitFlips(int start, int goal)
        {
            int total = 0;
            int binary = start ^ goal;
            string binaryStr = Convert.ToString(binary, 2);
            foreach (char c in binaryStr)
            {
                if (c.Equals('1'))
                {
                    total++;
                }
            }

            return total;
        }
    }
}