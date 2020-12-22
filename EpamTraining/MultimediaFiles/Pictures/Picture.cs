using System;

namespace EpamTraining.MultimediaFiles.Pictures
{
    class Picture : MultimediaFile
    {
        public Image PictureData { get; private set; }
        public PictureInfo Info { get; }
        public Picture
            (string filename, string extension, Image pictureData, PictureInfo info) :
            base(filename, extension)
        {
            MultimediaFileType = MultimediaFileType.Picture;
            PictureData = pictureData;
            Info = info;
        }
    }
}
