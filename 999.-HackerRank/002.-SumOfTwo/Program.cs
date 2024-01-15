using System.Numerics;

/*
 
 SumOfTwo([1, 1, 1, 2, 3, 4, 5, 2], 2)
 
It should return: 1
Explanation: there is only one pair sum of witch is equal to 2 (1,1)




ATTENTION: The main trick of this exercise is that its time complexity should be linear. That means you should NOT have any double/triple loops inside or deep recursion.





In the attachment, you can find the file OurSolution.txt. Before opening it, try to solve the exercise yourself.

We have faith in you 💕
 */


namespace _002._SumOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int[] nums = { 5,1,4,4,1};
            int[] nums = { 1, 1, 1, 2, 3, 4, 5, 2 };

            // Target sum to find
            int sumToFind = 3;

            // Call the SumOfTwo method
            int result = Exercise.SumOfTwo(nums, sumToFind);

            Console.WriteLine(result);
        }
    }
}


public class Exercise
{
    public static int SumOfTwo(int[] nums, int SumToFind)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int result = 0;

        foreach (int value in nums)
        {
            int lComplementarioFromValueToSumaToFind = SumToFind - value;

            if (dic.ContainsKey(lComplementarioFromValueToSumaToFind) && dic[lComplementarioFromValueToSumaToFind] > 0)
            {

                dic[lComplementarioFromValueToSumaToFind] -= 1;

                result++;
                continue;
            }
            if (dic.ContainsKey(value))
            {
                dic[value] += 1;
            }
            else
            {
                dic.Add(value, 1);
            }
        }
        return result;
    }
}
