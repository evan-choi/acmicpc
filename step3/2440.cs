using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = input; i > 0; i--)
            Console.WriteLine(new string('*', i));
    }
}