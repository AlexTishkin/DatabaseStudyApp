using System;

namespace DatabaseStudyApp.Entities
{
    /// <summary>
    /// Музыка (Песня)
    /// </summary>
    public class Music : BaseEntity
    {
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string Language { get; set; }

        /// <summary>
        /// Музыкальная группа (FOREIGN KEY))
        /// </summary>
        public Guid MusicGroupId { get; set; }
        public MusicGroup MusicGroup { get; set; }

    }
}
