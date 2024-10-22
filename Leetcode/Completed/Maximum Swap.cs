namespace Leetcode;

public class Maximum_Swap : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int num;
        int result;

        num = 2736;
        result = solution.MaximumSwap(num);
        Console.WriteLine($"{num} : {result}");
        num = 9973;
        result = solution.MaximumSwap(num);
        Console.WriteLine($"{num} : {result}");
        num = 1;
        result = solution.MaximumSwap(num);
        Console.WriteLine($"{num} : {result}");
        num = 12;
        result = solution.MaximumSwap(num);
        Console.WriteLine($"{num} : {result}");
        num = 100;
        result = solution.MaximumSwap(num);
        Console.WriteLine($"{num} : {result}");
    }
    
    public class Solution {
        public int MaximumSwap(int num)
        {
            string numStr = num.ToString();

            if (numStr.Length <= 1)
            {
                return num;
            }
            
            Dictionary<char, List<int>> intIndexes = new Dictionary<char, List<int>>();
            char[] intToChar = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
            
            // Most obvious case. LHS < RHS
            // 2nd issue. LHS < RHS but RHSi > RHSi+j, where i is iterator on left and j is iterator on right
            /*
             Create a list for the index of each number. From LHS to RHS 
             Use it to check if current number is the largest. If n > 9
             If 3 > 6? No. Check if 6 has anything. If yes, get the smallest index and swap.
             If 6 > 3? Yes. Go to the next number.
             */

            for (int i = 0; i <= 9; i++)
            {
                intIndexes[intToChar[i]] = new List<int>();
            }
            
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                intIndexes[numStr[i]].Add(i);
            }

            for (int i = 0; i < numStr.Length; i++)
            {
                for (int j = 9; j >= 0; j--)
                {
                    if (numStr[i] > intToChar[j])
                    {
                        // If numStr[i] > intToChar[j]? Yes. Go to the next number.
                    }
                    else
                    {
                        // If numStr[i] > intToChar[j]? No. Check if intToChar[j] has anything. If yes, get the smallest index and swap.
                        if (intIndexes[intToChar[j]].Count > 0)
                        {
                            int largestValueIndex = intIndexes[intToChar[j]][0];
                            char largestValue = numStr[largestValueIndex];
                            int currentValueIndex = i;
                            char currentValue = numStr[i];
                            string first = numStr.Substring(0, currentValueIndex);
                            string second = "";
                            if (numStr.Length > 3)
                            {
                                second = largestValue + numStr.Substring(currentValueIndex + 1,
                                    largestValueIndex -
                                    (currentValueIndex + 1));
                            }

                            string third = currentValue + numStr.Substring(largestValueIndex + 1, numStr.Length - largestValueIndex - 1);
                            string result = first + second + third;
                            int resultInt;
                            if (int.TryParse(result, out resultInt))
                            {
                                return resultInt;
                            }
                            
                        }
                    }
                }
            }

            return num;
        }
    }
}