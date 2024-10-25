using System.Collections.Immutable;

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
        solution.PrintResult(output, result);

        folder = ["/a", "/a/b/c", "/a/b/d"];
        output = ["/a"];
        result = solution.RemoveSubfolders(folder);
        solution.PrintResult(output, result);

        folder = ["/a/b/c", "/a/b/ca", "/a/b/d"];
        output = ["/a/b/c", "/a/b/ca", "/a/b/d"];
        result = solution.RemoveSubfolders(folder);
        solution.PrintResult(output, result);
    }
    
    public class Solution : LeetcodeSolution {
        public IList<string> RemoveSubfolders(string[] folder)
        {
            /*
            Sort the folders
            Add new parent when parent does not exist in next folder
             */
            string[] folders = folder;
            Array.Sort(folders);
            List<String> parentFolders = new List<string>();
            String currentParent = folders[0];
            int currentParentLength = currentParent.Length;
            parentFolders.Add(currentParent);
            for (int i = 1; i < folders.Length; i++)
            {
                String currentString = folders[i];
                int currentStringLength = currentString.Length;
                if (String.Compare(currentParent + '/', 0, currentString, 0, currentParentLength + 1) != 0)
                {
                    parentFolders.Add(currentString);
                    currentParent = currentString;
                    currentParentLength = currentStringLength;
                }
            }

            return parentFolders.ToArray();
        }
    }
}