using System;

class Program
{
    static void Main()
    {
        string line = Console.ReadLine();

        for (int i = 0; i < line.Length; i++)
        {
            Console.Write(line[i]);

            if (i % 10 == 9)
                Console.Write('\n');
        }
    }
}