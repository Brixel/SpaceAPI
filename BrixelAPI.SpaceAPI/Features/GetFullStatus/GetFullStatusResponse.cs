﻿using System.Linq;
using Schema.v14;

namespace BrixelAPI.SpaceState.Features.GetFullStatus
{
    public class GetFullStatusResponse : SpaceApi
    {
        public GetFullStatusResponse(Domain.SpaceStateAggregate.SpaceState spaceState)
        {
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
                Twitter = spaceState.Contact.Twitter,
                Foursquare = spaceState.Contact.Foursquare,
                Facebook = spaceState.Contact.Facebook,
                Mastodon = spaceState.Contact.Mastodon
            };
            State = new State()
            {
                Open = spaceState.State.Open,
                Lastchange = spaceState.State.Lastchange
            };
            Projects = spaceState.Projects.ToArray();

        }
    }


}