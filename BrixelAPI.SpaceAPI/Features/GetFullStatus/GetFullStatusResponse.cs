using System.Collections.Generic;

namespace BrixelAPI.SpaceState.Features.GetFullStatus
{
    public class GetFullStatusResponse
    {
        public GetFullStatusResponse(Domain.SpaceStateAggregate.SpaceState spaceState)
        {
            Api = spaceState.Api;
            Space = spaceState.Space;
            Logo = spaceState.Logo;
            Url = spaceState.Url;
            Location = new LocationDTO()
            {
                Address = spaceState.Location.Address,
                Lat = spaceState.Location.Lat,
                Lon = spaceState.Location.Lon
            };
            Spacefed = new SpacefedDTO()
            {
                Spacenet = spaceState.Spacefed.Spacenet,
                Spacephone = spaceState.Spacefed.Spacephone,
                Spacesaml = spaceState.Spacefed.Spacesaml
            };
            Cache = new CacheDTO()
            {
                Schedule = spaceState.Cache.Schedule
            };
            Contact = new ContactDTO()
            {
                Email = spaceState.Contact.Email,
                Irc = spaceState.Contact.Irc,
                Ml = spaceState.Contact.Ml,
                Twitter = spaceState.Contact.Twitter
            };
            Issue_Report_Channels = spaceState.IssueReportChannels;
            State = new StateDTO()
            {
                Open = spaceState.State.Open
            };
            Projects = spaceState.Projects;

        }

        public string Api { get; set; }
        public string Space { get; set; }
        public string Logo { get; set; }

        public string Url { get; set; }

        public LocationDTO Location { get; set; }

        public SpacefedDTO Spacefed { get; set; }

        public ContactDTO Contact { get; set; }

        public List<string> Issue_Report_Channels { get; set; }

        public StateDTO State { get; set; }
        public List<string> Projects { get; set; }

        public CacheDTO Cache { get; set; }
        public class CacheDTO
        {
            public string Schedule { get; set; }
        }

        public class StateDTO
        {
            public bool Open { get; set; }
        }

        public class LocationDTO
        {
            public string Address { get; set; }
            public float Lat { get; set; }
            public float Lon { get; set; }
        }

        public class SpacefedDTO
        {
            public bool Spacenet { get; set; }
            public bool Spacesaml { get; set; }
            public bool Spacephone { get; set; }
        }

        public class ContactDTO
        {
            public string Twitter { get; set; }
            public string Email { get; set; }
            public string Irc { get; set; }
            public string Ml { get; set; }
        }
    }

    
}