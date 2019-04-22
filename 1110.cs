using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int t = n, c = 0;

        do
        {
            c++;
        } while ((n ^ (t = t % 10 * 10 + 11 * t / 10 % 10)) != 0);

        Console.WriteLine(c);
    }
}