using System;

class Program
{
    static void Main()
    {
        string[] weeks = new string[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
        string[] input = Console.ReadLine().Split(' ');
        int m = int.Parse(input[0]);
        int d = int.Parse(input[1]);

        for (int i = 1; i < m; i++)
        {
            if (i == 2)
                d += 28;
            else if (i == 4 || i == 6 || i == 9 || i == 11)
                d += 30;
            else
                d += 31;
        }

        Console.WriteLine(weeks[d % 7]);
    }
}