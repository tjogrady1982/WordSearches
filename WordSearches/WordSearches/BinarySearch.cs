using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearches
{
    class BinarySearch
    {

        public string FindWord(string word)
        {
            var High = WordList.wordList.Count;// - 1;
            var Low = 0;
            var Mid = 0;
            bool Found = false;

            while (!Found)
            {
                Mid = ((High + Low) / 2);

                if (word == WordList.wordList[Mid])// handles word being middle word
                {
                    Found = true;
                }
                //else if (word.CompareTo(WordList.wordList[Mid]) > 0)
                else if (string.Compare(word, WordList.wordList[Mid]) == 1)
                {
                    Low = Mid;
                }
                else
                {
                    High = Mid;
                }
            }

            return ("Word Found");
        }
    }
}
