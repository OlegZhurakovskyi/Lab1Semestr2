using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Lab1Sem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1
            Console.WriteLine("Завдання 1:");

            // Вхідний список чисел
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 5 };

            // Створюємо словник для підрахунку кількості кожного числа
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            // Підрахунок кількості кожного числа в списку
            foreach (int num in numbers)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }

            // Підрахунок пар
            int pairCount = 0;
            foreach (int count in countMap.Values)
            {
                // Додаємо до кількості пар кількість можливих пар для поточного числа
                pairCount += count / 2;
            }

            // Виведення результату
            Console.WriteLine($"Кiлькiсть пар: {pairCount}");





            // Завдання 2
            Console.WriteLine("\nЗавдання 2:");

            // Створення словника
            Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            {"apple", 5},
            {"banana", 3},
            {"orange", 7},
            {"grape", 2}
        };

            // Перемноження значень ключів словника
            int product = 1;
            foreach (var value in dictionary.Values)
            {
                product *= value;
            }

            // Створення відсортованого словника за значеннями
            var sortedDictionary = new SortedDictionary<int, string>();
            foreach (var kvp in dictionary)
            {
                sortedDictionary.Add(kvp.Value, kvp.Key);
            }

            // Виведення сортованого словника
            Console.WriteLine("Сортований словник:");
            foreach (var kvp in sortedDictionary)
            {
                Console.WriteLine($"{kvp.Value}: {kvp.Key}");
            }

            // Збереження результату у JSON файл
            string json = JsonSerializer.Serialize(sortedDictionary, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("sorted_dictionary.json", json);

            Console.WriteLine("Результат був збережений у файлi 'sorted_dictionary.json'.");





            // Завдання 3
            Console.WriteLine("\nЗавдання 3:");

            // Символ C
            char c = 'c';

            // Строкова послідовність A
            string[] sequence = { "cbc", "def", "acca", "aac", "bccb", "a", "ca", "cc", "cwwccwc" };

            // Знайти кількість елементів A, які містять більше одного символу і починаються і закінчуються символом C
            int count3 = sequence.Count(str => str.Length > 1 && str.First() == c && str.Last() == c);

            Console.WriteLine($"Кiлькiсть елементiв, якi мiстять бiльше одного символу i починаються i закiнчуються символом {c}: {count3}");


        }
    }
}
