using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        if (a > b)
        {
            if (b > c)
                Console.WriteLine(b);
            else if (a > c)
                Console.WriteLine(c);
            else
                Console.WriteLine(a);
        }
        else
        {
            if (a > c)
                Console.WriteLine(a);
            else if (b > c)
                Console.WriteLine(c);
            else
                Console.WriteLine(b);
        }
    }
}