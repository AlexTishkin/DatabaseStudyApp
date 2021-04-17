using DatabaseStudyApp.Dtos;
using DatabaseStudyApp.Entities;

namespace DatabaseStudyApp.Binder
{
    public abstract class BaseBinder<TDto, TEntity>
        where TDto : BaseDto
        where TEntity : BaseEntity
    {
        public virtual TEntity ToEntity(TDto dto, TEntity entity)
        {
            entity.Id = dto.Id;
            return entity;
        }

        public virtual TDto ToDto(TDto dto, TEntity entity)
        {
            dto.Id = entity.Id;
            return dto;
        }
    }
}
