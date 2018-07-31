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
            var wordList = new FileDownloader();
            wordList.Download();
            Console.ReadLine();
        }
    }
}
