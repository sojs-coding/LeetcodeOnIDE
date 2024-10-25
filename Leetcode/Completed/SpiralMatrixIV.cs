namespace Leetcode;

public class SpiralMatrixIV : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int m = 3;
        int n = 5;
        int[] headInts = [3, 0, 2, 6, 8, 1, 7, 9, 4, 2, 5, 5, 0];
        ListNode<int> head = ListNode<int>.GenerateLinkedList(headInts);
        foreach (int[] arr in solution.SpiralMatrix(m, n, head))
        {
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }
    }
    
    public class Solution {
        public int[][] SpiralMatrix(int m, int n, ListNode<int> head)
        {
            int[][] matrix = new int[m][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[n];
            }
            int top = 0;
            int bottom = m-1;
            int left = 0;
            int right = n-1;
            int direction = 0; // 0 - Right, 1 - Down, 2 - Left, 3 - Up

            int x = -1;
            int y = 0;
            
            while (top <= bottom && left <= right)
            {
                switch (direction)
                {
                    case 0:
                        x += 1;
                        if (x == right)
                        {
                            direction = 1;
                            top += 1;
                        }
                        break;
                    
                    case 1:
                        y += 1;
                        if (y == bottom)
                        {
                            direction = 2;
                            right -= 1;
                        }
                        break;
                    
                    case 2:
                        x -= 1;
                        if (x == left)
                        {
                            direction = 3;
                            bottom -= 1;
                        }
                        break;
                    
                    case 3:
                        y -= 1;
                        if (y == top)
                        {
                            direction = 0;
                            left += 1;
                        }
                        break;
                }
                if (head != null)
                {
                    matrix[y][x] = head.val;
                    head = head.next;    
                }
                else
                {
                    matrix[y][x] = -1;
                }
            }

            return matrix;
        }
    }
}