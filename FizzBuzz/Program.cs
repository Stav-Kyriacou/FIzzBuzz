using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (counter <= 100)
            {
                if (counter % 5 == 0 && counter % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(counter % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(counter % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(counter);                    
                }

                counter++;
            }
        }
    }
}
