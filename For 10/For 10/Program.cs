// See https://aka.ms/new-console-template for more information

using System;

namespace For
{
    class MyClass
    {
        static void Main(string[] args)
        { 
            double N = Convert.ToInt32(Console.ReadLine());

        double sum = 0.0;

        for (int i = 1; i <= N; i++)
        {
           sum += 1.0 / i;
        }
        Console.WriteLine(sum);
        }
    }
}


