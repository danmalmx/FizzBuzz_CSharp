using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Loop solution");

            //string text;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //        text = "FizzBuzz";
            //    else if (i % 3 == 0)
            //        text = "Fizz";
            //    else if (i % 5 == 0)
            //        text = "Buzz";
            //    else
            //        text = i.ToString();

            //    Console.WriteLine(text);
            //}


            Console.WriteLine("Recursive Solution");
            RecursiveSolution(1);
            Console.ReadKey();

        }

        private static void RecursiveSolution(int n)
        {
            string text;
            if (n > 100)
                return;

            if (n % 3 == 0 && n % 5 == 0)
                text = "FizzBuzz";
            else if (n % 3 == 0)
                text = "Fizz";
            else if (n % 5 == 0)
                text = "Buzz";
            else
                text = n.ToString();

            Console.WriteLine(text);

            RecursiveSolution(n + 1);

        }

    }
}
