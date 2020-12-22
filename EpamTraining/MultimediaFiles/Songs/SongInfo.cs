using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTraining.MultimediaFiles.Songs
{
    internal class SongInfo
    {
        public string Genre { get; private set; }
        public string Band { get; private set; }
        public string Album { get; private set; }
        public string SongName { get; private set; }
        public double Duration { get; private set; }
        public SongInfo (string genre, string band, string album, string songName, double duration)
        {
            Genre = genre;
            Band = band;
            Album = album;
            SongName = songName;
            Duration = duration;
        }
    }
}
