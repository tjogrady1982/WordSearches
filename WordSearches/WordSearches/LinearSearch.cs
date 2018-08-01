using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearches
{
    public class LinearSearch
    {
        public string FindWord(string word)
        {
            foreach (var item in WordList.wordList)
            {
                if (item == word)
                {
                    
                    break;
                }

              
            }
            return ("Word Found");
        }
    }
}
