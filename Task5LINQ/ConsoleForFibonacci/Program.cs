using System;
using Task5LINQ;



/*          1.	Вычислите, сколько чисел являются простыми (реализовать расширяющий метод для типа int для проверки на простоту);
            2.	Вычислите, сколько чисел делятся на сумму своих цифр;
            3.	Вычислите, есть ли числа, которые делятся на 5;
            4.	Вычислите квадратные корни (округленные до целого вниз) всех чисел, которые имеют в составе цифру 2;
            5.	Отсортируйте числа по убывания их второй цифры;
            6.	Выберите последние 2 цифры для всех чисел, которые делятся на 3 и среди ближайших соседей которых (5 в каждую сторону) есть хотя бы одно, которое делится на 5;
            7.	Посчитайте число которое имеет наибольшую сумму квадратов цифр;
            8.	Посчитайте среднее количество нулей в числах;
*/


namespace ConsoleForFibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {            
            OperationsWithFibonacci fib = new OperationsWithFibonacci();
            fib.GetFibonacciSequence();
            WriteToConsole print = new WriteToConsole();
            print.PrintResult(fib);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }



     
    }
}
