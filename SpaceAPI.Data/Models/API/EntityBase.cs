#region

using System;
using System.Runtime.Serialization;
using SpaceAPI.Data.Interfaces;

#endregion

namespace SpaceAPI.Data.Models.API
{
    public interface IEntityBase
    {
        int Id { get; set; }
    }

    [DataContract]
    public class EntityBase : IAuditableEntity, IEntityBase
    {
        #region IAuditableEntity Members

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public string CreatedBy { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }

        [DataMember]
        public string UpdatedBy { get; set; }

        #endregion

        #region IEntityBase Members

        [DataMember]
        public int Id { get; set; }

        #endregion
    }
}