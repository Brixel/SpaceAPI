using System.Collections.Generic;

namespace BrixelAPI.SpaceState.Domain.SpaceStateAggregate
{
    // Static domain, no to be tracked in the DbContext
    public class SpaceState
    {
        public string Api { get; set; }
        public string Space { get; set; }
        public string Logo { get; set; }

        public string Url { get; set; }

        public Location Location { get; set; }

        public Spacefed Spacefed { get; set; }

        public Contact Contact { get; set; }

        public List<string> Issue_Report_Channels { get; set; }

        public State State { get; set; }
        public string[] Projects { get; set; }

        public Cache Cache { get; set; }

        private SpaceState()
        {
            Api = "0.13";
            Space = "Brixel";
            Logo = "https://wiki.brixel.be/images/Brixel_Logo.png";
            Url = "http://brixel.be";
            Location = new Location
            {
                Address = "Spalbeekstraat 34, 3510 Spalbeek, Belgium",
                Lat = (float) 50.9509978,
                Lon = (float) 5.2305834
            };
            Spacefed = new Spacefed
            {
                Spacenet = false,
                Spacephone = false,
                Spacesaml = false
            };
            Contact = new Contact
            {
                Email = "info@brixel.be",
                Irc = "irc://irc.freenode.net/brixel",
                Ml = "brixel-public@discuss.brixel.be",
                Twitter = "@hs_hasselt"
            };
            Issue_Report_Channels = new List<string> { "email" };
            State = new State()
            {
                Open = false,
            };

            Cache = new Cache
            {
                Schedule = "h.01"
            };
        }

        public static SpaceState Create()
        {
            return new SpaceState();
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
