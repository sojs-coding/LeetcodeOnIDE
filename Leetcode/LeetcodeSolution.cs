namespace Leetcode;

public abstract class LeetcodeSolution
{
    public bool CompareResult(object answer, object result)
    {
        return answer.Equals(result);
    }

    public void PrintResult(object answer, object result)
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