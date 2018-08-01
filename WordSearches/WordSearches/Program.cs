using System;
using System.Collections.Generic;
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
            
           //foreach(var item in WordList.wordList)
           // {
           //     Console.WriteLine();
           // }

            var binary = new BinarySearch();
            binary.FindWord("zebra");
            
            Console.ReadLine();
        }
    }
}
