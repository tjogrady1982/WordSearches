using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearches
{
    class Program
    {
        static void Main(string[] args)
        {
            var WebDownload = new FileDownloader();
            WebDownload.Download();

            var linearStopwatch = new Stopwatch();

            linearStopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                var random = new RandomWord();
                var word = random.randomWord();

                var linear = new LinearSearch();
                linear.FindWord(word);
            }
            linearStopwatch.Stop();

            var LinearElapsedTime = linearStopwatch.Elapsed.TotalSeconds.ToString();
            Console.WriteLine("Linear search of 10,000 words took " + LinearElapsedTime + " seconds");

            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                var random = new RandomWord();
                var word = random.randomWord();

                var binary = new BinarySearch();
                binary.FindWord(word);
            }
            stopwatch.Stop();

            var BinaryElapsedTime = stopwatch.Elapsed.TotalSeconds.ToString();
            Console.WriteLine("Binary search of 10,000 words took "+ BinaryElapsedTime+" seconds");
            
            Console.ReadLine();
        }
    }
}
