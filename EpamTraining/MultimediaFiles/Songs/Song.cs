using System;

namespace EpamTraining.MultimediaFiles.Songs
{
    internal class Song : MultimediaFile
    {
        public Sound SongData { get; private set; }
        public SongInfo Info { get; }
        public Song
            (string filename, string extension, Sound songData, SongInfo info) : 
            base(filename, extension)
        {
            MultimediaFileType = MultimediaFileType.Song;
            SongData = songData;
            Info = info;
        }
    }
}
