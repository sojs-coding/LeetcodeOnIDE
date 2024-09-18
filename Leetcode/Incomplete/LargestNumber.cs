using System.Text;

namespace Leetcode;

public class LargestNumber : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[] nums = [10, 2];
        Console.WriteLine(solution.LargestNumber(nums));
        nums = [3, 30, 34, 5, 9];
        Console.WriteLine(solution.LargestNumber(nums));
        nums = [34323, 3432];
        Console.WriteLine(solution.LargestNumber(nums));

    }
    
    // Leetcode solutions are ... interesting. 
    
    public class Solution {
        class CustomStringComparer : IComparer<String>
        {
            public int Compare(string? x, string? y)
            {
                int shortest = Math.Min(x.Length, y.Length);
                for (int i = 0; i < shortest; i++)
                {
                    if (x[i] > y[i])
                    {
                        return -1;
                    } else if (x[i] < y[i])
                    {
                        return 1;
                    }
                }
                if (y.Length > x.Length)
                { // Check start
                    if (y[shortest] > x[0])
                    {
                        return -1;
                    }
                    else if (y[shortest] < x[0])
                    {
                        return 1;
                    }
                    else // Check end
                    {
                        if (y[y.Length - 1] < x[shortest - 1])
                        {
                            return -1;
                        }
                        else if (y[y.Length - 1] > x[shortest - 1])
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                else if (x.Length > y.Length)
                { // Check start
                    if (x[shortest] > y[0])
                    {
                        return -1;
                    }
                    else if (x[shortest] < y[0])
                    {
                        return 1;
                    }
                    else // Check end
                    {
                        if (x[x.Length - 1] < y[shortest - 1])
                        {
                            return -1;
                        }
                        else if (x[x.Length - 1] > y[shortest - 1])
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return 0;
            }
        }
        
        public string LargestNumber(int[] nums)
        {
            string[] stringArray = new string[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                stringArray[i] = nums[i].ToString();
            }
            Array.Sort(stringArray, new CustomStringComparer());
            // Array.Reverse(stringArray);

            return String.Join("", stringArray);
        }
    }
}