using System.Collections;

namespace Leetcode;

public class LargestCombinationWithBitwiseAndGreaterThanZero : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[] candidates;
        int result;
        int answer;

        candidates = [16, 17, 71, 62, 12, 24, 14];
        answer = 4;
        result = solution.LargestCombination(candidates);
        solution.PrintResult(answer, result);
        
        candidates = [8, 8];
        answer = 2;
        result = solution.LargestCombination(candidates);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution{
        public int LargestCombination(int[] candidates)
        {
            List<int> count = new List<int>();
            
            foreach (int candidate in candidates)
            {
                BitArray bitArray = new BitArray(new int[] { candidate });
                for (int i = 0; i < bitArray.Length; i++)
                {
                    if (bitArray.Get(i))
                    {
                        if (i < count.Count)
                        {
                            count[i] += 1;
                        }
                        else
                        {
                            count.Add(1);
                        }
                    }
                    else
                    {
                        if (i >= count.Count)
                        {
                            count.Add(0);
                        }
                    }
                }
            }

            return count.Max();
        }
    }
}