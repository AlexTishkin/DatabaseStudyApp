using System;
using System.Collections.Generic;

namespace DatabaseStudyApp.Entities
{
    /// <summary>
    /// Музыкальная группа
    /// </summary>
    public class MusicGroup : BaseEntity
    {
        public string Name { get; set; }
        public DateTime? CreationYear { get; set; }

        public List<Music> Musics { get; set; }

        public MusicGroup()
        {
            Musics = new List<Music>();
        }

    }
}
