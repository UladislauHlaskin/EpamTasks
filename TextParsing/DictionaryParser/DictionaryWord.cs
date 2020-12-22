using System.Collections.Generic;
using System.Text;

namespace TextParsing.DictionaryParser
{
    class DictionaryWord
    {
        public string Value { get; }
        public int Count { get; set; }
        public List<int> PageNumbers { get; set; }
        public DictionaryWord(string value)
        {
            Value = value;
            Count = 0;
            PageNumbers = new List<int>();
        }
        public DictionaryWord(string value, int pageNumber) : this(value)
        {
            PageNumbers.Add(pageNumber);
            Count++;
        }
        public override string ToString()
        {
            int width = 30;
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Value}");
            for (int i = 0; i < width - Value.Length - Count.ToString().Length; i++)
            {
                sb.Append(".");
            }
            sb.Append($"{Count}:");
            foreach (var pageNumber in PageNumbers)
            {
                sb.Append($" {pageNumber}");
            }
            return sb.ToString();
        }
    }
}
