using System;

namespace ColibriAPI.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public string CreatedByUser { get; set; }
        public string UpdatedByUser { get; set; }
        public string DeletedByUser { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        public DateTimeOffset DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
