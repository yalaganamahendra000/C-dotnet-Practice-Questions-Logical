using System;

public static class SecondLargestNumber
{
    public static int? FindSecondLargest(int[] numbers)
    {
        if (numbers.Length == 1 || numbers.Length == 0)
        {
            return null;
        }
        else
        {
            int? highest = null;
            int? second = null;

            foreach (int i in numbers)
            {
                if (highest == null || i > highest)
                {
                    second = highest;
                    highest = i;
                }
                else if (i < highest && (second == null || i > second))
                {
                    second = i;
                }
            }

            // if (second == null)
            // {
            //     return null;
            // }

            return second;
        }
    }

    static void Main(string[] args)
    {   
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input)){
        Console.WriteLine("No second largest number found");
        return;
        }

        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int? result = FindSecondLargest(numbers);

        if (result == null)
        {
            Console.WriteLine("No second largest number found");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}