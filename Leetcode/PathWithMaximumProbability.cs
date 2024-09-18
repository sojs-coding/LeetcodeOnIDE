namespace Leetcode;

public class PathWithMaximumProbability : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int n = 3;
        int[][] edges = [[0, 1], [1, 2], [0, 2]];
        double[] succProb = [0.5, 0.5, 0.2];
        int start = 0;
        int end = 2;

        // Console.WriteLine(solution.MaxProbability(n, edges, succProb, start, end));

        n = 3;
        edges = [[0, 1], [1, 2], [0, 2]];
        succProb = [0.5, 0.5, 0.3];
        start = 0;
        end = 2;
        Console.WriteLine(solution.MaxProbability(n, edges, succProb, start, end));

        n = 3;
        edges = [[0, 1]];
        succProb = [0.5];
        start = 0;
        end = 2;
        // Console.WriteLine(solution.MaxProbability(n, edges, succProb, start, end));
    }

    class EdgeProb
    {
        public EdgeProb(int node, double probability)
        {
            Node = node;
            Probability = probability;
        }
        public int Node;
        public double Probability;
    }
    
    public class Solution {
        public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node)
        {
            // Visited Nodes
            HashSet<int> visitedNodes = new HashSet<int>();
            
            // Neighbour Nodes
            List<int> neighbourNodes = new List<int>();
            
            // Edges
            Dictionary<int, List<EdgeProb>> edgeDict = new Dictionary<int, List<EdgeProb>>();
            for (int i = 0; i < edges.Length; i++)
            {
                if (!edgeDict.ContainsKey(edges[i][0]))
                {
                    edgeDict.TryAdd(edges[i][0], new List<EdgeProb>());
                }
                else
                {
                    edgeDict[edges[i][0]].Add(new EdgeProb(edges[i][1], succProb[i]));
                }
            }
            
            // Updated Matrix
            double[][] updatedMatrix = new double[10000][];
            for (int i = 0; i < 10000; i++)
            {
                updatedMatrix[i] = new double[10000];
            }
            
            // Node current prob
            double[] nodeProb = new double[10000];

            int currentNode = start_node;
            nodeProb[currentNode] = 1;
            
            neighbourNodes.Add(start_node);
            while (neighbourNodes.Count > 0)
            {
                currentNode = neighbourNodes[0];
                neighbourNodes.RemoveAt(0);
                foreach (EdgeProb node in edgeDict[currentNode])
                {
                    if (!visitedNodes.Contains(node.Node))
                    {
                        neighbourNodes.Add(node.Node);
                    }
                    double updatedMatrixVal = updatedMatrix[currentNode][node.Node];
                    double newUpdatedMatrixVal = nodeProb[currentNode] * node.Probability;
                    double newVal = Math.Max(updatedMatrixVal,
                        newUpdatedMatrixVal);
                    updatedMatrix[currentNode][node.Node] = newVal;
                    nodeProb[node.Node] = Math.Max(newVal, nodeProb[node.Node]);
                }
            }
            
            return nodeProb[end_node];
        }
    }
}