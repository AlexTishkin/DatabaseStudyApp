using DatabaseStudyApp.Dtos;
using System;
using System.Collections.Generic;

namespace DatabaseStudyApp.Services
{
    /// <summary>
    /// Сервис для работы с музыкальными группами
    /// </summary>
    public interface IMusicGroupService
    {
        /// <summary>
        /// Возвращает список музыкальных групп
        /// </summary>
        List<MusicGroupDto> GetList();

        /// <summary>
        /// Возвращает музыкальную группу по Id
        /// </summary>
        MusicGroupDto GetById(Guid id);

        /// <summary>
        /// Сохраняет музыкальную группу
        /// </summary>
        MusicGroupDto Save(MusicGroupDto dto);

        /// <summary>
        /// Удаляет музыкальную группу
        /// </summary>
        void Delete(Guid id);
    }
}
