using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParsing.DictionaryParser
{
    class Word
    {
        private string _word { get; }
        public int Position { get; }
        public Line Line { get; }
        public Word(string word, int position, Line line)
        {
            _word = word;
            Position = position;
            Line = line;
        }
    }
}
