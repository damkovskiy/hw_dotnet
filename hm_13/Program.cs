using System;
using System.Text.Json;

namespace hm_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            song.CreateSong();
            
            Program program = new Program();
            
            var song1 = program.GetSongData(song);

            string json = JsonSerializer.Serialize(song1);

            Console.WriteLine(song1);
            Console.WriteLine("");
            Console.WriteLine(json);
        }

        public object GetSongData(Song song)
        {
            var song1 = new
            {
                Title = song.Name,
                Minutes = song.Duration,
                AlbumYear = song.Year,
                Genre = Song._genre.hip_hop
            };
            return song1;
        }
    }
}
