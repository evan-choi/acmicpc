using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
            Console.WriteLine(new string('*', i));
    }
}