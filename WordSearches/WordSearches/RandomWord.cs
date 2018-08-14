using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearches
{
    class RandomWord
    {
        public string randomWord()
        {
            var random = new Random();
            var randomWord = WordList.wordList[random.Next(0, WordList.wordList.Count)];
            return randomWord;

        }
    }
}
