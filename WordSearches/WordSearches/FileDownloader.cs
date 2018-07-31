using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WordSearches
{
    public class FileDownloader
    {
        public void Download()
        {
            var wc = new WebClient();
            //wc.DownloadData("https://raw.githubusercontent.com/dwyl/english-words/master/words.txt", @"C:\Users\timo\source\repos\Apprenticeship\WordSearches\wordlist.txt");
            var data = wc.OpenRead("https://raw.githubusercontent.com/dwyl/english-words/master/words.txt");

            var sr = new StreamReader(data);

            string currentLine;

            do
            {
                currentLine = sr.ReadLine();
                    //Console.WriteLine(currentLine);
            }

            while (currentLine != null);

            data.Close();

        }
    }
}
