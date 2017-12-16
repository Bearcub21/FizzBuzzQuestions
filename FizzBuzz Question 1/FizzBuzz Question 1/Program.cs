using System;

/*Write a program that prints the numbers from 1 to 100. 
But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
For numbers which are multiples of both three and five print "FizzBuzz"*/


namespace FizzBuzz_Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                //If number is multiple of both 3 & 5 print "FizzBuzz".
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz\n");
                }

                //If number is multiple of 5 print "Buzz".
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz\n");
                }

                //If number is multiple of 3 print "Fizz".
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz\n");

                }

                //Default case. 
                else
                {
                    Console.WriteLine(i + "\n");
                }

            }

            Console.ReadKey();
        }
    }
}
