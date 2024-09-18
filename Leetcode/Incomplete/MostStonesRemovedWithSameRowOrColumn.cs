namespace Leetcode;

public class MostStonesRemovedWithSameRowOrColumn : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[][] stones = [[0, 0], [0, 1], [1, 0], [1, 2], [2, 1], [2, 2]];
        int sol = solution.RemoveStones(stones);
        Console.WriteLine(sol);
        stones = [[0, 0], [0, 2], [1, 1], [2, 0], [2, 2]];
        sol = solution.RemoveStones(stones);
        Console.WriteLine(sol);
    }
    
    public class Solution {
        public int RemoveStones(int[][] stones)
        {
            Dictionary<int, List<int>> gridX = new Dictionary<int, List<int>>();
            Dictionary<int, List<int>> gridY = new Dictionary<int, List<int>>();

            for (int i = 0; i < stones.Length; i++)
            {
                if (!gridX.ContainsKey(stones[i][0]))
                {
                    gridX[stones[i][0]] = new List<int>();

                }
                else
                {
                    gridX[stones[i][0]].Add(stones[i][1]);
                }
                
                if (!gridY.ContainsKey(stones[i][1]))
                {
                    gridY[stones[i][1]] = new List<int>();
                }
                else
                {
                    gridY[stones[i][1]].Add(stones[i][0]);
                }
            }

            return 0;
        }
    }
}