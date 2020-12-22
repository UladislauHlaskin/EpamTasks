using System.Configuration;
using System.IO;
using TextParsing.DictionaryParser;

namespace TextParsing.TextFile
{
    /// <summary>
    /// Возможность сохранения объектной модели в виде текстового файла;
    /// </summary>
    class ResultTextFile
    {
        /// <summary>
        /// Использование конфигурации для хранения путей к файлам;
        /// </summary>
        public static readonly string Path = ConfigurationManager.AppSettings.Get("ResultFile");
        public static void Write(Dictionary dictionary)
        {
            using(StreamWriter writer = new StreamWriter(Path))
            {
                writer.Write(dictionary.ToString("G"));
            }
        }
        public static void Write(string path, Dictionary dictionary)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(dictionary.ToString("G"));
            }
        }
    }
}
