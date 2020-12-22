using System;

namespace EpamTraining.MultimediaFiles.Videos
{
    class Video : MultimediaFile
    {
        public VideoData VideoData { get; private set; }
        public VideoInfo Info { get; }
        public Video
            (string filename, string extension, VideoData videoData, VideoInfo info) :
            base(filename, extension)
        {
            MultimediaFileType = MultimediaFileType.Video;
            VideoData = videoData;
            Info = info;
        }

    }
}
