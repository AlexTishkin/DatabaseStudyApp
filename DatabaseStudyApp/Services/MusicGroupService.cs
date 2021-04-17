using DatabaseStudyApp.Binder;
using DatabaseStudyApp.Dtos;
using DatabaseStudyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseStudyApp.Services
{
    public class MusicGroupService : IMusicGroupService
    {
        private readonly MusicGroupBinder _musicGroupBinder;

        public MusicGroupService()
        {
            _musicGroupBinder = new MusicGroupBinder();
        }

        public List<MusicGroupDto> GetList()
        {
            using (var db = new AppContext())
            {
                var entities = db.MusicGroups.ToList();

                var dtos = entities
                    .Where(x => x.RecordDeleted == null)
                    .Select(x => _musicGroupBinder.ToDto(new MusicGroupDto(), x))
                    .ToList();

                return dtos;
            }
        }

        public MusicGroupDto GetById(Guid id)
        {
            using (var db = new AppContext())
            {
                var entity = db.MusicGroups
                    .Where(x => x.RecordDeleted == null)
                    .SingleOrDefault(x => x.Id == id);

                return _musicGroupBinder.ToDto(new MusicGroupDto(), entity);
            }
        }

        public MusicGroupDto Save(MusicGroupDto dto)
        {
            var isNew = dto.Id == Guid.Empty;

            using (var db = new AppContext())
            {
                if (isNew)
                {
                    var entity = _musicGroupBinder.ToEntity(dto, new MusicGroup());
                    entity.Id = Guid.NewGuid();
                    entity.RecordCreated = DateTime.Now;

                    db.MusicGroups.Add(entity);
                    db.SaveChanges();
                    return _musicGroupBinder.ToDto(dto, entity);
                }
                else
                {
                    var entity = db.MusicGroups
                        .Where(x => x.RecordDeleted == null)
                        .SingleOrDefault(x => x.Id == dto.Id);

                    _musicGroupBinder.ToEntity(dto, entity);
                    entity.RecordUpdated = DateTime.Now;
                    db.SaveChanges();
                    return dto;
                }
            }
        }

        public void Delete(Guid id)
        {
            using (var db = new AppContext())
            {
                var entity = db.MusicGroups.SingleOrDefault(x => x.Id == id);
                entity.RecordDeleted = DateTime.Now;
                db.SaveChanges();
            }
        }
    }
}
