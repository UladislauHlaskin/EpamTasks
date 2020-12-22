namespace TextParsing.DictionaryParser
{
    class Word
    {
        public string Value { get; private set; }
        public int Position { get; }
        public Line Line { get; }
        public Word(string word, int position, Line line)
        {
            Value = word;
            Position = position;
            Line = line;
        }
    }
}
