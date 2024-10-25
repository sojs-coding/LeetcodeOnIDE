namespace Leetcode;

public class RemoveSubFoldersfromtheFilesystem : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        IList<string> output;
        IList<string> result;
        string[] folder;
        
        folder = ["/a","/a/b","/c/d","/c/d/e","/c/f"];
        output = ["/a", "/c/d", "/c/f"];
        result = solution.RemoveSubfolders(folder);
        solution.CompareResult(output, result);

        folder = ["/a", "/a/b/c", "/a/b/d"];
        output = ["/a"];
        result = solution.RemoveSubfolders(folder);
        solution.CompareResult(output, result);

        folder = ["/a/b/c", "/a/b/ca", "/a/b/d"];
        output = ["/a/b/c", "/a/b/ca", "/a/b/d"];
        result = solution.RemoveSubfolders(folder);
        solution.CompareResult(output, result);
    }
    
    public class Solution : LeetcodeSolution {
        public IList<string> RemoveSubfolders(string[] folder)
        {
            /*
             
             */
        }
    }
}