using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextParsing.DictionaryParser
{
    class WordSeparator
    {
        private static readonly string[] _separators = new string[] 
        { " ", ".", ",", ":", "!", "?", "?!", "!?", "...", "\n", "\t", "(", ")", "«", "»", ";", "[", "]", "<", ">", "\"" };
        public static List<Word> GetWords(Line line)
        {
            var words = line.Text.Split(_separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => Regex.Replace(w, @"\s+", ""))
                .ToList();
            int position = 1;
            var result = new List<Word>();
            foreach (var w in words)
            {
                result.Add(new Word(w, position++, line));
            }
            return result;
        }
    }
}
