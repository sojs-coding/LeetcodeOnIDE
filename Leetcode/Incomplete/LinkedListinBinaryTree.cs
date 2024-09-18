using System.ComponentModel;

namespace Leetcode;

public class LinkedListinBinaryTree : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        
        int[] headInts = [4, 2, 8];
        int?[] rootInts = [1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3];
        TreeNode root = TreeNode.GenerateBinaryTree(rootInts);
        ListNode head = ListNode.GenerateLinkedList(headInts);
        
        Console.WriteLine(solution.IsSubPath(head, root));

        headInts = [1, 4, 2, 6];
        rootInts = [1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3];
        root = TreeNode.GenerateBinaryTree(rootInts);
        head = ListNode.GenerateLinkedList(headInts);

        Console.WriteLine(solution.IsSubPath(head, root));

        headInts = [1, 4, 2, 6, 8];
        rootInts = [1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3];
        root = TreeNode.GenerateBinaryTree(rootInts);
        head = ListNode.GenerateLinkedList(headInts);
             
        Console.WriteLine(solution.IsSubPath(head, root));
        
        headInts = [1,10];
        rootInts = [1,null,1,10,1,9];
        root = TreeNode.GenerateBinaryTree(rootInts);
        head = ListNode.GenerateLinkedList(headInts);
        Console.WriteLine(solution.IsSubPath(head, root));
        
        headInts = [2, 2, 1];
        rootInts = [2,null,2,null,2,null,1];
        root = TreeNode.GenerateBinaryTree(rootInts);
        head = ListNode.GenerateLinkedList(headInts);
        Console.WriteLine(solution.IsSubPath(head, root));
    }



    
    
    

     public class Solution {
        public bool IsSubPath(ListNode head, TreeNode root)
        {
            List<int> headList = new List<int>();
            while (head != null)
            {
                headList.Add(head.val);
                head = head.next;
            }
            
            return dfs(root, headList, new List<int>());
        }

        public bool dfs(TreeNode? node, List<int> head, List<int> window)
        {
            if (node == null)
            {
                return false;
            }

            if (node.val == head[window.Count])
            {
                window.Add(node.val);
                if (head.Count == window.Count)
                {
                    return true;
                }
            }
            else
            {
                foreach (var i in window)
                {
                    if (i != window.Last())
                    {
                        window.Clear();
                        break;
                    }
                }
            }

            if (dfs(node.left, head, new List<int>(window)) || dfs(node.right, head, new List<int>(window)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     }
}