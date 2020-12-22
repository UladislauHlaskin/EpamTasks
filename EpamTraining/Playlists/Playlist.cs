using EpamTraining.MultimediaFiles;
using EpamTraining.MultimediaFiles.Pictures;
using EpamTraining.MultimediaFiles.Songs;
using EpamTraining.MultimediaFiles.Videos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EpamTraining.Playlists
{
    class Playlist : ICollection<MultimediaFile>
    {
        public DateTime CreationDate { get; }
        public string Name { get; private set; }
        public List<MultimediaFile> MultimediaFiles { get; private set; }

        public int Count => MultimediaFiles.Count;
        public bool IsReadOnly => false; 

        public Playlist()
        {
            CreationDate = DateTime.Now;
            Name = GetDefaultname();
            MultimediaFiles = new List<MultimediaFile>();
        }
        public Playlist(string name)
        {
            CreationDate = DateTime.Now;
            Name = name;
            MultimediaFiles = new List<MultimediaFile>();
        }
        public Playlist(string name, List<MultimediaFile> multimediaFiles) : this(name)
        {
            MultimediaFiles = multimediaFiles;
        }
        public MultimediaFile this[string fileName] => MultimediaFiles.Where(f => f.Filename == fileName).FirstOrDefault();
        public MultimediaFile this[int index] => MultimediaFiles[index];
        private string GetDefaultname()
        {
            throw new NotImplementedException();
        }

        public void Add(MultimediaFile item)
        {
            MultimediaFiles.Add(item);
        }

        public void Clear()
        {
            MultimediaFiles.Clear();
        }

        public bool Contains(MultimediaFile item)
        {
            return MultimediaFiles.Contains(item);
        }

        public void CopyTo(MultimediaFile[] array, int arrayIndex)
        {
            MultimediaFiles.CopyTo(array, arrayIndex);
        }

        public bool Remove(MultimediaFile item)
        {
            return MultimediaFiles.Remove(item);
        }

        public IEnumerator<MultimediaFile> GetEnumerator()
        {
            return MultimediaFiles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return MultimediaFiles.GetEnumerator();
        }
    }
}
