using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; i++)
            Console.WriteLine("{0} * {1} = {2}", input, i, input * i);
    }
}