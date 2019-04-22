using System;

class Program
{
    static void Main()
    {
        int input1 = int.Parse(Console.ReadLine().Split(' ')[1]);
        string[] input2 = Console.ReadLine().Split(' ');

        foreach (string input in input2)
        {
            if (int.Parse(input) < input1)
                Console.Write(input + " ");
        }
    }
}