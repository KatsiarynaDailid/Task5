using System;
using Task5;


/*      Задания к модулю Collections:
               1.	Сравнить скорость следующих операций для коллекций: List, LinkedList, Dictionary, Queue, Stack, SortedSet, SortedDictionary
               a.	добавление элементов
               b.	чтение элементов
               c.	удаление элементов
               d.	[optional] поиск элементов
               На выходе должен быть файл, в котором описана разница во времени выполнения операций.
*/


namespace ConsoleForCollections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity of elements for measuring the speed of operations with collections: ");
            int n;
            while (!(Int32.TryParse(Console.ReadLine(), out n) && n > 0)) {

                Console.WriteLine("You should enter only positive integer number.Try again...");
            }

            CheckTime ct = new CheckTime();
            MeasureTimeResults(n, ct);
            FileWrite fileWrite = new FileWrite();
            fileWrite.WriteResultsInAFile(ct);
            Console.WriteLine("Type any key to exit...");
            Console.ReadLine();

        }



        public static void MeasureTimeResults(int n, CheckTime ct)
        {         
            ct.MeasureAddTime(n);
            ct.MeasureReadTime(n);
            ct.MeasureFindTime(n);
            ct.MeasureRemoveTime(n);
        }

    }
}
