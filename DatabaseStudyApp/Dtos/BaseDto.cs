using System;

namespace DatabaseStudyApp.Dtos
{
    /// <summary>
    /// Базовый класс для DTO
    /// </summary>
    public abstract class BaseDto
    {
        public Guid Id { get; set; }
    }
}
