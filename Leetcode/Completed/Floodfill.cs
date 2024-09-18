namespace Leetcode;

public class Floodfill : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();

        int[][] image = [[1, 1, 1], [1, 1, 0], [1, 0, 1]];
        int sr = 1;
        int sc = 1;
        int color = 2;

        int[][] sol = solution.FloodFill(image, sr, sc, color);
        for (int i = 0; i < sol.Length; i++)
        {
            for (int j = 0; j < sol[0].Length; j++)
            {
                Console.Write(sol[i][j]);
            }
            Console.WriteLine();
        }
    }
    
    public class Solution {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
            int[][] newImage = new int[image.Length][];

            for (int i = 0; i < newImage.Length; i++)
            {
                newImage[i] = new int[image[i].Length];
                Array.Copy(image[i], newImage[i], image[i].Length);
            }
            int oldColor = newImage[sr][sc];

            if (oldColor != color) {
                flood(ref newImage, sr, sc, color, oldColor);
            }
            return newImage;
        }

        public void flood(ref int[][] image, int sr, int sc, int color, int oldColor) {
            if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[sr].Length)
            {
                return;
            }

            if (image[sr][sc] != oldColor)
            {
                return;
            }
            
            image[sr][sc] = color;
            
            flood(ref image, sr+1, sc, color, oldColor);
            flood(ref image, sr-1, sc, color, oldColor);
            flood(ref image, sr, sc+1, color, oldColor);
            flood(ref image, sr, sc-1, color, oldColor);
        }
    }
}