using System;
using System.Text;

namespace EpamTraining.MultimediaFiles.Videos
{
    /// <summary>
    /// Not full info, just for example
    /// </summary>
    class VideoInfo
    {
        public double Duration { get; }
        public int ResolutionX { get; }
        public int ResolutionY { get; }
        public double Ratio => Math.Round(Convert.ToDouble(ResolutionX / ResolutionY), 4);
    }
}
