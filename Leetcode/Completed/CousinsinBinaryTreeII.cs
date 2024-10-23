namespace Leetcode;

public class CousinsinBinaryTreeII : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int?[]? rootInts;
        TreeNode? root;
        TreeNode? result;
        int?[]? answerInts;
        TreeNode? answer;
        
        rootInts = [5, 4, 9, 1, 10, null, 7];
        answerInts = [0, 0, 0, 7, 7, null, 11];
        root = TreeNode.GenerateBinaryTree(rootInts);
        answer = TreeNode.GenerateBinaryTree(answerInts);
        result = solution.ReplaceValueInTree(root);
        PrintResult(answer, result);

        rootInts = [3, 1, 2];
        answerInts = [0, 0, 0];
        root = TreeNode.GenerateBinaryTree(rootInts);
        result = solution.ReplaceValueInTree(root);
        answer = TreeNode.GenerateBinaryTree(answerInts);
        PrintResult(answer, result);
    }
    
    private void PrintResult(TreeNode answer, TreeNode result)
    {
        if (answer.CompareTo(result) == 0 ? true : false)
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }
    
    public class Solution {
        // Sum all the nodes in each level
        // Store the sum in a dictionary for each level
        // Traverse through the tree again
        // Minus the child nodes to get the new value
        public TreeNode ReplaceValueInTree(TreeNode root)
        {
            Dictionary<int, int> sumOfLevelsDictionary = new Dictionary<int, int>();
            TraverseTreeToSumNodesInEachLevel(ref sumOfLevelsDictionary, root, 0);
            TraverseTreeToSetSumOfCousins(ref sumOfLevelsDictionary, root, 0);
            root.val = 0;
            return root;
        }

        private void TraverseTreeToSumNodesInEachLevel(ref Dictionary<int, int> sumOfLevelsDictionary, TreeNode? node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (sumOfLevelsDictionary.ContainsKey(level))
            {
                sumOfLevelsDictionary[level] += node.val;
            }
            else
            {
                sumOfLevelsDictionary[level] = node.val;
            }
            
            TraverseTreeToSumNodesInEachLevel(ref sumOfLevelsDictionary, node.left, level + 1);
            TraverseTreeToSumNodesInEachLevel(ref sumOfLevelsDictionary, node.right, level + 1);
        }

        private TreeNode? TraverseTreeToSetSumOfCousins(ref Dictionary<int, int> sumOfLevelsDictionary, TreeNode? node,
            int level)
        {
            if (node == null)
            {
                return null;
            }

            int sumOfChildren = 0;
            TreeNode? leftChild = TraverseTreeToSetSumOfCousins(ref sumOfLevelsDictionary, node.left, level + 1);
            if (leftChild != null)
            {
                sumOfChildren += leftChild.val;
            }

            TreeNode? rightChild = TraverseTreeToSetSumOfCousins(ref sumOfLevelsDictionary, node.right, level + 1);
            if (rightChild != null)
            {
                sumOfChildren += rightChild.val;
            }

            if (leftChild != null)
            {
                leftChild.val = sumOfLevelsDictionary[level + 1] - sumOfChildren;
            }
            if (rightChild != null)
            {
                rightChild.val = sumOfLevelsDictionary[level + 1] - sumOfChildren;
            }

            return node;
        }
    }
}