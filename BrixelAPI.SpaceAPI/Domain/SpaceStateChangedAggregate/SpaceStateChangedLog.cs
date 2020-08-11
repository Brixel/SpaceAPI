using System;

namespace BrixelAPI.SpaceState.Domain.SpaceStateChangedAggregate
{
    public class SpaceStateChangedLog
    {
        public int Id { get; set; }
        public bool IsOpen { get; set; }
        public string ChangedByUser { get; set; }
        public DateTime ChangedAtDateTime { get; set; }
        private SpaceStateChangedLog()
        {
            
        }

        public static SpaceStateChangedLog Create(bool isOpen, string user)
        {
            return new SpaceStateChangedLog()
            {
                IsOpen = isOpen,
                ChangedByUser = user,
                ChangedAtDateTime = DateTime.UtcNow
            };
        }
    }
}