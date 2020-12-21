using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParsing.DictionaryParser
{
    class Dictionary
    {
        public List<Word> Words { get; set; }
        public List<DictionaryWord> DictionaryWords { get; set; }
        public Dictionary()
        {
            Words = new List<Word>();
            DictionaryWords = new List<DictionaryWord>();
        }
        public void AddLine(Line line)
        {

        }
    }
}
