namespace SpaceAPI.Data.Models
{
    public class Response
    {
        public enum StatusType
        {
            Open,
            Closed,
            Unknown
        };
        public StatusType Status { get; set; }
    }
}