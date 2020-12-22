using System;
using System.IO;
using System.Text;
using TextParsing.DictionaryParser;
using TextParsing.TextFile;

namespace TextParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuSelection;
            while (true)
            {
                Console.Clear();
                Console.Write(MainMenu());
                menuSelection = Console.ReadLine();
                switch (menuSelection)
                {
                    case "1":
                        UserFileHandler();
                        break;
                    case "2":
                        DefaultFileHandler();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("\nВыберите корректный пункт меню!");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private static string MainMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Разбитие текста на словарь (конкорданс).");
            sb.AppendLine("1. Считать текст с указанного файла.");
            sb.AppendLine("2. Считать текст с файла по умолчанию.");
            sb.AppendLine("3. Выход.");
            sb.Append("Выберите пункт меню: ");
            return sb.ToString();
        }
        static void UserFileHandler()
        {
            string path, menuSelection;
            Console.Clear();
            Console.Write(UserFileDialog());
            path = Console.ReadLine() + ".txt";
            //Разумный exception handling;
            try
            {
                var dictionary = ReadUserFile(path);
                Console.Clear();
                Console.Write(ShowResultDialog());
                menuSelection = Console.ReadLine();
                if (menuSelection == "1")
                {
                    Console.Clear();
                    Console.Write(dictionary.ToString("G"));
                    Console.ReadKey();
                }
                Console.Clear();
                Console.Write(WriteResultDialog());
                menuSelection = Console.ReadLine();
                if (menuSelection == "1")
                {
                    ResultTextFile.Write(dictionary);
                    Console.Clear();
                    Console.WriteLine(ResultWritten());
                    Console.ReadKey();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(NoUserFileExists());
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        static void DefaultFileHandler()
        {
            string menuSelection;
            Console.Clear();
            var dictionary = ReadDefaultFile();
            Console.Clear();
            Console.Write(ShowResultDialog());
            menuSelection = Console.ReadLine();
            if (menuSelection == "1")
            {
                Console.Clear();
                Console.Write(dictionary.ToString("G"));
                Console.ReadKey();
            }
            Console.Clear();
            Console.Write(WriteResultDialog());
            menuSelection = Console.ReadLine();
            if (menuSelection == "1")
            {
                ResultTextFile.Write(dictionary);
                Console.Clear();
                Console.WriteLine(ResultWritten());
                Console.ReadKey();
            }
        }
        private static string ShowResultDialog()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Словарь (конкорданс) сформирован. Отобразить результат?");
            sb.AppendLine("1. Да.");
            sb.AppendLine("2. Нет.");
            sb.Append("Выберите пункт меню: ");
            return sb.ToString();
        }
        private static string WriteResultDialog()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Записать результат в файл {ResultTextFile.Path}?");
            sb.AppendLine("1. Да.");
            sb.AppendLine("2. Нет.");
            sb.Append("Выберите пункт меню: ");
            return sb.ToString();
        }
        private static string ResultWritten()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Результат записан в файл {ResultTextFile.Path}");
            return sb.ToString();
        }
        private static string UserFileDialog()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Укажите путь файла для записи результата (путь\\имя_файла без расширения)");
            return sb.ToString();
        }
        private static string NoUserFileExists()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Не удалось найти файл с указанным путем.");
            return sb.ToString();
        }
        static Dictionary ReadUserFile(string path)
        {
            Dictionary dictionary = new Dictionary();
            SourceTextFile sourceTextFile = new SourceTextFile(path);
            dictionary.AddPageFromFile(sourceTextFile);
            return dictionary;
        }
        static Dictionary ReadDefaultFile()
        {
            Dictionary dictionary = new Dictionary();
            SourceTextFile sourceTextFile = new SourceTextFile();
            dictionary.AddPageFromFile(sourceTextFile);
            return dictionary;
        }

    }
}
