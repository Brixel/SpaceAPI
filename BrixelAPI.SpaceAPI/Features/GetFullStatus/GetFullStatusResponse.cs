using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Brixel.Schema;

namespace BrixelAPI.SpaceState.Features.GetFullStatus
{
    public class GetFullStatusResponse : SpaceApi
    {
        public GetFullStatusResponse(Domain.SpaceStateAggregate.SpaceApi spaceState)
        {
            ApiCompatibility = spaceState.ApiCompatibility;
            Space = spaceState.Space;
            Logo = spaceState.Logo;
            Url = spaceState.Url;
            Location = new Location()
            {
                Address = spaceState.Location.Address,
                Lat = spaceState.Location.Lat,
                Lon = spaceState.Location.Lon
            };
            Spacefed = new Spacefed()
            {
                Spacenet = spaceState.Spacefed.Spacenet,
                Spacesaml = spaceState.Spacefed.Spacesaml
            };
            Contact = new Contact()
            {
                Email = spaceState.Contact.Email,
                Irc = spaceState.Contact.Irc,
                Ml = spaceState.Contact.Ml,
                Twitter = spaceState.Contact.Twitter
            };
            State = new State()
            {
                Open = spaceState.State.Open
            };
            Projects = spaceState.Projects.ToArray();

        }
    }

    
}