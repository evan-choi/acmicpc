using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string line = Console.ReadLine();

            if (line == null || line.Length == 0)
                break;

            Console.WriteLine(line);
        }
    }
}