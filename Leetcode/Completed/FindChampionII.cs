namespace Leetcode;

// https://leetcode.com/problems/find-champion-ii/description/?envType=daily-question&envId=2024-11-26
public class FindChampionII : ILeetcodeSolution 
{
    public void Run()
    {
        throw new NotImplementedException();
    }
    // Java
    // class Solution {
    //     public int findChampion(int n, int[][] edges) {
    //         // n teams
    //         // m edges storing [a -> b]
    //         // a is stronger than b
    //
    //         ArrayList<Integer>[] parentDict = new ArrayList[100];
    //         for (int i = 0; i < edges.length; i++){
    //             if (parentDict[edges[i][1]] == null){
    //                 parentDict[edges[i][1]] = new ArrayList<Integer>();
    //             }
    //             parentDict[edges[i][1]].add(edges[i][0]);
    //         }
    //
    //         int champion = -1;
    //
    //         for (int i = 0; i < n; i++){
    //             if (parentDict[i] == null || parentDict[i].size() == 0){
    //                 if (champion != -1){
    //                     return -1;
    //                 }
    //                 champion = i;
    //             }
    //         }
    //
    //         return champion;
    //     }
    // }
}