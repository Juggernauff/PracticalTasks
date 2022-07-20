using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CrossInform
{
    internal class FrequencyAnalysis
    {
        private string filePath;
        public FrequencyAnalysis(string filePath)
        {
            this.filePath = filePath;
        }

        private static IEnumerable<string> SwimParts(string source, int length)
        {
            for (var i = length; i <= source.Length; i++)
                yield return source.Substring(i - length, length);
        }
        public  IEnumerable<string>  GetTriplets()
        {
            var triplets = new ConcurrentDictionary<string, int>();// ConcurrentDictionary<string, int>
            Parallel.ForEach(File.ReadAllLines(filePath), str =>
            {
                var groups = SwimParts(str, 3)
                .Where(str => str.All(ch => char.IsLetter(ch)))
                .GroupBy(str => str);
                
                foreach(var triplet in groups.Select(gr => gr.Key))
                    triplets.AddOrUpdate(triplet, 1, (triplet, oldValue) => oldValue + 1);
            });
            return triplets.OrderByDescending(t => t.Value).Take(10).Select(t => t.Key + " " + t.Value);
        }
        public void Print(IEnumerable<string> elements)
        {

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
