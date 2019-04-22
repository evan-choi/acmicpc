using System;
using System.Text;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        var builder = new StringBuilder();

        for (int i = 1; i <= input; i++)
        {
            if (i > 1)
                builder.Append('\n');

            builder.Append(i.ToString());
        }

        Console.WriteLine(builder);
    }
}