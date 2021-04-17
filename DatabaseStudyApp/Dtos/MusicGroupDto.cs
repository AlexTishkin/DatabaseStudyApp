using System;
using System.Collections.Generic;

namespace DatabaseStudyApp.Dtos
{
    /// <summary>
    /// Музыкальная группа - DTO
    /// </summary>
    public class MusicGroupDto : BaseDto
    {
        public string Name { get; set; }
        public DateTime? CreationYear { get; set; }

        public List<MusicDto> Musics { get; set; }

        public MusicGroupDto()
        {
            Musics = new List<MusicDto>();
        }

        public override string ToString() => $"Музыкальная группа [{Id},{Name},{CreationYear}]";
    }
}
