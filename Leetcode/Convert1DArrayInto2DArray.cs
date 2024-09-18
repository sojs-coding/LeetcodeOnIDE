namespace Leetcode;

public class Convert1DArrayInto2DArray : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();

        int[] original = [1, 2, 3, 4];
        int m = 2;
        int n = 2;

        solution.Construct2DArray(original, m, n);
    }
    
    public class Solution {
        public int[][] Construct2DArray(int[] original, int m, int n) {
            if (m * n != original.Length)
            {
                return [];
            }
            
            int[][] twoDimensional = new int[m][];
            int index = 0;
            for (int i = 0; i < m; i++)
            {
                twoDimensional[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    twoDimensional[i][j] = original[index++];
                }
            }

            return twoDimensional;
        }
    }
}