using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int count = 0;

        while (input > 0)
        {
            count++;

            if (input % 5 == 0)
            {
                input -= 5;
            }
            else if (input % 3 == 0)
            {
                input -= 3;
            }
            else if (input > 5)
            {
                input -= 5;
            }
            else
            {
                count = -1;
                break;
            }
        }                

        Console.WriteLine(count);
    }
}