using System;

namespace Task_1
{
    public class Song
    {
        public string SongName { get; set; }
        public int SongDuration { get; set; }
        public string SongAuthor { get; set; }
        public int SoungCreationYear { get; }

        public Song()
        {
            SoungCreationYear = DateTime.Now.Year;
        }
    }
}