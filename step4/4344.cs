using System;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        while (count-- > 0)
        {
            string[] input = Console.ReadLine().Split(' ');
            int t = int.Parse(input[0]);
            int p = 0;
            double v = 0;

            for (int i = 1; i < input.Length; i++)
                v += int.Parse(input[i]);

            v /= t;

            for (int i = 1; i < input.Length; i++)
            {
                if (int.Parse(input[i]) > v)
                    p++;
            }

            Console.WriteLine("{0:0.000}%", Math.Round(p / (double)t * 100, 3));
        }
    }
}