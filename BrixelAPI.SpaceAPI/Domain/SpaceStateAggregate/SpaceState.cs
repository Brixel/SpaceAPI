using System.Collections.Generic;
using Newtonsoft.Json;

namespace BrixelAPI.SpaceState.Domain.SpaceStateAggregate
{
    // Static domain, no to be tracked in the DbContext
    public class SpaceState
    {
        public string Api { get; private set; }
        public string Space { get; private set; }
        public string Logo { get; private set; }

        public string Url { get; private set; }

        public Location Location { get; private set; }

        public Spacefed Spacefed { get; private set; }

        public Contact Contact { get; private set; }

        [JsonProperty("Issue_Report_Channels")]
        public List<string> IssueReportChannels { get; private set; }

        public State State { get; private set; }
        public List<string> Projects { get; private set; }

        public Cache Cache { get; private set; }

        private SpaceState()
        {
            
        }

        [JsonConstructor]
        private SpaceState(string api, string space, string logo, string url, Location location, Spacefed spacefed, Contact contact, List<string> issueReportChannels, State state, List<string> projects, Cache cache)
        {
            Api = api;
            Logo = logo;
            Url = url;
            Space = space;
            Location = location;
            Spacefed = spacefed;
            Contact = contact;
            IssueReportChannels = issueReportChannels;
            State = state;
            Projects = projects;
            Cache = cache;
        }

        public static SpaceState Create()
        {
            return new SpaceState()
            {
                Api = "0.13",
                Space = "Brixel",
                Logo = "https://www.brixel.be/wp-content/uploads/2015/09/Logo_small_transparant.png",
                Url = "http://brixel.be",
                Location = new Location
                {
                    Address = "Spalbeekstraat 34, 3510 Spalbeek, Belgium",
                    Lat = (float)50.9509978,
                    Lon = (float)5.2305834
                },
                Spacefed = new Spacefed
                {
                    Spacenet = false,
                    Spacephone = false,
                    Spacesaml = false
                },
                Contact = new Contact
                {
                    Email = "info@brixel.be",
                    Twitter = "@hs_hasselt"
                },
                IssueReportChannels = new List<string> { "email" },
                Projects = new List<string>()
                {
                    "https://www.brixel.be/projecten/"
                },
                State = new State()
                {
                    Open = false,
                },
                Cache = new Cache
                {
                    Schedule = "h.01"
                }
            };
        }

        public void ChangeState(in bool requestIsOpen)
        {
            State.ChangeState(requestIsOpen);
        }
    }

    public class State
    {
        public bool Open { get; set; }

        public void ChangeState(in bool requestIsOpen)
        {
            Open = requestIsOpen;
        }
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
