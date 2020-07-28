using System.Runtime.Serialization;
using SpaceAPI.Data.Models.API;

namespace SpaceAPI.Data.Models
{
    [DataContract]
    public class StateLog : EntityBase
    {
        
        public StateLog()
        {
             
            
        }
         

        [DataMember]
        public bool Open { get; set; }

       
    }
}