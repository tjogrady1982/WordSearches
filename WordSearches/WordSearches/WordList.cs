using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearches
{
    public static class WordList
    {
        public static List<string> wordList; // Static List instance

        static WordList()
        {
            wordList = new List<string>();
            
        }


        public static void AddToList(string value)
        {
            wordList.Add(value);
        }
    }
}
