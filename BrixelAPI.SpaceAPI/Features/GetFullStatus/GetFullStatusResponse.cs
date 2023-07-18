﻿using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using BrixelAPI.SpaceState.Schema;

namespace BrixelAPI.SpaceState.Features.GetFullStatus
{
    public class GetFullStatusResponse : SpaceApi
    {
        public GetFullStatusResponse(Domain.SpaceStateAggregate.SpaceState spaceState)
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