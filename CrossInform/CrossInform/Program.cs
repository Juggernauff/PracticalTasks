using System;
using System.Diagnostics;

namespace CrossInform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the path to the file: ");
                var filePath = Console.ReadLine();
                Stopwatch stopWatch = Stopwatch.StartNew();
                var frequencyAnalysis = new FrequencyAnalysis(filePath);
                var elements = frequencyAnalysis.GetTriplets();
                frequencyAnalysis.Print(elements);
                stopWatch.Stop();
                Console.WriteLine("Working hours of the program: " + stopWatch.ElapsedMilliseconds + " milliseconds.");
                Console.ReadKey();
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
