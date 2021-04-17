using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseStudyApp.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        [Column("_created")]
        public DateTime RecordCreated { get; set; }

        [Column("_updated")]
        public DateTime? RecordUpdated { get; set; }

        [Column("_deleted")]
        public DateTime? RecordDeleted { get; set; }

    }
}
