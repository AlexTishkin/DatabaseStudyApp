using DatabaseStudyApp.Dtos;
using DatabaseStudyApp.Entities;

namespace DatabaseStudyApp.Binder
{
    public class MusicBinder : BaseBinder<MusicDto, Music>
    {
        public override Music ToEntity(MusicDto dto, Music entity)
        {
            base.ToEntity(dto, entity);

            entity.Name = dto.Name;
            entity.Duration = dto.Duration;
            entity.Language = dto.Language;

            return entity;
        }

        public override MusicDto ToDto(MusicDto dto, Music entity)
        {
            base.ToDto(dto, entity);

            dto.Name = entity.Name;
            dto.Duration = entity.Duration;
            dto.Language = entity.Language;

            return dto;
        }
    }
}
