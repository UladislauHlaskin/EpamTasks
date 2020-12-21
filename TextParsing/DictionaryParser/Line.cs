using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParsing.DictionaryParser
{
    class Line
    {
        public List<Word> Words { get; set; }
        public string Text { get; }
        public int Number { get; }
        public Line(string text, int number)
        {
            Text = text;
            Number = number;
            Words = WordSeparator.GetWords(this);
        }
    }
}
