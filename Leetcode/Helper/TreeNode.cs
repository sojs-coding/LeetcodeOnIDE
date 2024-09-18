namespace Leetcode;

// Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    
    public static TreeNode GenerateBinaryTree(int?[] rootInts)
    {
        TreeNode root = new TreeNode((int)rootInts[0]);
        List<TreeNode> treeQueue = new List<TreeNode>();
        treeQueue.Add(root);
        int index = 1;
        
        while (treeQueue.Count > 0)
        {
            if (index >= rootInts.Length)
            {
                break;
            }
            TreeNode node = treeQueue[0];
            treeQueue.RemoveAt(0);
            if (rootInts[index] != null)
            {
                TreeNode newNode = new TreeNode((int)rootInts[index]);
                node.left = newNode;
                treeQueue.Add(newNode);
            }

            if (index + 1 < rootInts.Length)
            {
                if (rootInts[index + 1] != null)
                {
                    TreeNode newNode = new TreeNode((int)rootInts[index + 1]);
                    node.right = newNode;
                    treeQueue.Add(newNode);
                }
            }

            index += 2;
        }

        return root;
    }
}