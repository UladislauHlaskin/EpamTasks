namespace EpamTraining.Mediaplayer
{
    class MediaplayerSettings
    {
        public bool IsPlaylistLoop { get; set; }
        public bool IsOneFileLoop { get; set; }
        public Background Background { get; set; }
        public MediaplayerSettings()
        {
            IsPlaylistLoop = true;
            IsOneFileLoop = false;
            Background = Background.Dark;
        }
    }
    enum Background
    {
        Bright,
        Dark,
        Grey,
        White
    }
}
