using SpaceAPI.Data.Models.API;

namespace SpaceAPI.Models.API
{
    public class Root
    {
        public Root()
        {
            
        }
        public string Api { get; set; }
        public string Space { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public Location Location { get; set; }
        public Spacefed Spacefed { get; set; }
        public Contact Contact { get; set; }
        public string[] Issue_Report_Channels { get; set; }
        public State State { get; set; }
        public string[] Projects { get; set; }
        public Cache Cache { get; set; }
    }
}