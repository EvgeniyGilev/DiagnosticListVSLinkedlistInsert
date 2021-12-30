using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DiagnosticLinkedListInsert
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

            LinkedList<string> wordslist = new LinkedList<string>();

            // Запустим таймер
            var watch = Stopwatch.StartNew();

            foreach (var word in words)
            {
                wordslist.AddLast(word);
            }

            Console.WriteLine($"Заполнили список за: {watch.Elapsed.TotalMilliseconds}  мс");

            // Выполним вставку первым элементом
            watch = Stopwatch.StartNew();
            wordslist.AddFirst("картошка");

            // Выведем результат
            Console.WriteLine($"Вставка в  словарь первым элементом списка за : {watch.Elapsed.TotalMilliseconds}  мс");
        }
    }
}
