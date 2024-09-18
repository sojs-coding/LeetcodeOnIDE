namespace Leetcode;

public class CountSubIslands : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();

        int[][] grid1 = [[1, 0, 1, 0, 1], [1, 1, 1, 1, 1], [0, 0, 0, 0, 0], [1, 1, 1, 1, 1], [1, 0, 1, 0, 1]];
        int[][] grid2 = [[0, 0, 0, 0, 0], [1, 1, 1, 1, 1], [0, 1, 0, 1, 0], [0, 1, 0, 1, 0], [1, 0, 0, 0, 1]];

        int sol = solution.CountSubIslands(grid1, grid2);
        Console.WriteLine(sol);
    }
    
    public class Solution {
        public int CountSubIslands(int[][] grid1, int[][] grid2) {
            // Generate VisitedIslands grid
            int[][] visitedIslands = new int[grid2.Length][];

            for (int i = 0; i < visitedIslands.Length; i++)
            {
                visitedIslands[i] = new int[grid2[i].Length];
                Array.Copy(grid2[i], visitedIslands[i], grid2[i].Length);
            }

            int numOfIslands = 0;
            for (int i = 0; i < visitedIslands.Length; i++) {
                for (int j = 0; j < visitedIslands[i].Length; j++) {
                    for (int ii = 0; ii < visitedIslands.Length; ii++)
                    {
                        for (int jj = 0; jj < visitedIslands[ii].Length; jj++)
                        {
                            Console.Write(visitedIslands[ii][jj]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine(numOfIslands);
                    Console.WriteLine();
                    if (visitedIslands[i][j] == 1)
                    {
                        numOfIslands += 1;
                    }

                    bool deducted = false;
                    flood(ref grid1, ref visitedIslands, i, j, ref numOfIslands, ref deducted);
                }
            }
            return numOfIslands;
        }

        public void flood(ref int[][] grid1, ref int[][] grid2, int sr, int sc, ref int numOfSubIslands, ref bool deducted) {
            if (sr < 0 || sc < 0 || sr >= grid2.Length || sc >= grid2[sr].Length)
            {
                return;
            }

            if (grid2[sr][sc] == 0) // Water
            {
                return;
            }
            if (grid1[sr][sc] != grid2[sr][sc]) { // Not subisland
                if (!deducted) {
                    numOfSubIslands -= 1;
                    deducted = true;
                }
            }
            
            grid2[sr][sc] = 0;
            
            flood(ref grid1, ref grid2, sr+1, sc, ref numOfSubIslands, ref deducted);
            flood(ref grid1, ref grid2, sr-1, sc, ref numOfSubIslands, ref deducted);
            flood(ref grid1, ref grid2, sr, sc+1, ref numOfSubIslands, ref deducted);
            flood(ref grid1, ref grid2, sr, sc-1, ref numOfSubIslands, ref deducted);
        }
    }
}