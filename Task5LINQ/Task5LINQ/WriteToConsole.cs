using System;
using System.Collections.Generic;
using System.Numerics;



namespace Task5LINQ
{
   public class WriteToConsole
    {
        public void PrintList(List<BigInteger> sequence, string message)
        {
            Console.WriteLine(message+"\n");
            for (int i = 0; i < sequence.Count; i++)
            {
                Console.WriteLine( i+1 +": "+sequence[i].ToString("00"));              
            }
            Console.WriteLine($"The quantity of {message} {sequence.Count}.\n");
        }


        public void PrintNumb(BigInteger numb, string message)
        {
            Console.WriteLine(message + numb);

        }


        public void PrintNumb(double numb, string message)
        {
            Console.WriteLine(message + numb);

        }



       public void PrintResult(OperationsWithFibonacci fib)
        {           
            PrintList(fib.FibonacciSequence, "the fibonacci row:");
            PrintList(fib.GetPrimeNumbers(), "the prime numbers:");
            PrintList(fib.GetNumbersThatDevitedByTheSumOfDigits(), "divaited by sum of the digits numbers:");
            PrintList(fib.GetNumbersThatDevitedByFive(), "divaited by 5:");
            PrintList(fib.GetRootsOfNumbersThatHasDigitTwo(), "the roots of numbers, which has digit 2 is");
            PrintList(fib.SortBySecondDigit(), "the sorted numbers by second digit");
            PrintNumb(fib.GetTheNumberWithBigestSumOfSquresOfDigits(), "\nthe number with bigest sum of squres of the digits: ");
            PrintNumb(fib.TheAvarageNumberOfZeros(), "\nthe average number of zeros: ");
            PrintList(fib.TwoLastDigits(), "\ntwo last digit of the numbers, that divaited by 3: ");

        }
    }
}
