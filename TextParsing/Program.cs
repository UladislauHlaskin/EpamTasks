using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextParsing.DictionaryParser;
using TextParsing.TextFile;

namespace TextParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            SourceTextFile sourceTextFile = new SourceTextFile("source.txt");
            string test = "one, two: one? one! two two   one  three three.";
            Line line = new Line(test, 1);
        }
    }
}
