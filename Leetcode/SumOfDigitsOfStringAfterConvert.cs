namespace Leetcode;

public class SumOfDigitsOfStringAfterConvert : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        string s = "iiii";
        int k = 1;
        Console.WriteLine(solution.GetLucky(s, k));
        
        s = "leetcode";
        k = 2;
        Console.WriteLine(solution.GetLucky(s, k));
        
        s = "zbax";
        k = 2;
        Console.WriteLine(solution.GetLucky(s, k));

        s = "dbvmfhnttvr";
        k = 5;
        Console.WriteLine(solution.GetLucky(s, k));
    }
    
    public class Solution {
        public int GetLucky(string s, int k)
        {
            char[] charArray = Convert(s);
            for (int i = 0; i < k; i++)
            {
                charArray = Transform(charArray);
            }

            int total = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                total += (charArray[i] - '0') * (int)Math.Pow(10, charArray.Length - i - 1);
            }

            return total;
        }

        char[] Convert(string s)
        {
            char[] alphabets = s.ToCharArray();
            long total = 0;
            List<char> numeric = new List<char>();
            for (int i = 0; i < alphabets.Length; i++)
            {
                int val = alphabets[i] - 'a' + 1;
                char[] valStr = val.ToString().ToCharArray();
                for (int j = 0; j < valStr.Length; j++)
                {
                    numeric.Add(valStr[j]);
                }
            }

            return numeric.ToArray();
        }

        char[] Transform(char[] value)
        {
            int total = 0;
            foreach (char c in value)
            {
                int val = c - '0';
                total += val;
            }

            return total.ToString().ToCharArray();
        }
    }
}