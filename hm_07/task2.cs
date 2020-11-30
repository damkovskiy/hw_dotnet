using System;
using System.Collections.Generic;
using System.Text;

namespace hm_07
{
    class task2
    {
        static string[] _words;
        static string _max;
        static string _min;
        public static void del_max(string str1)
        {
            _words = str1.Split(" ");
            _max = _words[0];
            int length = 0;
            for (int i = 0; i < _words.Length; i++)
            {
                if (_words[i].Length > length)
                {
                    _max = _words[i];
                    length = _words[i].Length;
                }
            }
            str1 = str1.Replace(_max, "");
            Console.WriteLine($"строка после удаления самого длинного слова: \n{str1}");
            Console.WriteLine("");
        }
        public static void chanching (string str1)
        {
            int length = str1.Length;
            for (int i = 0; i < _words.Length; i++)
            {
                if (_words[i].Length < length)
                {
                    _min = _words[i];
                    length = _words[i].Length;
                }
            }
            str1 = str1.Replace(_max, "abvgd");
            str1 = str1.Replace(_min, _max);
            str1 = str1.Replace("abvgd", _min);
            Console.WriteLine($"строка после замены местами самого длинного и самого короткого слов: \n{str1}");
            Console.WriteLine("");
        }
        public static void count(string str1)
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (Char.IsLetter(str1[i]))
                {
                    index1++;
                }
                else if (Char.IsPunctuation(str1[i]))
                {
                    index2++;
                }
            }
            Console.WriteLine($"количество букв в строке: {index1}, количество знаков препинания: {index2}");
            Console.WriteLine("");
        }
        public static void sorting (string str1)
        {
            string save;
            for (int i = 0; i < _words.Length-1; i++)
            {
                for (int j = i+1; j < _words.Length; j++)
                {
                    if (_words[i].Length < _words[j].Length)
                    {
                        save = _words[j];
                        _words[j] = _words[i];
                        _words[i] = save;
                    }
                }
                Console.WriteLine(_words[i]);
            }
        }
    }
}
