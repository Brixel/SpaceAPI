![Space API logo](http://spaceapi.net/c/images/spaceapi-logo.png)

# SpaceAPI

[![Build Status](https://dev.azure.com/Brixel/Brixel.SpaceAPI/_apis/build/status/Brixel.SpaceAPI?branchName=refs%2Fpull%2F36%2Fmerge)](https://dev.azure.com/Brixel/Brixel.SpaceAPI/_build/latest?definitionId=1&branchName=refs%2Fpull%2F36%2Fmerge)

[![Deployment status](https://vsrm.dev.azure.com/Brixel/_apis/public/Release/badge/2c5ed952-6945-473d-a743-5856cc65e56e/1/1)](https://status.brixel.space/api/brixel/spaceapi)

The Space API provides information related to the current state of Hackerspace Brixel. Next to useful information regarding location, ways of getting on touch with us it also provides the 'Open' state telling you if the space is open.

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
