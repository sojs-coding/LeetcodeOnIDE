namespace Leetcode;

public class StringCompressionIII : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        string word;
        string result;
        string answer;

        word = "abcde";
        answer = "1a1b1c1d1e";
        result = solution.CompressedString(word);
        solution.PrintResult(answer, result);
        
        word = "aaaaaaaaaaaaaabb";
        answer = "9a5a2b";
        result = solution.CompressedString(word);
        solution.PrintResult(answer, result);
    }
    
    /*
     * OOP
     * Abstraction
     * Encapsulation
     * Inheritance
     * Polymorphism
     */
    
    /*
     * SOLID
     * Single Responsibility
     * Open-Closed Principle
     * Liskov Substitution Principle
     * Interface Segregation
     * Dependency Inversion
     */
    
    public class Solution : LeetcodeSolution {
        public string CompressedString(string word)
        {
            List<string> compressedString = new List<string>();
            char oldChar = word[0];
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (oldChar == word[i])
                {
                    count++;
                    if (count > 9)
                    {
                        compressedString.Add($"{9}{oldChar.ToString()}");
                        count = 1;
                    }
                }
                else
                {
                    compressedString.Add($"{count}{oldChar.ToString()}");
                    count = 1;
                    oldChar = word[i];
                }
            }
            compressedString.Add($"{count}{oldChar.ToString()}");
            
            return String.Join(String.Empty, compressedString.ToArray());
        }
    }
}