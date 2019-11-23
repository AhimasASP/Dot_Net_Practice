using System;

namespace Task_1
{
    public class SongRecorder
    {
        private Song song = new Song();

        public SongRecorder()
        {
            Console.WriteLine("Please enter the new song name");
            song.SongName = Console.ReadLine();
            Console.WriteLine("Please enter the new song duration");
            song.SongDuration = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Please enter the new song author");
            song.SongAuthor = Console.ReadLine();
        }

        public Object GetSongData()
        {
            var ananimus = new {title = song.SongName, minutes = song.SongDuration, albumYaer = song.SoungCreationYear};
            return ananimus;

        }
    }
}