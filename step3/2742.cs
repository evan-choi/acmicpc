using System;
using System.Text;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        var builder = new StringBuilder();

        for (int i = input; i > 0; i--)
        {
            if (i < input)
                builder.Append('\n');

            builder.Append(i.ToString());
        }

        Console.WriteLine(builder);
    }
}