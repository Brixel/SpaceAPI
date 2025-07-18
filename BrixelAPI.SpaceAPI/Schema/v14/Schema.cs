﻿using System;


using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

namespace Schema.v14
{
    /// <summary>
    /// SpaceAPI v14
    /// </summary>
    public class SpaceApi
    {
        /// <summary>
        /// The versions your SpaceAPI endpoint supports
        /// </summary>
        [JsonPropertyName("api_compatibility")]
        public string[] ApiCompatibility => ["14"];

        /// <summary>
        /// URL(s) of webcams in your space
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("cam")]
        public string[] Cam { get; set; }

        /// <summary>
        /// Contact information about your space
        /// </summary>
        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }

        /// <summary>
        /// Events which happened recently in your space and which could be interesting to the
        /// public, like 'User X has entered/triggered/did something at timestamp Z'
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("events")]
        public Event[] Events { get; set; }

        /// <summary>
        /// Feeds where users can get updates of your space
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("feeds")]
        public Feeds Feeds { get; set; }

        /// <summary>
        /// Arbitrary links that you'd like to share
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("links")]
        public Link[] Links { get; set; }

        /// <summary>
        /// Position data such as a postal address or geographic coordinates
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; set; }

        /// <summary>
        /// URL to your space logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// A list of the different membership plans your hackerspace might have. Set the value
        /// according to your billing process. For example, if your membership fee is 10€ per month,
        /// but you bill it yearly (aka. the member pays the fee once per year), set the amount to
        /// 120 an the billing_interval to yearly.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("membership_plans")]
        public MembershipPlan[] MembershipPlans { get; set; }

        /// <summary>
        /// Your project sites (links to GitHub, wikis or wherever your projects are hosted)
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("projects")]
        public string[] Projects { get; set; }

        /// <summary>
        /// Data of various sensors in your space (e.g. temperature, humidity, amount of Club-Mate
        /// left, …). The only canonical property is the <em>temp</em> property, additional sensor
        /// types may be defined by you. In this case, you are requested to share your definition for
        /// inclusion in this specification.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sensors")]
        public Sensors Sensors { get; set; }

        /// <summary>
        /// The name of your space
        /// </summary>
        [JsonPropertyName("space")]
        public string Space { get; set; }

        /// <summary>
        /// A flag indicating if the hackerspace uses SpaceFED, a federated login scheme so that
        /// visiting hackers can use the space WiFi with their home space credentials.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("spacefed")]
        public Spacefed Spacefed { get; set; }

        /// <summary>
        /// A collection of status-related data: actual open/closed status, icons, last change
        /// timestamp etc.
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("state")]
        public State State { get; set; }

        /// <summary>
        /// URL to your space website
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}

/// <summary>
/// Contact information about your space
/// </summary>
public partial class Contact
{
    /// <summary>
    /// E-mail address for contacting your space. If this is a mailing list consider to use the
    /// contact/ml field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Facebook account URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facebook")]
    public string Facebook { get; set; }

    /// <summary>
    /// Foursquare ID, in the form <samp>4d8a9114d85f3704eab301dc</samp>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("foursquare")]
    public string Foursquare { get; set; }

    /// <summary>
    /// A URL to find information about the Space in the Gopherspace
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gopher")]
    public string Gopher { get; set; }

    /// <summary>
    /// Identi.ca or StatusNet account, in the form <samp>yourspace@example.org</samp>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identica")]
    public string Identica { get; set; }

    /// <summary>
    /// URL of the IRC channel
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("irc")]
    public string Irc { get; set; }

    /// <summary>
    /// A separate email address for issue reports. This value can be Base64-encoded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issue_mail")]
    public string IssueMail { get; set; }

    /// <summary>
    /// Persons who carry a key and are able to open the space upon request. One of the fields
    /// irc_nick, phone, email or twitter must be specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("keymasters")]
    public Keymaster[] Keymasters { get; set; }

    /// <summary>
    /// Mastodon username
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mastodon")]
    public string Mastodon { get; set; }

    /// <summary>
    /// Matrix channel/community for the Hackerspace
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("matrix")]
    public string Matrix { get; set; }

    /// <summary>
    /// The e-mail address of your mailing list. If you use Google Groups then the e-mail looks
    /// like <samp>your-group@googlegroups.com</samp>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ml")]
    public string Ml { get; set; }

    /// <summary>
    /// URL to a Mumble server/channel, as specified in https://wiki.mumble.info/wiki/Mumble_URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mumble")]
    public string Mumble { get; set; }

    /// <summary>
    /// Phone number, including country code with a leading plus sign
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// URI for Voice-over-IP via SIP
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sip")]
    public string Sip { get; set; }

    /// <summary>
    /// Twitter username with leading <code>@</code>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("twitter")]
    public string Twitter { get; set; }

    /// <summary>
    /// A public Jabber/XMPP multi-user chatroom in the form
    /// <samp>chatroom@conference.example.net</samp>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("xmpp")]
    public string Xmpp { get; set; }
}

public partial class Keymaster
{
    /// <summary>
    /// Email address which can be base64 encoded
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Contact the person with this nickname directly in irc if available. The irc channel to be
    /// used is defined in the contact/irc field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("irc_nick")]
    public string IrcNick { get; set; }

    /// <summary>
    /// Mastodon username
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mastodon")]
    public string Mastodon { get; set; }

    /// <summary>
    /// Matrix username (including domain)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("matrix")]
    public string Matrix { get; set; }

    /// <summary>
    /// Real name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Phone number, including country code with a leading plus sign
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Twitter username with leading <code>@</code>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("twitter")]
    public string Twitter { get; set; }

    /// <summary>
    /// XMPP (Jabber) ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("xmpp")]
    public string Xmpp { get; set; }
}

public partial class Event
{
    /// <summary>
    /// A custom text field to give more information about the event
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extra")]
    public string Extra { get; set; }

    /// <summary>
    /// Name or other identity of the subject (e.g. <samp>J. Random Hacker</samp>,
    /// <samp>fridge</samp>, <samp>3D printer</samp>, …)
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Unix timestamp when the event occurred
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Action (e.g. <samp>check-in</samp>, <samp>check-out</samp>, <samp>finish-print</samp>,
    /// …). Define your own actions and use them consistently, canonical actions are not (yet)
    /// specified
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>
/// Feeds where users can get updates of your space
/// </summary>
public partial class Feeds
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("blog")]
    public Blog Blog { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("calendar")]
    public Calendar Calendar { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flickr")]
    public Flickr Flickr { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wiki")]
    public Wiki Wiki { get; set; }
}

public partial class Blog
{
    /// <summary>
    /// Type of the feed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Feed URL
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

public partial class Calendar
{
    /// <summary>
    /// Type of the feed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Feed URL
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

public partial class Flickr
{
    /// <summary>
    /// Type of the feed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Feed URL
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

public partial class Wiki
{
    /// <summary>
    /// Type of the feed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Feed URL
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

public partial class Link
{
    /// <summary>
    /// An extra field for a more detailed description of the link
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The link name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The URL
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary>
/// Position data such as a postal address or geographic coordinates
/// </summary>
public partial class Location
{
    /// <summary>
    /// The postal address of your space (street, block, housenumber, zip code, city, whatever
    /// you usually need in your country, and the country itself).<br>Examples: <ul><li>Netzladen
    /// e.V., Breite Straße 74, 53111 Bonn, Germany</li></ul>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public string Address { get; set; }

    /// <summary>
    /// Latitude of your space location, in degree with decimal places. Use positive values for
    /// locations north of the equator, negative values for locations south of equator.
    /// </summary>
    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    /// <summary>
    /// Longitude of your space location, in degree with decimal places. Use positive values for
    /// locations east of Greenwich, and negative values for locations west of Greenwich.
    /// </summary>
    [JsonPropertyName("lon")]
    public double Lon { get; set; }

    /// <summary>
    /// The timezone the space is located in. It should be formatted according to the <a
    /// target="_blank" href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">TZ
    /// database location names</a>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }
}

public partial class MembershipPlan
{
    /// <summary>
    /// How often is the membership billed? If you select other, please specify in the
    /// description what your billing interval is.
    /// </summary>
    [JsonPropertyName("billing_interval")]
    public BillingInterval BillingInterval { get; set; }

    /// <summary>
    /// What's the currency? It should be formatted according to <a
    /// href="https://en.wikipedia.org/wiki/ISO_4217" target="_blank">ISO 4217</a> short-code
    /// format.
    /// </summary>
    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// A free form string
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The name of the membership plan
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// How much does this plan cost?
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

/// <summary>
/// Data of various sensors in your space (e.g. temperature, humidity, amount of Club-Mate
/// left, …). The only canonical property is the <em>temp</em> property, additional sensor
/// types may be defined by you. In this case, you are requested to share your definition for
/// inclusion in this specification.
/// </summary>
public partial class Sensors
{
    /// <summary>
    /// How rich is your hackerspace?
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_balance")]
    public AccountBalance[] AccountBalance { get; set; }

    /// <summary>
    /// Barometer sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("barometer")]
    public Barometer[] Barometer { get; set; }

    /// <summary>
    /// How much Mate and beer is in your fridge?
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beverage_supply")]
    public BeverageSupply[] BeverageSupply { get; set; }

    /// <summary>
    /// Sensor type to indicate if a certain door is locked
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("door_locked")]
    public DoorLocked[] DoorLocked { get; set; }

    /// <summary>
    /// Humidity sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("humidity")]
    public Humidity[] Humidity { get; set; }

    /// <summary>
    /// This sensor type is to specify the currently active ethernet or wireless network devices.
    /// You can create different instances for each network type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network_connections")]
    public NetworkConnection[] NetworkConnections { get; set; }

    /// <summary>
    /// The current network traffic, in bits/second or packets/second (or both)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network_traffic")]
    public NetworkTraffic[] NetworkTraffic { get; set; }

    /// <summary>
    /// Specify the number of people that are currently in your space. Optionally you can define
    /// a list of names.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("people_now_present")]
    public PeopleNowPresent[] PeopleNowPresent { get; set; }

    /// <summary>
    /// The power consumption of a specific device or of your whole space
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("power_consumption")]
    public PowerConsumption[] PowerConsumption { get; set; }

    /// <summary>
    /// Compound radiation sensor. Check this <a rel="nofollow"
    /// href="https://sites.google.com/site/diygeigercounter/technical/gm-tubes-supported"
    /// target="_blank">resource</a>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("radiation")]
    public Radiation Radiation { get; set; }

    /// <summary>
    /// Temperature sensor. To convert from one unit of temperature to another consider <a
    /// href="http://en.wikipedia.org/wiki/Temperature_conversion_formulas"
    /// target="_blank">Wikipedia</a>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("temperature")]
    public Temperature[] Temperature { get; set; }

    /// <summary>
    /// Specify the number of space members.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_member_count")]
    public TotalMemberCount[] TotalMemberCount { get; set; }

    /// <summary>
    /// Your wind sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wind")]
    public Wind[] Wind { get; set; }
}

public partial class AccountBalance
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// If you have more than one account you can use this field to specify where it is.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// Give your sensor instance a name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// What's the currency? It should be formatted according to <a
    /// href="https://en.wikipedia.org/wiki/ISO_4217" target="_blank">ISO 4217</a> short-code
    /// format.
    /// </summary>
    [JsonPropertyName("unit")]
    public string Unit { get; set; }

    /// <summary>
    /// How much?
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class Barometer
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The unit of pressure used by your sensor<br>Note: The <code>hPA</code> unit is deprecated
    /// and should not be used anymore. Use the correct <code>hPa</code> unit instead.
    /// </summary>
    [JsonPropertyName("unit")]
    public BarometerUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class BeverageSupply
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The unit, either <samp>btl</samp> for bottles or <samp>crt</samp> for crates
    /// </summary>
    [JsonPropertyName("unit")]
    public BeverageSupplyUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class DoorLocked
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public bool Value { get; set; }
}

public partial class Humidity
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonPropertyName("unit")]
    public HumidityUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class NetworkConnection
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// The machines that are currently connected with the network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("machines")]
    public Machine[] Machines { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// This field is optional but you can use it to the network type such as <samp>wifi</samp>
    /// or <samp>cable</samp>. You can even expose the number of <a
    /// href="https://spacefed.net/wiki/index.php/Spacenet"
    /// target="_blank">spacenet</a>-authenticated connections.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// The amount of network connections.
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class Machine
{
    /// <summary>
    /// The machine's MAC address of the format <samp>D3:3A:DB:EE:FF:00</samp>.
    /// </summary>
    [JsonPropertyName("mac")]
    public string Mac { get; set; }

    /// <summary>
    /// The machine name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class NetworkTraffic
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Location the measurement relates to, e.g. <samp>WiFi</samp> or <samp>Uplink</samp>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// Name of the measurement, e.g. to distinguish between upstream and downstream traffic
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("properties")]
    public NetworkTrafficProperties Properties { get; set; }
}

public partial class NetworkTrafficProperties
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bits_per_second")]
    public BitsPerSecond BitsPerSecond { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("packets_per_second")]
    public PacketsPerSecond PacketsPerSecond { get; set; }
}

public partial class BitsPerSecond
{
    /// <summary>
    /// The maximum available throughput in bits/second, e.g. as sold by your ISP
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maximum")]
    [JsonConverter(typeof(MinMaxValueCheckConverter))]
    public double? Maximum { get; set; }

    /// <summary>
    /// The measurement value, in bits/second
    /// </summary>
    [JsonPropertyName("value")]
    [JsonConverter(typeof(MinMaxValueCheckConverter))]
    public double Value { get; set; }
}

public partial class PacketsPerSecond
{
    /// <summary>
    /// The measurement value, in packets/second
    /// </summary>
    [JsonPropertyName("value")]
    [JsonConverter(typeof(MinMaxValueCheckConverter))]
    public double Value { get; set; }
}

public partial class PeopleNowPresent
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// If you use multiple sensor instances for different rooms, use this field to indicate the
    /// location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// Give this sensor a name if necessary at all. Use the location field for the rooms. This
    /// field is not intended to be used for names of hackerspace members. Use the field 'names'
    /// instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// List of hackerspace members that are currently occupying the space.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("names")]
    public string[] Names { get; set; }

    /// <summary>
    /// The amount of present people.
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class PowerConsumption
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonPropertyName("unit")]
    public PowerConsumptionUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

/// <summary>
/// Compound radiation sensor. Check this <a rel="nofollow"
/// href="https://sites.google.com/site/diygeigercounter/technical/gm-tubes-supported"
/// target="_blank">resource</a>.
/// </summary>
public partial class Radiation
{
    /// <summary>
    /// An alpha sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alpha")]
    public Alpha[] Alpha { get; set; }

    /// <summary>
    /// A beta sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beta")]
    public Beta[] Beta { get; set; }

    /// <summary>
    /// A sensor which cannot filter beta and gamma radiation separately.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beta_gamma")]
    public BetaGamma[] BetaGamma { get; set; }

    /// <summary>
    /// A gamma sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gamma")]
    public Gamma[] Gamma { get; set; }
}

public partial class Alpha
{
    /// <summary>
    /// The conversion from the <em>cpm</em> unit to another unit hardly depends on your tube
    /// type. See the description of the value field to see how to use the conversion factor.
    /// <strong>Note:</strong> only trust your manufacturer if it comes to the actual factor
    /// value. The internet seems <a rel="nofollow"
    /// href="http://sapporohibaku.wordpress.com/2011/10/15/conversion-factor/"
    /// target="_blank">full of wrong copy & pastes</a>, don't even trust your neighbour
    /// hackerspace. If in doubt ask the tube manufacturer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conversion_factor")]
    public double? ConversionFactor { get; set; }

    /// <summary>
    /// The dead time in µs. See the description of the value field to see how to use the dead
    /// time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dead_time")]
    public double? DeadTime { get; set; }

    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Choose the appropriate unit for your radiation sensor instance
    /// </summary>
    [JsonPropertyName("unit")]
    public AlphaUnit Unit { get; set; }

    /// <summary>
    /// Observed counts per minute (ocpm) or actual radiation value. If the value are the
    /// observed counts then the dead_time and conversion_factor fields must be defined as well.
    /// CPM formula: <div>cpm = ocpm ( 1 + 1 / (1 - ocpm x dead_time) )</div> Conversion formula:
    /// <div>µSv/h = cpm x conversion_factor</div>
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class Beta
{
    /// <summary>
    /// The conversion from the <em>cpm</em> unit to another unit hardly depends on your tube
    /// type. See the description of the value field to see how to use the conversion factor.
    /// <strong>Note:</strong> only trust your manufacturer if it comes to the actual factor
    /// value. The internet seems <a rel="nofollow"
    /// href="http://sapporohibaku.wordpress.com/2011/10/15/conversion-factor/"
    /// target="_blank">full of wrong copy & pastes</a>, don't even trust your neighbour
    /// hackerspace. If in doubt ask the tube manufacturer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conversion_factor")]
    public double? ConversionFactor { get; set; }

    /// <summary>
    /// The dead time in µs. See the description of the value field to see how to use the dead
    /// time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dead_time")]
    public double? DeadTime { get; set; }

    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Choose the appropriate unit for your radiation sensor instance
    /// </summary>
    [JsonPropertyName("unit")]
    public AlphaUnit Unit { get; set; }

    /// <summary>
    /// Observed counts per minute (ocpm) or actual radiation value. If the value are the
    /// observed counts then the dead_time and conversion_factor fields must be defined as well.
    /// CPM formula: <div>cpm = ocpm ( 1 + 1 / (1 - ocpm x dead_time) )</div> Conversion formula:
    /// <div>µSv/h = cpm x conversion_factor</div>
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class BetaGamma
{
    /// <summary>
    /// The conversion from the <em>cpm</em> unit to another unit hardly depends on your tube
    /// type. See the description of the value field to see how to use the conversion factor.
    /// <strong>Note:</strong> only trust your manufacturer if it comes to the actual factor
    /// value. The internet seems <a rel="nofollow"
    /// href="http://sapporohibaku.wordpress.com/2011/10/15/conversion-factor/"
    /// target="_blank">full of wrong copy & pastes</a>, don't even trust your neighbour
    /// hackerspace. If in doubt ask the tube manufacturer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conversion_factor")]
    public double? ConversionFactor { get; set; }

    /// <summary>
    /// The dead time in µs. See the description of the value field to see how to use the dead
    /// time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dead_time")]
    public double? DeadTime { get; set; }

    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Choose the appropriate unit for your radiation sensor instance
    /// </summary>
    [JsonPropertyName("unit")]
    public AlphaUnit Unit { get; set; }

    /// <summary>
    /// Observed counts per minute (ocpm) or actual radiation value. If the value are the
    /// observed counts then the dead_time and conversion_factor fields must be defined as well.
    /// CPM formula: <div>cpm = ocpm ( 1 + 1 / (1 - ocpm x dead_time) )</div> Conversion formula:
    /// <div>µSv/h = cpm x conversion_factor</div>
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class Gamma
{
    /// <summary>
    /// The conversion from the <em>cpm</em> unit to another unit hardly depends on your tube
    /// type. See the description of the value field to see how to use the conversion factor.
    /// <strong>Note:</strong> only trust your manufacturer if it comes to the actual factor
    /// value. The internet seems <a rel="nofollow"
    /// href="http://sapporohibaku.wordpress.com/2011/10/15/conversion-factor/"
    /// target="_blank">full of wrong copy & pastes</a>, don't even trust your neighbour
    /// hackerspace. If in doubt ask the tube manufacturer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conversion_factor")]
    public double? ConversionFactor { get; set; }

    /// <summary>
    /// The dead time in µs. See the description of the value field to see how to use the dead
    /// time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dead_time")]
    public double? DeadTime { get; set; }

    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Choose the appropriate unit for your radiation sensor instance
    /// </summary>
    [JsonPropertyName("unit")]
    public AlphaUnit Unit { get; set; }

    /// <summary>
    /// Observed counts per minute (ocpm) or actual radiation value. If the value are the
    /// observed counts then the dead_time and conversion_factor fields must be defined as well.
    /// CPM formula: <div>cpm = ocpm ( 1 + 1 / (1 - ocpm x dead_time) )</div> Conversion formula:
    /// <div>µSv/h = cpm x conversion_factor</div>
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class Temperature
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The unit of the sensor value
    /// </summary>
    [JsonPropertyName("unit")]
    public TemperatureUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class TotalMemberCount
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Specify the location if your hackerspace has different departments (for whatever reason).
    /// This field is for one department. Every department should have its own sensor instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// You can use this field to specify if this sensor instance counts active or inactive
    /// members.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The amount of your space members.
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class Wind
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("properties")]
    public WindProperties Properties { get; set; }
}

public partial class WindProperties
{
    /// <summary>
    /// The wind direction in degrees
    /// </summary>
    [JsonPropertyName("direction")]
    public Direction Direction { get; set; }

    /// <summary>
    /// Height above mean sea level
    /// </summary>
    [JsonPropertyName("elevation")]
    public Elevation Elevation { get; set; }

    [JsonPropertyName("gust")]
    public Gust Gust { get; set; }

    [JsonPropertyName("speed")]
    public Speed Speed { get; set; }
}

/// <summary>
/// The wind direction in degrees
/// </summary>
public partial class Direction
{
    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonPropertyName("unit")]
    public DirectionUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

/// <summary>
/// Height above mean sea level
/// </summary>
public partial class Elevation
{
    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonPropertyName("unit")]
    public ElevationUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class Gust
{
    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonPropertyName("unit")]
    public GustUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

public partial class Speed
{
    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonPropertyName("unit")]
    public GustUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonPropertyName("value")]
    public double Value { get; set; }
}

/// <summary>
/// A flag indicating if the hackerspace uses SpaceFED, a federated login scheme so that
/// visiting hackers can use the space WiFi with their home space credentials.
/// </summary>
public partial class Spacefed
{
    /// <summary>
    /// See the <a target="_blank"
    /// href="https://spacefed.net/index.php/Category:Howto/Spacenet">wiki</a>.
    /// </summary>
    [JsonPropertyName("spacenet")]
    public bool Spacenet { get; set; }

    /// <summary>
    /// See the <a target="_blank" href="https://spacefed.net/index.php?title=Spacesaml">wiki</a>.
    /// </summary>
    [JsonPropertyName("spacesaml")]
    public bool Spacesaml { get; set; }
}

/// <summary>
/// A collection of status-related data: actual open/closed status, icons, last change
/// timestamp etc.
/// </summary>
public partial class State
{
    /// <summary>
    /// Icons that show the status graphically
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("icon")]
    public Icon Icon { get; set; }

    /// <summary>
    /// The Unix timestamp when the space status changed most recently
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastchange")]
    public double? Lastchange { get; set; }

    /// <summary>
    /// An additional free-form string, could be something like <samp>'open for public'</samp>,
    /// <samp>'members only'</samp> or whatever you want it to be
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// A flag which indicates whether the space is currently open or closed. The state
    /// 'undefined' can be achieved by omitting this field. A missing 'open' property carries the
    /// semantics of a temporary unavailability of the state, whereas the absence of the 'state'
    /// property itself means the state is generally not implemented for this space. This field
    /// is also allowed to explicitly have the value null for backwards compatibility with older
    /// schema versions, but this is deprecated and will be removed in a future version.
    /// </summary>
    [JsonPropertyName("open")]
    public bool? Open { get; set; }

    /// <summary>
    /// The person who lastly changed the state e.g. opened or closed the space
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trigger_person")]
    public string TriggerPerson { get; set; }
}

/// <summary>
/// Icons that show the status graphically
/// </summary>
public partial class Icon
{
    /// <summary>
    /// The URL to your customized space logo showing a closed space
    /// </summary>
    [JsonPropertyName("closed")]
    public string Closed { get; set; }

    /// <summary>
    /// The URL to your customized space logo showing an open space
    /// </summary>
    [JsonPropertyName("open")]
    public string Open { get; set; }
}

/// <summary>
/// How often is the membership billed? If you select other, please specify in the
/// description what your billing interval is.
/// </summary>
public enum BillingInterval { Daily, Hourly, Monthly, Other, Weekly, Yearly };

/// <summary>
/// The unit of pressure used by your sensor<br>Note: The <code>hPA</code> unit is deprecated
/// and should not be used anymore. Use the correct <code>hPa</code> unit instead.
/// </summary>
public enum BarometerUnit { HPa, UnitHPa };

/// <summary>
/// The unit, either <samp>btl</samp> for bottles or <samp>crt</samp> for crates
/// </summary>
public enum BeverageSupplyUnit { Btl, Crt };

/// <summary>
/// The unit of the sensor value. You should always define the unit though if the sensor is a
/// flag of a boolean type then you can of course omit it.
/// </summary>
public enum HumidityUnit { Empty };

/// <summary>
/// This field is optional but you can use it to the network type such as <samp>wifi</samp>
/// or <samp>cable</samp>. You can even expose the number of <a
/// href="https://spacefed.net/wiki/index.php/Spacenet"
/// target="_blank">spacenet</a>-authenticated connections.
/// </summary>
public enum TypeEnum { Cable, Spacenet, Wifi };

/// <summary>
/// The unit of the sensor value. You should always define the unit though if the sensor is a
/// flag of a boolean type then you can of course omit it.
/// </summary>
public enum PowerConsumptionUnit { MW, Va, W };

/// <summary>
/// Choose the appropriate unit for your radiation sensor instance
/// </summary>
public enum AlphaUnit { Cpm, MSvA, RH, ΜSvA, ΜSvH };

/// <summary>
/// The unit of the sensor value
/// </summary>
public enum TemperatureUnit { C, De, F, K, N, R, Ré, Rø };

/// <summary>
/// The unit of the sensor value. You should always define the unit though if the sensor is a
/// flag of a boolean type then you can of course omit it.
/// </summary>
public enum DirectionUnit { Empty };

/// <summary>
/// The unit of the sensor value. You should always define the unit though if the sensor is a
/// flag of a boolean type then you can of course omit it.
/// </summary>
public enum ElevationUnit { M };

/// <summary>
/// The unit of the sensor value. You should always define the unit though if the sensor is a
/// flag of a boolean type then you can of course omit it.
/// </summary>
public enum GustUnit { KmH, Kn, MS };

public partial class Coordinate
{
    public static Coordinate FromJson(string json) => JsonSerializer.Deserialize<Coordinate>(json, Converter.Settings);
}

public static class Serialize
{
    public static string ToJson(this Coordinate self) => JsonSerializer.Serialize(self, Converter.Settings);
}

internal static class Converter
{
    public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
    {
        Converters =
        {
            BillingIntervalConverter.Singleton,
            BarometerUnitConverter.Singleton,
            BeverageSupplyUnitConverter.Singleton,
            HumidityUnitConverter.Singleton,
            TypeEnumConverter.Singleton,
            PowerConsumptionUnitConverter.Singleton,
            AlphaUnitConverter.Singleton,
            TemperatureUnitConverter.Singleton,
            DirectionUnitConverter.Singleton,
            ElevationUnitConverter.Singleton,
            GustUnitConverter.Singleton,
            new DateOnlyConverter(),
            new TimeOnlyConverter(),
            IsoDateTimeOffsetConverter.Singleton
        },
    };
}

internal class BillingIntervalConverter : JsonConverter<BillingInterval>
{
    public override bool CanConvert(Type t) => t == typeof(BillingInterval);

    public override BillingInterval Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        switch (value)
        {
            case "daily":
                return BillingInterval.Daily;
            case "hourly":
                return BillingInterval.Hourly;
            case "monthly":
                return BillingInterval.Monthly;
            case "other":
                return BillingInterval.Other;
            case "weekly":
                return BillingInterval.Weekly;
            case "yearly":
                return BillingInterval.Yearly;
        }
        throw new Exception("Cannot unmarshal type BillingInterval");
    }

    public override void Write(Utf8JsonWriter writer, BillingInterval value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case BillingInterval.Daily:
                JsonSerializer.Serialize(writer, "daily", options);
                return;
            case BillingInterval.Hourly:
                JsonSerializer.Serialize(writer, "hourly", options);
                return;
            case BillingInterval.Monthly:
                JsonSerializer.Serialize(writer, "monthly", options);
                return;
            case BillingInterval.Other:
                JsonSerializer.Serialize(writer, "other", options);
                return;
            case BillingInterval.Weekly:
                JsonSerializer.Serialize(writer, "weekly", options);
                return;
            case BillingInterval.Yearly:
                JsonSerializer.Serialize(writer, "yearly", options);
                return;
        }
        throw new Exception("Cannot marshal type BillingInterval");
    }

    public static readonly BillingIntervalConverter Singleton = new BillingIntervalConverter();
}

internal class BarometerUnitConverter : JsonConverter<BarometerUnit>
{
    public override bool CanConvert(Type t) => t == typeof(BarometerUnit);

    public override BarometerUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        switch (value)
        {
            case "hPA":
                return BarometerUnit.UnitHPa;
            case "hPa":
                return BarometerUnit.HPa;
        }
        throw new Exception("Cannot unmarshal type BarometerUnit");
    }

    public override void Write(Utf8JsonWriter writer, BarometerUnit value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case BarometerUnit.UnitHPa:
                JsonSerializer.Serialize(writer, "hPA", options);
                return;
            case BarometerUnit.HPa:
                JsonSerializer.Serialize(writer, "hPa", options);
                return;
        }
        throw new Exception("Cannot marshal type BarometerUnit");
    }

    public static readonly BarometerUnitConverter Singleton = new BarometerUnitConverter();
}

internal class BeverageSupplyUnitConverter : JsonConverter<BeverageSupplyUnit>
{
    public override bool CanConvert(Type t) => t == typeof(BeverageSupplyUnit);

    public override BeverageSupplyUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        switch (value)
        {
            case "btl":
                return BeverageSupplyUnit.Btl;
            case "crt":
                return BeverageSupplyUnit.Crt;
        }
        throw new Exception("Cannot unmarshal type BeverageSupplyUnit");
    }

    public override void Write(Utf8JsonWriter writer, BeverageSupplyUnit value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case BeverageSupplyUnit.Btl:
                JsonSerializer.Serialize(writer, "btl", options);
                return;
            case BeverageSupplyUnit.Crt:
                JsonSerializer.Serialize(writer, "crt", options);
                return;
        }
        throw new Exception("Cannot marshal type BeverageSupplyUnit");
    }

    public static readonly BeverageSupplyUnitConverter Singleton = new BeverageSupplyUnitConverter();
}

internal class HumidityUnitConverter : JsonConverter<HumidityUnit>
{
    public override bool CanConvert(Type t) => t == typeof(HumidityUnit);

    public override HumidityUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value == "%")
        {
            return HumidityUnit.Empty;
        }
        throw new Exception("Cannot unmarshal type HumidityUnit");
    }

    public override void Write(Utf8JsonWriter writer, HumidityUnit value, JsonSerializerOptions options)
    {
        if (value == HumidityUnit.Empty)
        {
            JsonSerializer.Serialize(writer, "%", options);
            return;
        }
        throw new Exception("Cannot marshal type HumidityUnit");
    }

    public static readonly HumidityUnitConverter Singleton = new HumidityUnitConverter();
}

internal class TypeEnumConverter : JsonConverter<TypeEnum>
{
    public override bool CanConvert(Type t) => t == typeof(TypeEnum);

    public override TypeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        switch (value)
        {
            case "cable":
                return TypeEnum.Cable;
            case "spacenet":
                return TypeEnum.Spacenet;
            case "wifi":
                return TypeEnum.Wifi;
        }
        throw new Exception("Cannot unmarshal type TypeEnum");
    }

    public override void Write(Utf8JsonWriter writer, TypeEnum value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case TypeEnum.Cable:
                JsonSerializer.Serialize(writer, "cable", options);
                return;
            case TypeEnum.Spacenet:
                JsonSerializer.Serialize(writer, "spacenet", options);
                return;
            case TypeEnum.Wifi:
                JsonSerializer.Serialize(writer, "wifi", options);
                return;
        }
        throw new Exception("Cannot marshal type TypeEnum");
    }

    public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
}

internal class MinMaxValueCheckConverter : JsonConverter<double>
{
    public override bool CanConvert(Type t) => t == typeof(double);

    public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetDouble();
        if (value >= 0)
        {
            return value;
        }
        throw new Exception("Cannot unmarshal type double");
    }

    public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
    {
        if (value >= 0)
        {
            JsonSerializer.Serialize(writer, value, options);
            return;
        }
        throw new Exception("Cannot marshal type double");
    }

    public static readonly MinMaxValueCheckConverter Singleton = new MinMaxValueCheckConverter();
}

internal class PowerConsumptionUnitConverter : JsonConverter<PowerConsumptionUnit>
{
    public override bool CanConvert(Type t) => t == typeof(PowerConsumptionUnit);

    public override PowerConsumptionUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        switch (value)
        {
            case "VA":
                return PowerConsumptionUnit.Va;
            case "W":
                return PowerConsumptionUnit.W;
            case "mW":
                return PowerConsumptionUnit.MW;
        }
        throw new Exception("Cannot unmarshal type PowerConsumptionUnit");
    }

    public override void Write(Utf8JsonWriter writer, PowerConsumptionUnit value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case PowerConsumptionUnit.Va:
                JsonSerializer.Serialize(writer, "VA", options);
                return;
            case PowerConsumptionUnit.W:
                JsonSerializer.Serialize(writer, "W", options);
                return;
            case PowerConsumptionUnit.MW:
                JsonSerializer.Serialize(writer, "mW", options);
                return;
        }
        throw new Exception("Cannot marshal type PowerConsumptionUnit");
    }

    public static readonly PowerConsumptionUnitConverter Singleton = new PowerConsumptionUnitConverter();
}

internal class AlphaUnitConverter : JsonConverter<AlphaUnit>
{
    public override bool CanConvert(Type t) => t == typeof(AlphaUnit);

    public override AlphaUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        switch (value)
        {
            case "cpm":
                return AlphaUnit.Cpm;
            case "mSv/a":
                return AlphaUnit.MSvA;
            case "r/h":
                return AlphaUnit.RH;
            case "µSv/a":
                return AlphaUnit.ΜSvA;
            case "µSv/h":
                return AlphaUnit.ΜSvH;
        }
        throw new Exception("Cannot unmarshal type AlphaUnit");
    }

    public override void Write(Utf8JsonWriter writer, AlphaUnit value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case AlphaUnit.Cpm:
                JsonSerializer.Serialize(writer, "cpm", options);
                return;
            case AlphaUnit.MSvA:
                JsonSerializer.Serialize(writer, "mSv/a", options);
                return;
            case AlphaUnit.RH:
                JsonSerializer.Serialize(writer, "r/h", options);
                return;
            case AlphaUnit.ΜSvA:
                JsonSerializer.Serialize(writer, "µSv/a", options);
                return;
            case AlphaUnit.ΜSvH:
                JsonSerializer.Serialize(writer, "µSv/h", options);
                return;
        }
        throw new Exception("Cannot marshal type AlphaUnit");
    }

    public static readonly AlphaUnitConverter Singleton = new AlphaUnitConverter();
}

internal class TemperatureUnitConverter : JsonConverter<TemperatureUnit>
{
    public override bool CanConvert(Type t) => t == typeof(TemperatureUnit);

    public override TemperatureUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        switch (value)
        {
            case "K":
                return TemperatureUnit.K;
            case "°C":
                return TemperatureUnit.C;
            case "°De":
                return TemperatureUnit.De;
            case "°F":
                return TemperatureUnit.F;
            case "°N":
                return TemperatureUnit.N;
            case "°R":
                return TemperatureUnit.R;
            case "°Ré":
                return TemperatureUnit.Ré;
            case "°Rø":
                return TemperatureUnit.Rø;
        }
        throw new Exception("Cannot unmarshal type TemperatureUnit");
    }

    public override void Write(Utf8JsonWriter writer, TemperatureUnit value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case TemperatureUnit.K:
                JsonSerializer.Serialize(writer, "K", options);
                return;
            case TemperatureUnit.C:
                JsonSerializer.Serialize(writer, "°C", options);
                return;
            case TemperatureUnit.De:
                JsonSerializer.Serialize(writer, "°De", options);
                return;
            case TemperatureUnit.F:
                JsonSerializer.Serialize(writer, "°F", options);
                return;
            case TemperatureUnit.N:
                JsonSerializer.Serialize(writer, "°N", options);
                return;
            case TemperatureUnit.R:
                JsonSerializer.Serialize(writer, "°R", options);
                return;
            case TemperatureUnit.Ré:
                JsonSerializer.Serialize(writer, "°Ré", options);
                return;
            case TemperatureUnit.Rø:
                JsonSerializer.Serialize(writer, "°Rø", options);
                return;
        }
        throw new Exception("Cannot marshal type TemperatureUnit");
    }

    public static readonly TemperatureUnitConverter Singleton = new TemperatureUnitConverter();
}

internal class DirectionUnitConverter : JsonConverter<DirectionUnit>
{
    public override bool CanConvert(Type t) => t == typeof(DirectionUnit);

    public override DirectionUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value == "°")
        {
            return DirectionUnit.Empty;
        }
        throw new Exception("Cannot unmarshal type DirectionUnit");
    }

    public override void Write(Utf8JsonWriter writer, DirectionUnit value, JsonSerializerOptions options)
    {
        if (value == DirectionUnit.Empty)
        {
            JsonSerializer.Serialize(writer, "°", options);
            return;
        }
        throw new Exception("Cannot marshal type DirectionUnit");
    }

    public static readonly DirectionUnitConverter Singleton = new DirectionUnitConverter();
}

internal class ElevationUnitConverter : JsonConverter<ElevationUnit>
{
    public override bool CanConvert(Type t) => t == typeof(ElevationUnit);

    public override ElevationUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value == "m")
        {
            return ElevationUnit.M;
        }
        throw new Exception("Cannot unmarshal type ElevationUnit");
    }

    public override void Write(Utf8JsonWriter writer, ElevationUnit value, JsonSerializerOptions options)
    {
        if (value == ElevationUnit.M)
        {
            JsonSerializer.Serialize(writer, "m", options);
            return;
        }
        throw new Exception("Cannot marshal type ElevationUnit");
    }

    public static readonly ElevationUnitConverter Singleton = new ElevationUnitConverter();
}

internal class GustUnitConverter : JsonConverter<GustUnit>
{
    public override bool CanConvert(Type t) => t == typeof(GustUnit);

    public override GustUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        switch (value)
        {
            case "km/h":
                return GustUnit.KmH;
            case "kn":
                return GustUnit.Kn;
            case "m/s":
                return GustUnit.MS;
        }
        throw new Exception("Cannot unmarshal type GustUnit");
    }

    public override void Write(Utf8JsonWriter writer, GustUnit value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case GustUnit.KmH:
                JsonSerializer.Serialize(writer, "km/h", options);
                return;
            case GustUnit.Kn:
                JsonSerializer.Serialize(writer, "kn", options);
                return;
            case GustUnit.MS:
                JsonSerializer.Serialize(writer, "m/s", options);
                return;
        }
        throw new Exception("Cannot marshal type GustUnit");
    }

    public static readonly GustUnitConverter Singleton = new GustUnitConverter();
}

public class DateOnlyConverter : JsonConverter<DateOnly>
{
    private readonly string serializationFormat;
    public DateOnlyConverter() : this(null) { }

    public DateOnlyConverter(string? serializationFormat)
    {
        this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
    }

    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return DateOnly.Parse(value!);
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString(serializationFormat));
}

public class TimeOnlyConverter : JsonConverter<TimeOnly>
{
    private readonly string serializationFormat;

    public TimeOnlyConverter() : this(null) { }

    public TimeOnlyConverter(string? serializationFormat)
    {
        this.serializationFormat = serializationFormat ?? "HH:mm:ss.fff";
    }

    public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return TimeOnly.Parse(value!);
    }

    public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString(serializationFormat));
}

internal class IsoDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
    public override bool CanConvert(Type t) => t == typeof(DateTimeOffset);

    private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

    private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
    private string? _dateTimeFormat;
    private CultureInfo? _culture;

    public DateTimeStyles DateTimeStyles
    {
        get => _dateTimeStyles;
        set => _dateTimeStyles = value;
    }

    public string? DateTimeFormat
    {
        get => _dateTimeFormat ?? string.Empty;
        set => _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value;
    }

    public CultureInfo Culture
    {
        get => _culture ?? CultureInfo.CurrentCulture;
        set => _culture = value;
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
    {
        string text;


        if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
            || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
        {
            value = value.ToUniversalTime();
        }

        text = value.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);

        writer.WriteStringValue(text);
    }

    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? dateText = reader.GetString();

        if (string.IsNullOrEmpty(dateText) == false)
        {
            if (!string.IsNullOrEmpty(_dateTimeFormat))
            {
                return DateTimeOffset.ParseExact(dateText, _dateTimeFormat, Culture, _dateTimeStyles);
            }
            else
            {
                return DateTimeOffset.Parse(dateText, Culture, _dateTimeStyles);
            }
        }
        else
        {
            return default(DateTimeOffset);
        }
    }


    public static readonly IsoDateTimeOffsetConverter Singleton = new IsoDateTimeOffsetConverter();
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
