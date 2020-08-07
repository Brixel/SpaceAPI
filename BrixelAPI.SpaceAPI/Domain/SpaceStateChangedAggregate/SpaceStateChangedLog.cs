using System;

namespace BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate
{
    public class SpaceStateChangedLog
    {
        public bool IsOpen { get; set; }
        public string ChangedByUser { get; set; }
        public DateTime ChangedAtDateTime { get; set; }
    }
}