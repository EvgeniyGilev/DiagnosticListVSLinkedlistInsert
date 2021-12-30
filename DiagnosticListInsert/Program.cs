using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace DiagnosticListInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText(@"C:\temp1\Text1.txt");

            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            List<string> wordslist = new List<string>();

            // Запустим таймер
            var watch = Stopwatch.StartNew();

            //заполнили список AddRange
            wordslist.AddRange(words);
            Console.WriteLine($"Заполнили список AddRange за: {watch.Elapsed.TotalMilliseconds}  мс");

            //очистим список
            wordslist.Clear();

            watch = Stopwatch.StartNew();

            //заполнили список в цикле foreach
            foreach (var word in words)
            {
                wordslist.Add(word);
            }

            Console.WriteLine($"Заполнили список в цикле за: {watch.Elapsed.TotalMilliseconds}  мс");

            watch = Stopwatch.StartNew();

            // Выполним вставку
            wordslist.Add("картошка");

            // Выведем результат
            Console.WriteLine($"Вставка в  словарь за : {watch.Elapsed.TotalMilliseconds}  мс");
        }
    }
}
