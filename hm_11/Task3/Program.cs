using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerPrograms computerPrograms = new ComputerPrograms();
            computerPrograms.AddComputerPrograms(computerPrograms);

            Films films = new Films();
            films.AddFilms(films);

            Music music = new Music();
            music.AddMusic(music);

            var ArrayComputerPrograms = computerPrograms.GetComputerPrograms();
            var ArrayFilms = films.GetFilms();
            var ArrayMusic = music.GetMusic();
        }
    }
}