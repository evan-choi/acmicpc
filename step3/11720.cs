using System;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        string line = Console.ReadLine();
        int result = 0;

        foreach (char c in line)
            result += c - 48;

        Console.WriteLine(result);
    }
}