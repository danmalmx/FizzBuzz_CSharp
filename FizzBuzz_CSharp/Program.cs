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
            Console.WriteLine("Foor loop solution");
            string text;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    text = "FizzBuzz";
                else if (i % 3 == 0)
                    text = "Fizz";
                else if (i % 5 == 0)
                    text = "Buzz";
                else
                    text = i.ToString();

                Console.WriteLine(text);
            }
            Console.ReadKey();

        }
    }
}
