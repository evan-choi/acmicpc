using System;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        string[] input = Console.ReadLine().Split(' ');
        double total = 0;
        int max = 0;

        foreach (string x in input)
        {
            int v = int.Parse(x);

            if (max < v)
                max = v;

            total += v;
        }

        Console.WriteLine(total / input.Length * 100 / max);
    }
}