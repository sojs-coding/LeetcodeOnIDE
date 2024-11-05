namespace Leetcode;

public class MinChanges : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        string s;
        int answer;
        int result;

        s = "1001";
        answer = 2;
        result = solution.MinChanges(s);
        solution.PrintResult(answer, result);
        
        s = "10";
        answer = 1;
        result = solution.MinChanges(s);
        solution.PrintResult(answer, result);
        
        s = "0000";
        answer = 0;
        result = solution.MinChanges(s);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution{
        public int MinChanges(string s)
        {
            char oldChar = s[0];
            int count = 0;
            List<int> order = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (oldChar == s[i])
                {
                    count++;
                }
                else
                {
                    oldChar = s[i];
                    order.Add(count);
                    count = 1;
                }
            }
            
            order.Add(count);

            int odd = 0;
            count = 0;
            for (int i = 0; i < order.Count; i++)
            {
                int isEven = order[i] + odd;
                odd = isEven % 2 == 0 ? 0 : 1;
                if (odd == 1) count++;
            }

            return count;
        }
    }
}