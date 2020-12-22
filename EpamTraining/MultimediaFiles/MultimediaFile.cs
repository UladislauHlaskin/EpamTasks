namespace EpamTraining.MultimediaFiles
{
    abstract class MultimediaFile
    {
        public string Filename { get; set; }
        public string Extension { get; set; }
        public bool IsPlaying { get; set; }
        public MultimediaFileType MultimediaFileType { get; internal set; }
        public MultimediaFile()
        { 
        }
        public MultimediaFile(string filename, string extension)
        {
            Filename = filename;
            Extension = extension;
        }
    }
}
