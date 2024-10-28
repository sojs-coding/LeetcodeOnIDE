namespace Leetcode;

public class CountSquareSubmatriceswithAllOnes : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[][] matrix;
        int answer;
        int result;
        
        matrix =
        [
            [0, 1, 1, 1],
            [1, 1, 1, 1],
            [0, 1, 1, 1]
        ];
        answer = 15;
        result = solution.CountSquares(matrix);
        solution.PrintResult(answer, result);

        matrix =
        [
            [1, 0, 1],
            [1, 1, 0],
            [1, 1, 0]
        ];
        answer = 7;
        result = solution.CountSquares(matrix);
        solution.PrintResult(answer, result);
        
    }
    
    public class Solution : LeetcodeSolution {
        public int CountSquares(int[][] matrix) {
            /*
             0 1 1 1
             0 0 1 1
             0 0 1 1
             Squares increase in size 
             */

            int numberOfSquares = 0;

            List<(int, int)> corners = new List<(int, int)>();
            for (int y = 0; y < matrix.Length; y++)
            {
                for (int x = 0; x < matrix[0].Length; x++)
                {
                    numberOfSquares += matrix[y][x];
                    if (CheckSquare(matrix, x, y, 1))
                    {
                        corners.Add((x, y));
                    }
                }
            }

            int size = 0;
            while (corners.Count > 0)
            {
                size += 1;
                for (int j = 0; j < corners.Count; j++)
                {
                    if (CheckSquare(matrix, corners[0].Item1, corners[0].Item2, size))
                    {
                        numberOfSquares += 1;
                        matrix[corners[0].Item2][corners[0].Item1] = size + 1;
                        corners.Add((corners[0].Item1, corners[0].Item2));
                    }

                    corners.RemoveAt(0);
                }
            }

            return numberOfSquares;
        }

        private bool CheckSquare(int[][] matrix, int x, int y, int val)
        {
            try
            {
                if (matrix[y][x] != val) return false;
                if (matrix[y + 1][x] != val) return false;
                if (matrix[y][x + 1] != val) return false;
                if (matrix[y + 1][x + 1] != val) return false;
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }
            return true;
        }
    }
}