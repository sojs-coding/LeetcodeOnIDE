namespace Leetcode;

public class IsCircularSentence : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        string sentence;
        bool result;
        bool answer;

        sentence = "leetcode exercises sound delightful";
        answer = true;
        result = solution.IsCircularSentence(sentence);
        solution.PrintResult(answer, result);

        sentence = "eetcode";
        answer = true;
        result = solution.IsCircularSentence(sentence);
        solution.PrintResult(answer, result);

        sentence = "Leetcode is cool";
        answer = false;
        result = solution.IsCircularSentence(sentence);
        solution.PrintResult(answer, result);
    }
    
    public class Solution : LeetcodeSolution {
        public bool IsCircularSentence(string sentence)
        {
            string[] words;
            words = sentence.Split(' ');
            char back = words[0].Last();
            char front;
            for (int i = 1; i < words.Length; i++)
            {
                front = words[i].First();
                if (!front.Equals(back))
                {
                    return false;
                }

                back = words[i].Last();
            }

            front = words[0].First();
            if (!back.Equals(front))
            {
                return false;
            }

            return true;
        }
    }
}