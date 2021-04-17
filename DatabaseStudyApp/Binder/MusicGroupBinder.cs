using DatabaseStudyApp.Dtos;
using DatabaseStudyApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseStudyApp.Binder
{
    public class MusicGroupBinder : BaseBinder<MusicGroupDto, MusicGroup>
    {
        public override MusicGroup ToEntity(MusicGroupDto dto, MusicGroup entity)
        {
            base.ToEntity(dto, entity);

            entity.Name = dto.Name;
            entity.CreationYear = dto.CreationYear;

            // TODO: Ликвидировать повторяющийся код
            if (dto.Musics != null && dto.Musics.Count() > 0)
            {
                var musicBinder = new MusicBinder();
                entity.Musics = new List<Music>();

                foreach (var musicDto in dto.Musics)
                    entity.Musics.Add(musicBinder.ToEntity(musicDto, new Music()));
            }

            return entity;
        }

        public override MusicGroupDto ToDto(MusicGroupDto dto, MusicGroup entity)
        {
            base.ToDto(dto, entity);

            dto.Name = entity.Name;
            dto.CreationYear = entity.CreationYear;

            // TODO: Ликвидировать повторяющийся код
            if (entity.Musics != null && entity.Musics.Count() > 0)
            {
                var musicBinder = new MusicBinder();
                dto.Musics = new List<MusicDto>();

                foreach (var music in entity.Musics)
                    dto.Musics.Add(musicBinder.ToDto(new MusicDto(), music));
            }

            return dto;
        }
    }
}
