using System;
using System.Text;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        var builder = new StringBuilder();

        while (count-- > 0)
        {
            string[] input = Console.ReadLine().Split(' ');
            builder.AppendLine((int.Parse(input[0]) + int.Parse(input[1])).ToString());
        }

        Console.WriteLine(builder);
    }
}