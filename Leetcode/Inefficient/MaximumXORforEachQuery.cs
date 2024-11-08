using System.Collections;

namespace Leetcode;

public class MaximumXORforEachQuery : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[] nums;
        int maximumBit;
        int[] result;
        int[] answer;

        nums = [0, 1, 1, 3];
        maximumBit = 2;
        answer = [0, 3, 2, 3];
        result = solution.GetMaximumXor(nums, maximumBit);
        solution.PrintResult(answer, result);

        nums = [2, 3, 4, 7];
        maximumBit = 3;
        answer = [5, 2, 6, 5];
        result = solution.GetMaximumXor(nums, maximumBit);
        solution.PrintResult(answer, result);

        nums = [0, 1, 2, 2, 5, 7];
        maximumBit = 3;
        answer = [4, 3, 6, 4, 6, 7];
        result = solution.GetMaximumXor(nums, maximumBit);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution {
        public int[] GetMaximumXor(int[] nums, int maximumBit)
        {
            List<int> results = new List<int>();

            // 1101111101 Initial XOR
            // If maximumBit = 2, 11b = 3
            BitArray maximumBitArray = new BitArray(maximumBit);
            maximumBitArray.SetAll(true);
            
            // 1101111101 XOR 10 == 1101111111
            // How to find 10? Use 11. 01 XOR 11 == 10
            BitArray mainBitArray = new BitArray(new int[] {nums[0]});
            mainBitArray.Xor(mainBitArray);
            for (int i = 0; i < nums.Length; i++)
            {
                BitArray val = new BitArray(new int[] {nums[i]});
                mainBitArray.Xor(val);
                BitArray answer = GetAnswer(mainBitArray, maximumBitArray);
                results.Add(GetIntFromBitArray(answer));
            }

            results.Reverse();
            return results.ToArray();
        }

        private BitArray GetAnswer(BitArray value, BitArray maximumBitArray)
        {
            int len = maximumBitArray.Length;
            BitArray mask = new BitArray(len);
            for (int i = 0; i < len; i++)
            {
                mask.Set(i, value.Get(i));
            }
            
            return mask.Xor(maximumBitArray);
        }
        
        private int GetIntFromBitArray(BitArray bitArray)
        {

            if (bitArray.Length > 32)
                throw new ArgumentException("Argument length shall be at most 32 bits.");

            int[] array = new int[1];
            bitArray.CopyTo(array, 0);
            return array[0];

        }
    }
}