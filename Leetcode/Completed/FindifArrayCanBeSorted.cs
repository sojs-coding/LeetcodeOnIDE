using System.Collections;

namespace Leetcode;

public class FindifArrayCanBeSorted : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[] nums;
        bool answer;
        bool result;

        nums = [8, 4, 2, 30, 15];
        answer = true;
        result = solution.CanSortArray(nums);
        solution.PrintResult(answer, result);
        
        nums = [1, 2, 3, 4, 5];
        answer = true;
        result = solution.CanSortArray(nums);
        solution.PrintResult(answer, result);

        nums = [3, 16, 8, 4, 2];
        answer = false;
        result = solution.CanSortArray(nums);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution {
        public bool CanSortArray(int[] nums)
        {
            List<List<int>> listOfLists = new List<List<int>>();
            List<int> listOfNums = new List<int>();
            BitArray bitArray = new BitArray(new int[] { nums[0] });
            uint count = 0;
            for (int j = 0; j < bitArray.Length; j++)
            {
                count += bitArray.Get(j) ? 1u : 0u;
            }

            uint oldCount = count;
            
            for (int i = 0; i < nums.Length; i++)
            {
                // Get the setbits of a number
                count = 0;
                bitArray = new BitArray(new int[] { nums[i] });
                for (int j = 0; j < bitArray.Length; j++)
                {
                    count += bitArray.Get(j) ? 1u : 0u;
                }

                if (count.Equals(oldCount)) // Adjacent and same number of setbits
                {
                    listOfNums.Add(nums[i]);
                }
                else
                {
                    listOfLists.Add(listOfNums);
                    listOfNums = new List<int>();
                    listOfNums.Add(nums[i]);
                    oldCount = count;
                }
            }
            
            listOfLists.Add(listOfNums);

            int oldInt = 0;
            
            foreach (List<int> list in listOfLists)
            {
                list.Sort();
                if (oldInt > list[0])
                {
                    return false;
                }

                oldInt = list.Last();
            }

            return true;
        }
    }
}