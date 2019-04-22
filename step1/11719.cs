using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string line = Console.ReadLine();

            if (line == null)
                break;

            Console.WriteLine(line);
        }
    }
}