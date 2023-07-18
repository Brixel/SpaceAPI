﻿using System.Collections.Generic;
using BrixelAPI.SpaceState.Schema;

namespace BrixelAPI.SpaceState.Domain.SpaceStateAggregate;

/// <summary>
/// SpaceAPI v14
/// </summary>
public class SpaceState : SpaceApi
{
   
    public void ChangeState(in bool isOpen)
    {
        State.Open = isOpen;
    }

    public static SpaceState GetConfiguredSpaceAPI()
    {
        return new SpaceState()
        {
            ApiCompatibility = new[] { "0.14" },
            Space = "Brixel",
            Logo = "https://wiki.brixel.be/images/Brixel_Logo.png",
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
                Spacesaml = false,
            },
            Contact = new Contact
            {
                Email = "info@brixel.be",
                Twitter = "@hs_hasselt",
                Facebook = "https://facebook.com/Brixel.Hasselt",
                Mastodon = "@brixel@mastodon.social",
                Foursquare = "https://foursquare.com/v/hackerspace-brixel/54284e28498e0b0d254fa426"
            },
            Projects = new List<string>()
            {
                "https://www.brixel.be/projecten/"
            }.ToArray(),
            State = new State()
            {
                Open = false,
            }
        };
    }
}