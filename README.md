![Space API logo](http://spaceapi.net/c/images/spaceapi-logo.png)

# SpaceAPI

[![API Build and Push](https://github.com/Brixel/SpaceAPI/actions/workflows/docker-image.yml/badge.svg?branch=master)](https://github.com/Brixel/SpaceAPI/actions/workflows/docker-image.yml)

The Space API provides information related to the current state of Hackerspace Brixel. Next to useful information regarding location, ways of getting on touch with us it also provides the 'Open' state telling you if the space is open.

## Space API Versions

The space api is using a JSON schema.
The current version is described in the "api" property of the json schema.

To convert the JSON schema into C# classes, we can use `quicktype`, a tool allowing to convert a JSON schema into many other languages.

### Running quicktype to generate newest version of the JSON schema

1. Install quicktype: `npm install quicktype`
2. Generate the SpaceAPI.cs file `quicktype -s schema https://raw.githubusercontent.com/SpaceApi/schema/master/14.json -o SpaceAPI.cs`
3. Review the SpaceAPI.cs file and rerun if changes are needed
4. Copy SpaceAPI.cs to

## Example

```json
{
  "api": "0.13",
  "space": "Brixel",
  "logo": "https://wiki.brixel.be/images/Brixel_Logo.png",
  "url": "http://brixel.be",
  "location": {
    "address": "Spalbeekstraat 34, 3510 Spalbeek, Belgium",
    "lon": 5.230583,
    "lat": 50.9509964
  },
  "spacefed": {
    "spacenet": false,
    "spacesaml": false,
    "spacephone": false
  },
  "contact": {
    "twitter": "@hs_hasselt",
    "email": "info@brixel.be",
    "irc": "irc://irc.freenode.net/brixel",
    "ml": "brixel-public@discuss.brixel.be"
  },
  "issue_report_channels": ["email"],
  "state": {
    "open": true
  },
  "projects": ["https://wiki.brixel.be/w/Category:Projects"],
  "cache": {
    "schedule": "h.01"
  }
}
```
