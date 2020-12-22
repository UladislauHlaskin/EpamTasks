using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextParsing.TextFile;

namespace TextParsing.DictionaryParser
{
    class Dictionary : IDisposable
    {
        public int PageCount { get; private set; }
        public List<DictionaryWord> DictionaryWords { get; set; }
        List<IGrouping<string, DictionaryWord>> GroupedWords => DictionaryWords
            .GroupBy(w => w.Value[0].ToString().ToUpper())
            .ToList();
        public Dictionary()
        {
            DictionaryWords = new List<DictionaryWord>();
            PageCount = 0;
        }
        public void AddPageFromFile(SourceTextFile sourceTextFile)
        {
            bool isFileRead = false;
            while (!isFileRead)
            {
                PageCount++;
                var lines = sourceTextFile.ReadPage();
                if (lines.Count == 0)
                {
                    isFileRead = true;
                }
                else
                {
                    foreach (var l in lines)
                    {
                        Line line = new Line(l, PageCount);
                        AddLine(line);
                    }
                }
            }
        }
        private void AddLine(Line line)
        {
            bool isNewWordAdded = false;
            foreach (var word in line.Words)
            {
                var wordFromDictionary = DictionaryWords.Where(w => w.Value == word.Value).FirstOrDefault();
                if (wordFromDictionary != null && !string.IsNullOrEmpty(word.Value))
                {
                    if (!wordFromDictionary.PageNumbers.Contains(word.Line.Number))
                    {
                        wordFromDictionary.PageNumbers.Add(word.Line.Number);
                    }
                    wordFromDictionary.Count++;
                }
                else
                {
                    AddDictionaryWord(word);
                    isNewWordAdded = true;
                }
            }
            if(isNewWordAdded)
            {
                SortDictionaryWords();
            }
        }
        private void AddDictionaryWord(Word word)
        {
            DictionaryWords.Add(new DictionaryWord(word.Value, word.Line.Number));
        }
        private void SortDictionaryWords()
        {
            DictionaryWords = DictionaryWords.OrderBy(w => w.Value).ToList();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var word in DictionaryWords)
            {
                sb.AppendLine($"{word}");
            }    
            return sb.ToString();
        }
        /// <summary>
        /// </summary>
        /// <param name="format"> G - grouped, anything else - default ToString</param>
        public string ToString(string format)
        {
            string groupedFormat = "G";
            if (format != groupedFormat)
            {
                return ToString();
            }
            else
            {
                return GroupedToString();
            }
        }
        private string GroupedToString()
        {
            var groupedWords = GroupedWords;
            StringBuilder sb = new StringBuilder();
            foreach(var letter in groupedWords)
            {
                sb.AppendLine($"{letter.Key.ToString().ToUpper()}");
                foreach(var word in letter)
                {
                    sb.AppendLine($"{word}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        /// <summary>
        /// TODO
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
