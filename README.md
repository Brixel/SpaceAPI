![Space API logo](http://spaceapi.net/c/images/spaceapi-logo.png)
# SpaceAPI
[![Build Status](https://travis-ci.org/Brixel/SpaceAPI.svg?branch=develop)](https://travis-ci.org/Brixel/SpaceAPI)

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
    },
    "issue_report_channels": [
        "email"
    ],
    "state": {
        "open": true
    },
    "projects": [
        "https://wiki.brixel.be/w/Category:Projects"
    ],
    "cache": {
        "schedule": "h.01"
    }
}
```
