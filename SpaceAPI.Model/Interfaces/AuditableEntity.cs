using System;

namespace SpaceAPI.Data.Interfaces
{
    public abstract class AuditableEntity : IAuditableEntity
    {
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public String UpdatedBy { get; set; }
    }
}