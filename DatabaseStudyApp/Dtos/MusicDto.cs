namespace DatabaseStudyApp.Dtos
{
    /// <summary>
    /// Музыка (Песня) - DTO
    /// </summary>
    public class MusicDto : BaseDto
    {
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string Language { get; set; }

        public MusicGroupDto MusicGroup { get; set; }

    }
}
