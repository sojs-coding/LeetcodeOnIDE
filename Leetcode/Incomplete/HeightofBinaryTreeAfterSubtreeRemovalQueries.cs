namespace Leetcode;

// https://leetcode.com/problems/height-of-binary-tree-after-subtree-removal-queries/description/?envType=daily-question&envId=2024-10-26
public class HeightofBinaryTreeAfterSubtreeRemovalQueries : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int?[]? rootInts;
        TreeNode? root;
        int[] queries;
        int[] result;
        int[] answer;

        rootInts = [1, 3, 4, 2, null, 6, 5, null, null, null, null, null, 7];
        queries = [4];
        answer = [2];
        root = TreeNode.GenerateBinaryTree(rootInts);
        result = solution.TreeQueries(root, queries);
        solution.PrintResult(answer, result);

        rootInts = [5, 8, 9, 2, 1, 3, 7, 4, 6];
        queries = [3, 2, 4, 8];
        answer = [3, 2, 3, 2];
        root = TreeNode.GenerateBinaryTree(rootInts);
        result = solution.TreeQueries(root, queries);
        solution.PrintResult(answer, result);

        rootInts = [1, null, 5, 3, null, 2, 4];
        queries = [3, 5, 4, 2, 4];
        answer = [1, 0, 3, 3, 3];
        root = TreeNode.GenerateBinaryTree(rootInts);
        result = solution.TreeQueries(root, queries);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution {
        public int[] TreeQueries(TreeNode root, int[] queries) {
            /*
             Find the height of the tree after removing a node
             Calculate the height of the tree at every node
             During removal, find parent of the current node
             Check parent's height. 
             
             If height == removed Node height + 1,
             Set height of parent to height of existing child || 1
             Traverse to root.
             If height != removed Node height + 1, return root height.
             */
            Dictionary<int, TreeNode?> parents = new Dictionary<int, TreeNode?>();
            Dictionary<int, int> heights = new Dictionary<int, int>();
            Dictionary<int, int> memo = new Dictionary<int, int>();

            GenerateHeights(ref parents, ref heights, root, null);
            GenerateMemo(ref memo, ref parents, ref heights, root);
            

            List<int> results = new List<int>();
            foreach (var query in queries)
            {
                int height = Query(ref memo, query);
                if (height == -1)
                {
                    results.Add(heights[root.val]);
                }
                else
                {
                    results.Add(height);
                }
            }

            return results.ToArray();
        }
        
        // Dictionary keys = unique id
        // Parents dictionary store the parent node of the current node
        // Heights dictionary store the height of the nodes
        private int GenerateHeights(ref Dictionary<int, TreeNode?> parents, ref Dictionary<int, int> heights, TreeNode? node, TreeNode? parent)
        {
            if (node == null)
            {
                return -1;
            }

            parents[node.val] = parent;

            var leftNodeHeight = GenerateHeights(ref parents, ref heights, node.left, node);
            var rightNodeHeight = GenerateHeights(ref parents, ref heights, node.right, node);
            
            heights[node.val] = int.Max(leftNodeHeight, rightNodeHeight) + 1; // Set height for this node
            
            return heights[node.val];
        }
        
        private void GenerateMemo(ref Dictionary<int, int> memo, ref Dictionary<int, TreeNode?> parents, ref Dictionary<int, int> heights, TreeNode? node)
        {
            if (node == null)
            {
                return;
            }

            // Add current node to the list of elements of the longest subtree 
            TreeNode? leftChild = node.left;
            int leftHeight = leftChild == null ? -1 : heights[leftChild.val];
            TreeNode? rightChild = node.right;
            int rightHeight = rightChild == null ? -1 : heights[rightChild.val];

            // Find the largest height
            if (leftHeight >= rightHeight)
            {
                GenerateMemo(ref memo, ref parents, ref heights, leftChild);
            }
            if (rightHeight >= leftHeight)
            {
                GenerateMemo(ref memo, ref parents, ref heights, rightChild);
            }
            
            // After finding the main subtree, precompute the height if node is removed
            Precompute(ref memo, ref parents, ref heights, node.val);
        }

        private void Precompute(ref Dictionary<int, int> memo, ref Dictionary<int, TreeNode?> parents, ref Dictionary<int, int> heights, int query)
        {
            int currentNode = query;
            int storeHeight = heights[currentNode];
            TreeNode? parent = parents[currentNode];
            if (parent != null)
            {
                heights[currentNode] = -1;
            }

            while (parent != null) // Loop to root
            {
                // Retrieve child nodes
                TreeNode? leftChild = parent.left;
                int leftHeight = leftChild == null ? -1 : heights[leftChild.val];
                TreeNode? rightChild = parent.right;
                int rightHeight = rightChild == null ? -1 : heights[rightChild.val];

                // Calculate new height
                int newHeight = int.Max(leftHeight, rightHeight);
                heights[currentNode] = storeHeight;

                currentNode = parent.val;
                storeHeight = heights[currentNode];
                heights[currentNode] = newHeight + 1;
                parent = parents[parent.val];
            }

            memo[query] = heights[currentNode];
            heights[currentNode] = storeHeight;
        }

        private int Query(ref Dictionary<int, int> memo, int query)
        {
            // Retrieve height of queried node and store it into a temporary variable
            // Replace the height of that object with 0
            // Loop to the root. Adjust the height if required
            
            return memo.ContainsKey(query) ? memo[query] : -1;
        }
    }
}