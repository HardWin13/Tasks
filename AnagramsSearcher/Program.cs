using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Unicode;

namespace AnagramsSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new string[] { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };
            long sum = input.First()[0];
            var result = GetAnagrams(input);
            foreach (var item in result)
                Console.WriteLine("[ " + string.Join(",", item) + " ]");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод получения анаграмм
        /// </summary>
        /// <param name="words">массив со словами</param>
        /// <returns>Группы анаграмм</returns>
        static IEnumerable<Queue<string>> GetAnagrams(string[] words)
        {
            // Сложность O(nmlogm), где n - количество слов, m - количество букв в слове
            var map = new Dictionary<string, Queue<string>>();

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                var letters = word.ToLower().ToCharArray();
                Array.Sort(letters); // Для быстрой сортировки сложность O(mlogm)
                var newWord = new string(letters);

                if (map.ContainsKey(newWord))
                    map[newWord].Enqueue(word);
                else
                {
                    map[newWord] = new Queue<string>();
                    map[newWord].Enqueue(word);
                }
            }

            return map.Values;
        }
    }
}
