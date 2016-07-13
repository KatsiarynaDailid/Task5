using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task5LINQ
{
    public class OperationsWithFibonacci
    {

        public List<BigInteger> FibonacciSequence { get; set; }

        public OperationsWithFibonacci()
        {
            FibonacciSequence = new List<BigInteger>();
        }

        public void GetFibonacciSequence()
        {
            BigInteger a;
            for (int i = 1; i <= 200; i++)
            {            
                a = GetFibonacci.CountFibonacci(i);           
                FibonacciSequence.Add(a);
            }
        }


        //1 Вычислите, сколько чисел являются простыми(реализовать расширяющий метод для типа int для проверки на простоту);

        public List<BigInteger> GetPrimeNumbers() 
        {
            return FibonacciSequence.Where(s => s.IsPrime()).ToList();        
        }

        //2 Вычислите, сколько чисел делятся на сумму своих цифр;

        public List<BigInteger> GetNumbersThatDevitedByTheSumOfDigits()
        {
           return FibonacciSequence.Where(s => s % s.ToString().Sum(c => c - '0') == 0).ToList();         
        }

        // 3.	Вычислите, есть ли числа, которые делятся на 5;

        public List<BigInteger> GetNumbersThatDevitedByFive()
        {
            return FibonacciSequence.Where(s => s % 5 == 0).ToList();           
        }

        //4.	Вычислите квадратные корни(округленные до целого вниз) всех чисел, которые имеют в составе цифру 2;

        public List<BigInteger> GetRootsOfNumbersThatHasDigitTwo()
        {
            return FibonacciSequence.Where(s => s.ToString().Contains('2'))
            .Select(s => (BigInteger)Math.Exp(BigInteger.Log(s) / 2)).ToList();
        }

        //5.	Отсортируйте числа по убывания их второй цифры;

        public List<BigInteger> SortBySecondDigit()
        {
            return FibonacciSequence
                .Where(n => n.ToString().Length > 1)
                .OrderByDescending(n => n.ToString().ElementAt(1)).ToList();           
        }


        //6.	Выберите последние 2 цифры для всех чисел, которые делятся на 3 и среди ближайших соседей которых(5 в каждую сторону) есть хотя бы одно, которое делится на 5;

        public List<BigInteger> TwoLastDigits()
        {
            return FibonacciSequence
               .Where(s => s % 3 == 0 && s.ToString().Length > 1)
               .Select(s => BigInteger.Parse(s.ToString().Substring(s.ToString().Length - 2)))
               .ToList();
        }

        //7.	Посчитайте число которое имеет наибольшую сумму квадратов цифр;
        public BigInteger GetTheNumberWithBigestSumOfSquresOfDigits()
        {
            var numb = FibonacciSequence.OrderByDescending(n => n.ToString().Sum(c => (c - '0') * (c - '0'))).First();
            return numb;
        }

        //8.	Посчитайте среднее количество нулей в числах;
        public double TheAvarageNumberOfZeros()
        {
            var numb = FibonacciSequence.Select(n => n.ToString().Count(c => c == '0')).ToList().Average();
            return numb;
        }


    }
}
