namespace Leetcode;

public class KthLargestSumInABinaryTree : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int?[] rootInts;
        int k;
        long result = 0;
        rootInts = [5, 8, 9, 2, 1, 3, 7, 4, 6];
        k = 2;
        TreeNode root = TreeNode.GenerateBinaryTree(rootInts);
        result = solution.KthLargestLevelSum(root, k);
        Console.WriteLine(result);
        rootInts = [1, 2, null, 3];
        k = 1;
        root = TreeNode.GenerateBinaryTree(rootInts);
        result = solution.KthLargestLevelSum(root, k);
        Console.WriteLine(result);
    }
    
    public class Solution {
        public long KthLargestLevelSum(TreeNode root, int k)
        {
            Dictionary<int, long> sumOfLevels = new Dictionary<int, long>();

            TraverseTree(ref sumOfLevels, root, 0);
            if (k > sumOfLevels.Count)
            {
                return -1;
            }

            List<long> rankedSumOfLevels = sumOfLevels.Values.ToList();
            rankedSumOfLevels.Sort();
            rankedSumOfLevels.Reverse();
            return rankedSumOfLevels[k-1];
        }

        public void TraverseTree(ref Dictionary<int, long> sumOfLevels, TreeNode? node, int level)
        {
            if (node == null)
            {
                return;
            }
            TraverseTree(ref sumOfLevels, node.left, level + 1);
            TraverseTree(ref sumOfLevels, node.right, level + 1);
            if (sumOfLevels.ContainsKey(level))
            {
                sumOfLevels[level] += node.val;
            }
            else
            {
                sumOfLevels[level] = node.val;
            }
        }
    }
}