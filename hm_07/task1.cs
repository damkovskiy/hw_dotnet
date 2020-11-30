using System;
using System.Collections.Generic;
using System.Text;

namespace hm_07
{
    class task1
    {
        static string[] _words;
        public static void array(string str)
        {
            _words = str.Split(';');
            chanching();
        }
        static void chanching()
        {
            for (int i = 0; i < _words.Length; i++)
            {
                _words[i] = _words[i].Replace('о', 'А');
                _words[i] = _words[i].Replace('О', 'А');
            }
            show();
        }
        static void show()
        {
            for (int i = 0; i < _words.Length; i++)
            {
                Console.WriteLine(_words[i]);
            }
        }
    }
}
            
        
    

