using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRACTISE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 1 and 100:");

            for (int number = 2; number <= 100; number++)
            {
                bool isPrime = true;

                // Check if the number is divisible by any integer from 2 to its square root
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                // If the number is prime, print it
                if (isPrime)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
