using System;

namespace Task_1_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A: Display all integers between 1 and 100 by using the while loop.");
            int a = 1;
            while (a <= 100)
            {

                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine("B: Display all integers between 2 and 1000 by using the for loop.");

            for (int b = 2; b <= 1000; b += 2)
            {

                Console.WriteLine(b);

            }
        }
    }
}
//List all integers between 1 and 100 by using the while loop.