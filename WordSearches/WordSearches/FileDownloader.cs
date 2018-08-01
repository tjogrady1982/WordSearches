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

        //public string Words { get; set; }
        public void Download()
        {
            var wc = new WebClient();
            var data = wc.OpenRead("https://raw.githubusercontent.com/dwyl/english-words/master/words.txt");

            var sr = new StreamReader(data);

            string currentLine;

            do
            {
                currentLine = sr.ReadLine();

                WordList.AddToList(currentLine);
            }

            while (currentLine != null);

            data.Close();

        }
    }
}
