using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckTime
    {

        public List<IMyCollection> ListOfCollections { get; set; }
        public List<string> Results { get; set; }


        public CheckTime()
        {
            this.Results = new List<string>();       
            this.ListOfCollections = new List<IMyCollection>();

            ListOfCollections.Add(new CheckList());
            ListOfCollections.Add(new CheckDictionary());
            ListOfCollections.Add(new CheckLinkedList());
            ListOfCollections.Add(new CheckQueue());
            ListOfCollections.Add(new CheckSortedDictionary());
            ListOfCollections.Add(new CheckSortedSet());
            ListOfCollections.Add(new CheckStack());
        }


        public void MeasureAddTime(int n)
        {
            Results.Add($"\r\nResult of adding operations for {n} elements: \r\n");
            Results.Add($"{"Collection".PadRight(27)} Time, ms \r\n");
            foreach (var collection in ListOfCollections)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                collection.AddElement(n);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                Results.Add(Result(collection, elapsedMs, n, "adding"));
                Console.WriteLine("Addition for "+ collection.ToString() + "is completed\n");           
            }
          
        }

        public void MeasureRemoveTime(int n)
        {
            Results.Add($"\r\nResult of removing operations for {n} elements: \r\n");
            Results.Add($"{"Collection".PadRight(27)} Time, ms \r\n");
            foreach (var collection in ListOfCollections)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                collection.RemoveElement(n);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                Results.Add(Result(collection, elapsedMs, n, "removing"));
                Console.WriteLine("Removing for " + collection.ToString() + "is completed\n");
            }
        }


        public void MeasureReadTime(int n)
        {
            Results.Add($"\r\nResult of reading operations for {n} elements: \r\n");
            Results.Add($"{"Collection".PadRight(27)} Time, ms \r\n");
            foreach (var collection in ListOfCollections)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                collection.ReadElement(n);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;                
                Results.Add(Result(collection, elapsedMs, n, "reading"));
                Console.WriteLine("Reading for " + collection.ToString() + "is completed\n");
            }
           
        }



        public void MeasureFindTime(int n)
        {
            Results.Add($"\r\nResult of finding operations for {n} elements: \r\n");
            Results.Add($"{"Collection".PadRight(27)} Time, ms \r\n");
            foreach (var collection in ListOfCollections)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                collection.FindElement(n);
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                Results.Add(Result(collection, elapsedMs, n, "finding"));
                Console.WriteLine("Finding for " + collection.ToString() + "is completed\n");
            }
        }

        public string Result(IMyCollection col, long time, int n, string operation)
        {
            return $"{col.ToString().PadRight(30)} {time.ToString().PadRight(10)}";
        }
    }
}
