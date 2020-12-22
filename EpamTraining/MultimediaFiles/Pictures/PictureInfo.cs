using System;

namespace EpamTraining.MultimediaFiles.Pictures
{
    /// <summary>
    /// Not full info, just for example
    /// </summary>
    class PictureInfo
    {
        public int ResolutionX { get; }
        public int ResolutionY { get; }
        public double Ratio => Math.Round(Convert.ToDouble(ResolutionX / ResolutionY), 4);
        // Add more .exif attributes?
    }
}
