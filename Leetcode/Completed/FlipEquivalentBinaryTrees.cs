namespace Leetcode;

// https://leetcode.com/problems/flip-equivalent-binary-trees/description/?envType=daily-question&envId=2024-10-24
public class FlipEquivalentBinaryTrees : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int?[]? rootInts1;
        int?[]? rootInts2;
        TreeNode root1;
        TreeNode root2;
        bool result;

        rootInts1 = [1, 2, 3, 4, 5, 6, null, null, null, 7, 8];
        rootInts2 = [1, 3, 2, null, 6, 4, 5, null, null, null, null, 8, 7];
        root1 = TreeNode.GenerateBinaryTree(rootInts1);
        root2 = TreeNode.GenerateBinaryTree(rootInts2);
        result = solution.FlipEquiv(root1, root2);
        if (result)
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }
        
        rootInts1 = [];
        rootInts2 = [];
        root1 = TreeNode.GenerateBinaryTree(rootInts1);
        root2 = TreeNode.GenerateBinaryTree(rootInts2);
        result = solution.FlipEquiv(root1, root2);
        if (result)
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }
        
        rootInts1 = [];
        rootInts2 = [1];
        root1 = TreeNode.GenerateBinaryTree(rootInts1);
        root2 = TreeNode.GenerateBinaryTree(rootInts2);
        result = solution.FlipEquiv(root1, root2);
        if (result)
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }
    
    public class Solution {
        public bool FlipEquiv(TreeNode root1, TreeNode root2) {
            /*
             For root1 to be flip equivalent to root2
             A child of root1 == any child of root2
             
             Solution 1: Sort both trees using the direct child subtree
             If the end result is the same, it is flip equivalent
             O(N)
             This will work because if you sort from bottom up /pre or postfix
             The child nodes will not differ during a swap.
             Since subtrees can only swap under the parent.
             
             Solution 2: No idea.
             */
            if (root1 == root2)
            {
                return true;
            }
            
            if (root1 == null || root2 == null)
            {
                return false;
            }
            SortTree(root1);
            SortTree(root2);

            if (CompareTo(root1, root2) == 0)
            {
                return true;
            }

            return false;
        }

        private void SortTree(TreeNode? node)
        {
            if (node == null)
            {
                return;
            }
            SortTree(node.left);
            SortTree(node.right);
            
            if (node.right == null) // Do nothing
            {
                return;
            }
            if (node.left == null)
            {
                // Replace left with right
                {
                    node.left = node.right;
                    node.right = null;
                }
            }
            else
            {
                if (node.right != null) // Sort left and right
                {
                    if (CompareTo(node.left, node.right) > 0) // Left > Right
                    {
                        (node.left, node.right) = (node.right, node.left);
                    }
                }
            }
        }
        
        public int CompareTo(TreeNode? treeNode, TreeNode? other)
        {
            if (ReferenceEquals(treeNode, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            if (ReferenceEquals(null, treeNode)) return -1;
            var valComparison = treeNode.val.CompareTo(other.val);
            if (valComparison != 0) return valComparison;
            var leftComparison = CompareTo(treeNode.left, other.left);
            if (leftComparison != 0) return leftComparison;
            return CompareTo(treeNode.right, other.right);
        }
    }
}