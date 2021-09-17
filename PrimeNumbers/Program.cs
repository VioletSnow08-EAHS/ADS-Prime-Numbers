using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating Prime Numbers... Please wait.");
            System.Threading.Thread.Sleep(100);

            for (var i = 1; i <= 1000; i += 2)
            {
                if (isPrime(i) && i != 1) Console.WriteLine(i);
            }
        }

        public static bool isPrime(int num)
        {
            bool isPrime = true;                // By Default the number IS prime.
            
            for (int x = 2; x < num; x++)       // We start at 2, because ultimately every number can be divided by 1.
            {
                if ((num % x) == 0) isPrime = false;
                /*
                 Scenario 1:
                    If num(5) divided by x(2) has a remainder of 0, then it is not prime.
                    Otherwise, go to x(3).
                    If all numbers up until the number before num are % == 0, then it is still prime.
                    
                Scenario 2:
                    If num(4) divided by x(2) has a remainder of 0, then it is not prime. But it does.
                    So isPrime = false and then return it.
                 */
            }

            return isPrime;
        }
    }
}