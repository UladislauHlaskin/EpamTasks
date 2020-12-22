using EpamTraining.MultimediaFiles;
using EpamTraining.MultimediaFiles.Pictures;
using EpamTraining.MultimediaFiles.Songs;
using EpamTraining.MultimediaFiles.Videos;
using EpamTraining.Playlists;
using System;
using System.Collections.Generic;

namespace EpamTraining.Mediaplayer
{
    partial class Mediaplayer
    {
        public List<Playlist> Playlists { get; private set; }
        public Playlist CurrentPlaylist { get; private set; }
        public MultimediaFile CurrentMultimediaFile { get; private set; }
        public MediaplayerSettings Settings { get; set; }
        public Mediaplayer() { }
        public Mediaplayer(Playlist playlist)
        {
            CurrentPlaylist = playlist;
            Playlists = new List<Playlist>
            {
                CurrentPlaylist
            };
            CurrentMultimediaFile = CurrentPlaylist[0];
            Settings = new MediaplayerSettings();
        }
        public Mediaplayer(List<Playlist> playlists) : this(playlists[0])
        {
            Playlists = playlists;
        }
        public void Play()
        {
            if (CurrentMultimediaFile != null)
            {
                Play(CurrentMultimediaFile);
            }
        }
        public void Play(MultimediaFile multimediaFile)
        {
            if (multimediaFile.MultimediaFileType == MultimediaFileType.Picture)
            {
                Play(multimediaFile as Picture); // or  Play((Picture)multimediaFile); ?
            }
            else if (multimediaFile.MultimediaFileType == MultimediaFileType.Video)
            {
                Play(multimediaFile as Video); // or  Play((Video)multimediaFile); ?
            }
            else if (multimediaFile.MultimediaFileType == MultimediaFileType.Song)
            {
                Play(multimediaFile as Song); // or  Play((Song)multimediaFile); ?
            }
            else
            {
                throw new NotImplementedException("Unable to play this file.");
            }
        }
        public void Stop(MultimediaFile multimediaFile)
        {
            if (multimediaFile.MultimediaFileType == MultimediaFileType.Picture)
            {
                Stop(multimediaFile as Picture); // or  Stop((Picture)multimediaFile); ?
            }
            else if (multimediaFile.MultimediaFileType == MultimediaFileType.Video)
            {
                Stop(multimediaFile as Video); // or  Stop((Video)multimediaFile); ?
            }
            else if (multimediaFile.MultimediaFileType == MultimediaFileType.Song)
            {
                Stop(multimediaFile as Song); // or  Stop((Song)multimediaFile); ?
            }
            else
            {
                throw new NotImplementedException("Unable to stop this file.");
            }
        }
        public void Pause(MultimediaFile multimediaFile)
        {
            if (multimediaFile.MultimediaFileType == MultimediaFileType.Picture)
            {
                Pause(multimediaFile as Picture); // or  Pause((Picture)multimediaFile); ?
            }
            else if (multimediaFile.MultimediaFileType == MultimediaFileType.Video)
            {
                Pause(multimediaFile as Video); // or  Pause((Video)multimediaFile); ?
            }
            else if (multimediaFile.MultimediaFileType == MultimediaFileType.Song)
            {
                Pause(multimediaFile as Song); // or  Pause((Song)multimediaFile); ?
            }
            else
            {
                throw new NotImplementedException("Unable to pause this file.");
            }
        }
    }
}
