using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Configuration;

namespace TextParsing.TextFile
{
    public class SourceTextFile
    {
        public string FilePath { get; }
        private const int _linesPerPage = 10;
        private int _currentPage;
        /// <summary>
        /// Использование конфигурации для хранения путей к файлам;
        /// </summary>
        private static readonly string _defaultFilePath = ConfigurationManager.AppSettings.Get("DefaultSourceFile");
        private static readonly string _defaultText = DefaultSourceText.Text;
        public SourceTextFile()
        {
            //a default file with some text
            if (!File.Exists(_defaultFilePath))
            {
                File.WriteAllText(_defaultFilePath, _defaultText);
            }
            FilePath = _defaultFilePath;
            _currentPage = 0;
        }
        public SourceTextFile(string filePath)
        {
            FilePath = filePath;
            _currentPage = 0;
        }
        public List<string> ReadPage()
        {
            var strings = File.ReadLines(FilePath).Skip(_currentPage * _linesPerPage).Take(_linesPerPage).ToList();
            _currentPage++;
            return strings;
        }
    }
}
