using System;
using System.Configuration;
using System.IO;
using TextParsing.DictionaryParser;

namespace TextParsing.TextFile
{
    /// <summary>
    /// Возможность сохранения объектной модели в виде текстового файла;
    /// </summary>
    class ResultTextFile : IDisposable
    {
        /// <summary>
        /// Использование конфигурации для хранения путей к файлам;
        /// </summary>
        //public static readonly string Path = ConfigurationManager.AppSettings.Get("ResultFile");
        //public static void Write(Dictionary dictionary)
        //{
        //    using(StreamWriter writer = new StreamWriter(Path))
        //    {
        //        writer.Write(dictionary.ToString("G"));
        //    }
        //}
        //public static void Write(string path, Dictionary dictionary)
        //{
        //    using (StreamWriter writer = new StreamWriter(path))
        //    {
        //        writer.Write(dictionary.ToString("G"));
        //    }
        //}
        public static readonly string DefaultPath = ConfigurationManager.AppSettings.Get("ResultFile");
        private bool _isDisposed = false;
        private TextWriter _writer;
        public string Path { get; set; }
        public ResultTextFile()
        {
            Path = DefaultPath;
            _writer = new StreamWriter(Path);
        }
        public ResultTextFile(string path)
        {
            Path = path;
            _writer = new StreamWriter(Path);
        }
        public void Write(Dictionary dictionary)
        {
            _writer.Write(dictionary.ToString("G"));
            Dispose();
        }
        public void Dispose()
        {
            if (!_isDisposed)
            {
                if (_writer != null)
                {
                    _writer.Flush();
                    _writer.Close();
                    _writer = null;
                }
                _isDisposed = true;
            }
        }
    }
}
