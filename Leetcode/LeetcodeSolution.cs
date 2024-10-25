using System.Collections;

namespace Leetcode;

public abstract class LeetcodeSolution
{
    private bool CompareResult<T>(T answer, T result)
    {
        if (answer is IList answerList && result is IList resultList)
        {
            return CompareLists(answerList, resultList);
        }
        
        return answer.Equals(result);
    }
    
    private bool CompareLists(IList answer, IList result)
    {
        if (answer.Count != result.Count)
        {
            return false;
        }

        for (int i = 0; i < answer.Count; i++)
        {
            if (!answer[i].Equals(result[i]))
            {
                return false;
            }
        }

        return true;
    }

    public void PrintResult<T>(T answer, T result)
    {
        if (CompareResult(answer, result))
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }
    
    public void PrintResult(IList answer, IList result)
    {
        if (CompareResult(answer, result))
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }
}