using System.Collections;

namespace Leetcode;

// https://leetcode.com/problems/minimum-array-end/description/?envType=daily-question&envId=2024-11-09
public class MinimumArrayEnd : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int n, x;
        long answer, result;

        n = 3;
        x = 4;
        answer = 6;
        result = solution.MinEnd(n, x);
        solution.PrintResult(answer, result);
        
        n = 2;
        x = 7;
        answer = 15;
        result = solution.MinEnd(n, x);
        solution.PrintResult(answer, result);
        
        n = 6715154;
        x = 7193485;
        answer = 15;
        result = solution.MinEnd(n, x);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution{
        public long MinEnd(int n, int x)
        {
            long answer = x;
            int tempN = n;
            int tempX = x;

            while (tempN > 0)
            {
                var b = tempN << 1;
                Console.WriteLine(b.GetType());
                Console.WriteLine($"Shifted byte: {Convert.ToString(b, toBase: 2)}");
            }

            return answer;
        }
    }
}