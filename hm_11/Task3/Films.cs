using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Films : Store, IMethods
    {
        Films[] _films = new Films[5];
        int _count;

        public string Director { get; set; }
        public string MainActor { get; set; }
        public string MainActress { get; set; }

        public void AddFilms(Films films)
        {
            if (_count >= 5) return;
            _films[_count] = films;
            _count++;
        }

        public Films[] GetFilms()
        {
            return _films;
        }
    
    public void Pay()
        {
            throw new NotImplementedException();
        }

        public string RetrieveInformation(string data)
        {
            throw new NotImplementedException();
        }
    }
}
