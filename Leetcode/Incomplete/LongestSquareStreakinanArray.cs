namespace Leetcode;

public class LongestSquareStreakinanArray : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[] nums;
        int result;
        int answer;

        nums = [4, 3, 6, 16, 8, 2];
        answer = 3;
        result = solution.LongestSquareStreak(nums);
        solution.PrintResult(answer, result);

        nums = [2, 3, 5, 6, 7];
        answer = -1;
        result = solution.LongestSquareStreak(nums);
        solution.PrintResult(answer, result);

        nums = [2, 4, 4, 2];
        answer = 2;
        result = solution.LongestSquareStreak(nums);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution{
        public int LongestSquareStreak(int[] nums)
        {
            Array.Sort(nums);
            int[] allNums = new int[100001];
            for (int i = 0; i < nums.Length; i++)
            {
                allNums[nums[i]] = 1;
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                int val = nums[i] * nums[i];
                if (val > 100000) continue; // Exceed array
                if (allNums[val] == 1)
                {
                    allNums[val] += allNums[nums[i]];
                }
            }

            int result = allNums.Max();
            return result > 1 ? result : -1 ;
        }
    }
}