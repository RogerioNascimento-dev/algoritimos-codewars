using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStats.Entities
{
    public class Stats
    {
        // Total number of all words in the document
        public int NumberOfAllWords { get; set; }

        // Returns number of words that consist only from digits e.g. 13455, 98374
        public int NumberOfWordsThatContainOnlyDigits { get; set; }

        // Returns number of words that start with a lower letter e.g. a, d, z
        public int NumberOfWordsStartingWithSmallLetter { get; set; }

        // Returns number of words that start with a capital letter e.g. A, D, Z
        public int NumberOfWordsStartingWithCapitalLetter { get; set; }

        // Returns the first longest word in the document
        public string TheLongestWord { get; set; }

        // Returns the first shortest word in the document
        public string TheShortestWord { get; set; }
    }
}
