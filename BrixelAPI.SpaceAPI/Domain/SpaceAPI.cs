using System.Collections.Generic;

namespace BrixelAPI.SpaceAPI.Domain
{
    public class SpaceAPI
    {
        public string Api = "0.13";
        public string Space = "Brixel";
        public string Logo = "https://wiki.brixel.be/images/Brixel_Logo.png";

        public string Url = "http://brixel.be";

        public Location Location = new Location
        {
            Address = "Spalbeekstraat 34, 3510 Spalbeek, Belgium",
            Lat = (float) 50.9509978,
            Lon = (float) 5.2305834
        };

        public Spacefed Spacefed = new Spacefed
        {
            Spacenet = false,
            Spacephone = false,
            Spacesaml = false
        };

        public Contact Contact = new Contact
        {
            Email = "info@brixel.be",
            Irc = "irc://irc.freenode.net/brixel",
            Ml = "brixel-public@discuss.brixel.be",
            Twitter = "@hs_hasselt"
        };

        public List<string> Issue_Report_Channels = new List<string> { "email" };

        public State State = new State()
        {
            Open = false,
        };
        public string[] Projects { get; set; }

        public Cache Cache = new Cache
        {
            Schedule = "h.01"
        };

        private SpaceAPI()
        {
        }

        public static SpaceAPI Create()
        {
            return new SpaceAPI();
        }
        
    }

    public class State
    {
        public bool Open { get; set; }
    }
    public class Spacefed
    {
        public bool Spacenet { get; set; }
        public bool Spacesaml { get; set; }
        public bool Spacephone { get; set; }
    }

    public class Location
    {
        public string Address { get; set; }
        public float Lon { get; set; }
        public float Lat { get; set; }
    }

    public class Contact
    {
        public string Twitter { get; set; }
        public string Email { get; set; }
        public string Irc { get; set; }
        public string Ml { get; set; }
    }

    public class Cache
    {
        public string Schedule { get; set; }
    }
}
