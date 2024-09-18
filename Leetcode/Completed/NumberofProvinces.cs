namespace Leetcode;

public class NumberofProvinces : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[][] isConnected = [[1, 1, 0], [1, 1, 0], [0, 0, 1]];
        Console.WriteLine(solution.FindCircleNum(isConnected));

        isConnected = [[1, 0, 0], [0, 1, 0], [0, 0, 1]];
        Console.WriteLine(solution.FindCircleNum(isConnected));
    }
    
    public class Solution {
        public int FindCircleNum(int[][] isConnected)
        {
            bool[] visitedNode = new bool[isConnected.Length];
            List<int> neighbours = new List<int>();
            int node = 0;
            int count = 0;
            
            for (int i = 0; i < isConnected.Length; i++)
            {
                if (visitedNode[i]) {continue;}

                count += 1;
                
                neighbours.Add(i);
                
                while (neighbours.Count > 0)
                {
                    node = neighbours[0];
                    neighbours.RemoveAt(0);
                    visitedNode[node] = true;
                    for (int j = 0; j < isConnected[0].Length; j++)
                    {
                        if (isConnected[node][j] == 1 && !visitedNode[j])
                        {
                            neighbours.Add(j);
                        }
                    }
                }
            }

            return count;
        }
    }
}