using System;

namespace SpaceAPI.Data.Interfaces
{
    public interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }
        String CreatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
        String UpdatedBy { get; set; }
    }
}