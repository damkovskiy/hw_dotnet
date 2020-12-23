using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Music : Store, IMethods
    {
        Music[] _music = new Music[5];
        int _count;

        public string Singer { get; set; }
        public int Length { get; set; }

        public void AddMusic(Music music)
        {
            if (_count >= 5) return;
            _music[_count] = music;
            _count++;
        }

        public Music[] GetMusic()
        {
            return _music;
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
