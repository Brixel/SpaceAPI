using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BrixelAPI.SpaceState.Schema;

public partial class SpaceApi
{
    /// <summary>
    /// The versions your SpaceAPI endpoint supports
    /// </summary>
    [JsonProperty("api_compatibility")]
    public string[] ApiCompatibility { get; set; }

    /// <summary>
    /// URL(s) of webcams in your space
    /// </summary>
    [JsonProperty("cam", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Cam { get; set; }

    /// <summary>
    /// Contact information about your space
    /// </summary>
    [JsonProperty("contact")]
    public Contact Contact { get; set; }

    /// <summary>
    /// Events which happened recently in your space and which could be interesting to the
    /// public, like 'User X has entered/triggered/did something at timestamp Z'
    /// </summary>
    [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
    public Event[] Events { get; set; }

    /// <summary>
    /// Feeds where users can get updates of your space
    /// </summary>
    [JsonProperty("feeds", NullValueHandling = NullValueHandling.Ignore)]
    public Feeds Feeds { get; set; }

    /// <summary>
    /// Arbitrary links that you'd like to share
    /// </summary>
    [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
    public Link[] Links { get; set; }

    /// <summary>
    /// Position data such as a postal address or geographic coordinates
    /// </summary>
    [JsonProperty("location")]
    public Location Location { get; set; }

    /// <summary>
    /// URL to your space logo
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// A list of the different membership plans your hackerspace might have. Set the value
    /// according to your billing process. For example, if your membership fee is 10€ per month,
    /// but you bill it yearly (aka. the member pays the fee once per year), set the amount to
    /// 120 an the billing_interval to yearly.
    /// </summary>
    [JsonProperty("membership_plans", NullValueHandling = NullValueHandling.Ignore)]
    public MembershipPlan[] MembershipPlans { get; set; }

    /// <summary>
    /// Your project sites (links to GitHub, wikis or wherever your projects are hosted)
    /// </summary>
    [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Projects { get; set; }

    /// <summary>
    /// Data of various sensors in your space (e.g. temperature, humidity, amount of Club-Mate
    /// left, …). The only canonical property is the <em>temp</em> property, additional sensor
    /// types may be defined by you. In this case, you are requested to share your definition for
    /// inclusion in this specification.
    /// </summary>
    [JsonProperty("sensors", NullValueHandling = NullValueHandling.Ignore)]
    public Sensors Sensors { get; set; }

    /// <summary>
    /// The name of your space
    /// </summary>
    [JsonProperty("space")]
    public string Space { get; set; }

    /// <summary>
    /// A flag indicating if the hackerspace uses SpaceFED, a federated login scheme so that
    /// visiting hackers can use the space WiFi with their home space credentials.
    /// </summary>
    [JsonProperty("spacefed", NullValueHandling = NullValueHandling.Ignore)]
    public Spacefed Spacefed { get; set; }

    /// <summary>
    /// A collection of status-related data: actual open/closed status, icons, last change
    /// timestamp etc.
    /// </summary>
    [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
    public State State { get; set; }

    /// <summary>
    /// URL to your space website
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }

}

/// <summary>
/// Contact information about your space
/// </summary>
public class Contact
{
    /// <summary>
    /// E-mail address for contacting your space. If this is a mailing list consider to use the
    /// contact/ml field.
    /// </summary>
    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    public string Email { get; set; }

    /// <summary>
    /// Facebook account URL
    /// </summary>
    [JsonProperty("facebook", NullValueHandling = NullValueHandling.Ignore)]
    public string Facebook { get; set; }

    /// <summary>
    /// Foursquare ID, in the form <samp>4d8a9114d85f3704eab301dc</samp>
    /// </summary>
    [JsonProperty("foursquare", NullValueHandling = NullValueHandling.Ignore)]
    public string Foursquare { get; set; }

    /// <summary>
    /// A URL to find information about the Space in the Gopherspace
    /// </summary>
    [JsonProperty("gopher", NullValueHandling = NullValueHandling.Ignore)]
    public string Gopher { get; set; }

    /// <summary>
    /// Identi.ca or StatusNet account, in the form <samp>yourspace@example.org</samp>
    /// </summary>
    [JsonProperty("identica", NullValueHandling = NullValueHandling.Ignore)]
    public string Identica { get; set; }

    /// <summary>
    /// URL of the IRC channel
    /// </summary>
    [JsonProperty("irc", NullValueHandling = NullValueHandling.Ignore)]
    public string Irc { get; set; }

    /// <summary>
    /// A separate email address for issue reports. This value can be Base64-encoded.
    /// </summary>
    [JsonProperty("issue_mail", NullValueHandling = NullValueHandling.Ignore)]
    public string IssueMail { get; set; }

    /// <summary>
    /// Persons who carry a key and are able to open the space upon request. One of the fields
    /// irc_nick, phone, email or twitter must be specified.
    /// </summary>
    [JsonProperty("keymasters", NullValueHandling = NullValueHandling.Ignore)]
    public Keymaster[] Keymasters { get; set; }

    /// <summary>
    /// Mastodon username
    /// </summary>
    [JsonProperty("mastodon", NullValueHandling = NullValueHandling.Ignore)]
    public string Mastodon { get; set; }

    /// <summary>
    /// Matrix channel/community for the Hackerspace
    /// </summary>
    [JsonProperty("matrix", NullValueHandling = NullValueHandling.Ignore)]
    public string Matrix { get; set; }

    /// <summary>
    /// The e-mail address of your mailing list. If you use Google Groups then the e-mail looks
    /// like <samp>your-group@googlegroups.com</samp>.
    /// </summary>
    [JsonProperty("ml", NullValueHandling = NullValueHandling.Ignore)]
    public string Ml { get; set; }

    /// <summary>
    /// URL to a Mumble server/channel, as specified in https://wiki.mumble.info/wiki/Mumble_URL
    /// </summary>
    [JsonProperty("mumble", NullValueHandling = NullValueHandling.Ignore)]
    public string Mumble { get; set; }

    /// <summary>
    /// Phone number, including country code with a leading plus sign
    /// </summary>
    [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
    public string Phone { get; set; }

    /// <summary>
    /// URI for Voice-over-IP via SIP
    /// </summary>
    [JsonProperty("sip", NullValueHandling = NullValueHandling.Ignore)]
    public string Sip { get; set; }

    /// <summary>
    /// Twitter username with leading <code>@</code>
    /// </summary>
    [JsonProperty("twitter", NullValueHandling = NullValueHandling.Ignore)]
    public string Twitter { get; set; }

    /// <summary>
    /// A public Jabber/XMPP multi-user chatroom in the form
    /// <samp>chatroom@conference.example.net</samp>
    /// </summary>
    [JsonProperty("xmpp", NullValueHandling = NullValueHandling.Ignore)]
    public string Xmpp { get; set; }
}

public partial class Keymaster
{
    /// <summary>
    /// Email address which can be base64 encoded
    /// </summary>
    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    public string Email { get; set; }

    /// <summary>
    /// Contact the person with this nickname directly in irc if available. The irc channel to be
    /// used is defined in the contact/irc field.
    /// </summary>
    [JsonProperty("irc_nick", NullValueHandling = NullValueHandling.Ignore)]
    public string IrcNick { get; set; }

    /// <summary>
    /// Mastodon username
    /// </summary>
    [JsonProperty("mastodon", NullValueHandling = NullValueHandling.Ignore)]
    public string Mastodon { get; set; }

    /// <summary>
    /// Matrix username (including domain)
    /// </summary>
    [JsonProperty("matrix", NullValueHandling = NullValueHandling.Ignore)]
    public string Matrix { get; set; }

    /// <summary>
    /// Real name
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Phone number, including country code with a leading plus sign
    /// </summary>
    [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
    public string Phone { get; set; }

    /// <summary>
    /// Twitter username with leading <code>@</code>
    /// </summary>
    [JsonProperty("twitter", NullValueHandling = NullValueHandling.Ignore)]
    public string Twitter { get; set; }

    /// <summary>
    /// XMPP (Jabber) ID
    /// </summary>
    [JsonProperty("xmpp", NullValueHandling = NullValueHandling.Ignore)]
    public string Xmpp { get; set; }
}

public partial class Event
{
    /// <summary>
    /// A custom text field to give more information about the event
    /// </summary>
    [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
    public string Extra { get; set; }

    /// <summary>
    /// Name or other identity of the subject (e.g. <samp>J. Random Hacker</samp>,
    /// <samp>fridge</samp>, <samp>3D printer</samp>, …)
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Unix timestamp when the event occurred
    /// </summary>
    [JsonProperty("timestamp")]
    public double Timestamp { get; set; }

    /// <summary>
    /// Action (e.g. <samp>check-in</samp>, <samp>check-out</samp>, <samp>finish-print</samp>,
    /// …). Define your own actions and use them consistently, canonical actions are not (yet)
    /// specified
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }
}

/// <summary>
/// Feeds where users can get updates of your space
/// </summary>
public partial class Feeds
{
    [JsonProperty("blog", NullValueHandling = NullValueHandling.Ignore)]
    public Blog Blog { get; set; }

    [JsonProperty("calendar", NullValueHandling = NullValueHandling.Ignore)]
    public Calendar Calendar { get; set; }

    [JsonProperty("flickr", NullValueHandling = NullValueHandling.Ignore)]
    public Flickr Flickr { get; set; }

    [JsonProperty("wiki", NullValueHandling = NullValueHandling.Ignore)]
    public Wiki Wiki { get; set; }
}

public partial class Blog
{
    /// <summary>
    /// Type of the feed
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    /// <summary>
    /// Feed URL
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }
}

public partial class Calendar
{
    /// <summary>
    /// Type of the feed
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    /// <summary>
    /// Feed URL
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }
}

public partial class Flickr
{
    /// <summary>
    /// Type of the feed
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    /// <summary>
    /// Feed URL
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }
}

public partial class Wiki
{
    /// <summary>
    /// Type of the feed
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    /// <summary>
    /// Feed URL
    /// </summary>
    [JsonProperty("url")]
    public string Url { get; set; }
}

public partial class Link
{
    /// <summary>
    /// An extra field for a more detailed description of the link
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The link name
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The URL
    /// </summary>
    [JsonProperty("url")]
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
    [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
    public string Address { get; set; }

    /// <summary>
    /// Latitude of your space location, in degree with decimal places. Use positive values for
    /// locations north of the equator, negative values for locations south of equator.
    /// </summary>
    [JsonProperty("lat")]
    public double Lat { get; set; }

    /// <summary>
    /// Longitude of your space location, in degree with decimal places. Use positive values for
    /// locations east of Greenwich, and negative values for locations west of Greenwich.
    /// </summary>
    [JsonProperty("lon")]
    public double Lon { get; set; }

    /// <summary>
    /// The timezone the space is located in. It should be formatted according to the <a
    /// target="_blank" href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">TZ
    /// database location names</a>.
    /// </summary>
    [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
    public string Timezone { get; set; }
}

public partial class MembershipPlan
{
    /// <summary>
    /// How often is the membership billed? If you select other, please specify in the
    /// description what your billing interval is.
    /// </summary>
    [JsonProperty("billing_interval")]
    public BillingInterval BillingInterval { get; set; }

    /// <summary>
    /// What's the currency? It should be formatted according to <a
    /// href="https://en.wikipedia.org/wiki/ISO_4217" target="_blank">ISO 4217</a> short-code
    /// format.
    /// </summary>
    [JsonProperty("currency")]
    public string Currency { get; set; }

    /// <summary>
    /// A free form string
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The name of the membership plan
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// How much does this plan cost?
    /// </summary>
    [JsonProperty("value")]
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
    [JsonProperty("account_balance", NullValueHandling = NullValueHandling.Ignore)]
    public AccountBalance[] AccountBalance { get; set; }

    /// <summary>
    /// Barometer sensor
    /// </summary>
    [JsonProperty("barometer", NullValueHandling = NullValueHandling.Ignore)]
    public Barometer[] Barometer { get; set; }

    /// <summary>
    /// How much Mate and beer is in your fridge?
    /// </summary>
    [JsonProperty("beverage_supply", NullValueHandling = NullValueHandling.Ignore)]
    public BeverageSupply[] BeverageSupply { get; set; }

    /// <summary>
    /// Sensor type to indicate if a certain door is locked
    /// </summary>
    [JsonProperty("door_locked", NullValueHandling = NullValueHandling.Ignore)]
    public DoorLocked[] DoorLocked { get; set; }

    /// <summary>
    /// Humidity sensor
    /// </summary>
    [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
    public Humidity[] Humidity { get; set; }

    /// <summary>
    /// This sensor type is to specify the currently active ethernet or wireless network devices.
    /// You can create different instances for each network type.
    /// </summary>
    [JsonProperty("network_connections", NullValueHandling = NullValueHandling.Ignore)]
    public NetworkConnection[] NetworkConnections { get; set; }

    /// <summary>
    /// The current network traffic, in bits/second or packets/second (or both)
    /// </summary>
    [JsonProperty("network_traffic", NullValueHandling = NullValueHandling.Ignore)]
    public NetworkTraffic[] NetworkTraffic { get; set; }

    /// <summary>
    /// Specify the number of people that are currently in your space. Optionally you can define
    /// a list of names.
    /// </summary>
    [JsonProperty("people_now_present", NullValueHandling = NullValueHandling.Ignore)]
    public PeopleNowPresent[] PeopleNowPresent { get; set; }

    /// <summary>
    /// The power consumption of a specific device or of your whole space
    /// </summary>
    [JsonProperty("power_consumption", NullValueHandling = NullValueHandling.Ignore)]
    public PowerConsumption[] PowerConsumption { get; set; }

    /// <summary>
    /// Compound radiation sensor. Check this <a rel="nofollow"
    /// href="https://sites.google.com/site/diygeigercounter/gm-tubes-supported"
    /// target="_blank">resource</a>.
    /// </summary>
    [JsonProperty("radiation", NullValueHandling = NullValueHandling.Ignore)]
    public Radiation Radiation { get; set; }

    /// <summary>
    /// Temperature sensor. To convert from one unit of temperature to another consider <a
    /// href="http://en.wikipedia.org/wiki/Temperature_conversion_formulas"
    /// target="_blank">Wikipedia</a>.
    /// </summary>
    [JsonProperty("temperature", NullValueHandling = NullValueHandling.Ignore)]
    public Temperature[] Temperature { get; set; }

    /// <summary>
    /// Specify the number of space members.
    /// </summary>
    [JsonProperty("total_member_count", NullValueHandling = NullValueHandling.Ignore)]
    public TotalMemberCount[] TotalMemberCount { get; set; }

    /// <summary>
    /// Your wind sensor
    /// </summary>
    [JsonProperty("wind", NullValueHandling = NullValueHandling.Ignore)]
    public Wind[] Wind { get; set; }
}

public partial class AccountBalance
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// If you have more than one account you can use this field to specify where it is.
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// Give your sensor instance a name.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// What's the currency? It should be formatted according to <a
    /// href="https://en.wikipedia.org/wiki/ISO_4217" target="_blank">ISO 4217</a> short-code
    /// format.
    /// </summary>
    [JsonProperty("unit")]
    public string Unit { get; set; }

    /// <summary>
    /// How much?
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class Barometer
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// The unit of pressure used by your sensor<br>Note: The <code>hPA</code> unit is deprecated
    /// and should not be used anymore. Use the correct <code>hPa</code> unit instead.
    /// </summary>
    [JsonProperty("unit")]
    public BarometerUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class BeverageSupply
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// The unit, either <samp>btl</samp> for bottles or <samp>crt</samp> for crates
    /// </summary>
    [JsonProperty("unit")]
    public BeverageSupplyUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class DoorLocked
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
    public bool Value { get; set; }
}

public partial class Humidity
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonProperty("unit")]
    public HumidityUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class NetworkConnection
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// The machines that are currently connected with the network.
    /// </summary>
    [JsonProperty("machines", NullValueHandling = NullValueHandling.Ignore)]
    public Machine[] Machines { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// This field is optional but you can use it to the network type such as <samp>wifi</samp>
    /// or <samp>cable</samp>. You can even expose the number of <a
    /// href="https://spacefed.net/wiki/index.php/Spacenet"
    /// target="_blank">spacenet</a>-authenticated connections.
    /// </summary>
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// The amount of network connections.
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class Machine
{
    /// <summary>
    /// The machine's MAC address of the format <samp>D3:3A:DB:EE:FF:00</samp>.
    /// </summary>
    [JsonProperty("mac")]
    public string Mac { get; set; }

    /// <summary>
    /// The machine name.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
}

public partial class NetworkTraffic
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// Location the measurement relates to, e.g. <samp>WiFi</samp> or <samp>Uplink</samp>
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// Name of the measurement, e.g. to distinguish between upstream and downstream traffic
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("properties")]
    public NetworkTrafficProperties Properties { get; set; }
}

public partial class NetworkTrafficProperties
{
    [JsonProperty("bits_per_second", NullValueHandling = NullValueHandling.Ignore)]
    public BitsPerSecond BitsPerSecond { get; set; }

    [JsonProperty("packets_per_second", NullValueHandling = NullValueHandling.Ignore)]
    public PacketsPerSecond PacketsPerSecond { get; set; }
}

public partial class BitsPerSecond
{
    /// <summary>
    /// The maximum available throughput in bits/second, e.g. as sold by your ISP
    /// </summary>
    [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(MinMaxValueCheckConverter))]
    public double? Maximum { get; set; }

    /// <summary>
    /// The measurement value, in bits/second
    /// </summary>
    [JsonProperty("value")]
    [JsonConverter(typeof(MinMaxValueCheckConverter))]
    public double Value { get; set; }
}

public partial class PacketsPerSecond
{
    /// <summary>
    /// The measurement value, in packets/second
    /// </summary>
    [JsonProperty("value")]
    [JsonConverter(typeof(MinMaxValueCheckConverter))]
    public double Value { get; set; }
}

public partial class PeopleNowPresent
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// If you use multiple sensor instances for different rooms, use this field to indicate the
    /// location.
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// Give this sensor a name if necessary at all. Use the location field for the rooms. This
    /// field is not intended to be used for names of hackerspace members. Use the field 'names'
    /// instead.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// List of hackerspace members that are currently occupying the space.
    /// </summary>
    [JsonProperty("names", NullValueHandling = NullValueHandling.Ignore)]
    public string[] Names { get; set; }

    /// <summary>
    /// The amount of present people.
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class PowerConsumption
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonProperty("unit")]
    public PowerConsumptionUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

/// <summary>
/// Compound radiation sensor. Check this <a rel="nofollow"
/// href="https://sites.google.com/site/diygeigercounter/gm-tubes-supported"
/// target="_blank">resource</a>.
/// </summary>
public partial class Radiation
{
    /// <summary>
    /// An alpha sensor
    /// </summary>
    [JsonProperty("alpha", NullValueHandling = NullValueHandling.Ignore)]
    public Alpha[] Alpha { get; set; }

    /// <summary>
    /// A beta sensor
    /// </summary>
    [JsonProperty("beta", NullValueHandling = NullValueHandling.Ignore)]
    public Beta[] Beta { get; set; }

    /// <summary>
    /// A sensor which cannot filter beta and gamma radiation separately.
    /// </summary>
    [JsonProperty("beta_gamma", NullValueHandling = NullValueHandling.Ignore)]
    public BetaGamma[] BetaGamma { get; set; }

    /// <summary>
    /// A gamma sensor
    /// </summary>
    [JsonProperty("gamma", NullValueHandling = NullValueHandling.Ignore)]
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
    [JsonProperty("conversion_factor", NullValueHandling = NullValueHandling.Ignore)]
    public double? ConversionFactor { get; set; }

    /// <summary>
    /// The dead time in µs. See the description of the value field to see how to use the dead
    /// time.
    /// </summary>
    [JsonProperty("dead_time", NullValueHandling = NullValueHandling.Ignore)]
    public double? DeadTime { get; set; }

    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Choose the appropriate unit for your radiation sensor instance
    /// </summary>
    [JsonProperty("unit")]
    public AlphaUnit Unit { get; set; }

    /// <summary>
    /// Observed counts per minute (ocpm) or actual radiation value. If the value are the
    /// observed counts then the dead_time and conversion_factor fields must be defined as well.
    /// CPM formula: <div>cpm = ocpm ( 1 + 1 / (1 - ocpm x dead_time) )</div> Conversion formula:
    /// <div>µSv/h = cpm x conversion_factor</div>
    /// </summary>
    [JsonProperty("value")]
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
    [JsonProperty("conversion_factor", NullValueHandling = NullValueHandling.Ignore)]
    public double? ConversionFactor { get; set; }

    /// <summary>
    /// The dead time in µs. See the description of the value field to see how to use the dead
    /// time.
    /// </summary>
    [JsonProperty("dead_time", NullValueHandling = NullValueHandling.Ignore)]
    public double? DeadTime { get; set; }

    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Choose the appropriate unit for your radiation sensor instance
    /// </summary>
    [JsonProperty("unit")]
    public AlphaUnit Unit { get; set; }

    /// <summary>
    /// Observed counts per minute (ocpm) or actual radiation value. If the value are the
    /// observed counts then the dead_time and conversion_factor fields must be defined as well.
    /// CPM formula: <div>cpm = ocpm ( 1 + 1 / (1 - ocpm x dead_time) )</div> Conversion formula:
    /// <div>µSv/h = cpm x conversion_factor</div>
    /// </summary>
    [JsonProperty("value")]
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
    [JsonProperty("conversion_factor", NullValueHandling = NullValueHandling.Ignore)]
    public double? ConversionFactor { get; set; }

    /// <summary>
    /// The dead time in µs. See the description of the value field to see how to use the dead
    /// time.
    /// </summary>
    [JsonProperty("dead_time", NullValueHandling = NullValueHandling.Ignore)]
    public double? DeadTime { get; set; }

    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Choose the appropriate unit for your radiation sensor instance
    /// </summary>
    [JsonProperty("unit")]
    public AlphaUnit Unit { get; set; }

    /// <summary>
    /// Observed counts per minute (ocpm) or actual radiation value. If the value are the
    /// observed counts then the dead_time and conversion_factor fields must be defined as well.
    /// CPM formula: <div>cpm = ocpm ( 1 + 1 / (1 - ocpm x dead_time) )</div> Conversion formula:
    /// <div>µSv/h = cpm x conversion_factor</div>
    /// </summary>
    [JsonProperty("value")]
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
    [JsonProperty("conversion_factor", NullValueHandling = NullValueHandling.Ignore)]
    public double? ConversionFactor { get; set; }

    /// <summary>
    /// The dead time in µs. See the description of the value field to see how to use the dead
    /// time.
    /// </summary>
    [JsonProperty("dead_time", NullValueHandling = NullValueHandling.Ignore)]
    public double? DeadTime { get; set; }

    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// Choose the appropriate unit for your radiation sensor instance
    /// </summary>
    [JsonProperty("unit")]
    public AlphaUnit Unit { get; set; }

    /// <summary>
    /// Observed counts per minute (ocpm) or actual radiation value. If the value are the
    /// observed counts then the dead_time and conversion_factor fields must be defined as well.
    /// CPM formula: <div>cpm = ocpm ( 1 + 1 / (1 - ocpm x dead_time) )</div> Conversion formula:
    /// <div>µSv/h = cpm x conversion_factor</div>
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class Temperature
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// The unit of the sensor value
    /// </summary>
    [JsonProperty("unit")]
    public TemperatureUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class TotalMemberCount
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// Specify the location if your hackerspace has different departments (for whatever reason).
    /// This field is for one department. Every department should have its own sensor instance.
    /// </summary>
    [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
    public string Location { get; set; }

    /// <summary>
    /// You can use this field to specify if this sensor instance counts active or inactive
    /// members.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    /// <summary>
    /// The amount of your space members.
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class Wind
{
    /// <summary>
    /// An extra field that you can use to attach some additional information to this sensor
    /// instance
    /// </summary>
    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// The location of your sensor
    /// </summary>
    [JsonProperty("location")]
    public string Location { get; set; }

    /// <summary>
    /// This field is an additional field to give your sensor a name. This can be useful if you
    /// have multiple sensors in the same location.
    /// </summary>
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("properties")]
    public WindProperties Properties { get; set; }
}

public partial class WindProperties
{
    /// <summary>
    /// The wind direction in degrees
    /// </summary>
    [JsonProperty("direction")]
    public Direction Direction { get; set; }

    /// <summary>
    /// Height above mean sea level
    /// </summary>
    [JsonProperty("elevation")]
    public Elevation Elevation { get; set; }

    [JsonProperty("gust")]
    public Gust Gust { get; set; }

    [JsonProperty("speed")]
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
    [JsonProperty("unit")]
    public DirectionUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
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
    [JsonProperty("unit")]
    public ElevationUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class Gust
{
    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonProperty("unit")]
    public GustUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
    public double Value { get; set; }
}

public partial class Speed
{
    /// <summary>
    /// The unit of the sensor value. You should always define the unit though if the sensor is a
    /// flag of a boolean type then you can of course omit it.
    /// </summary>
    [JsonProperty("unit")]
    public GustUnit Unit { get; set; }

    /// <summary>
    /// The sensor value
    /// </summary>
    [JsonProperty("value")]
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
    [JsonProperty("spacenet")]
    public bool Spacenet { get; set; }

    /// <summary>
    /// See the <a target="_blank" href="https://spacefed.net/index.php?title=Spacesaml">wiki</a>.
    /// </summary>
    [JsonProperty("spacesaml")]
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
    [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
    public Icon Icon { get; set; }

    /// <summary>
    /// The Unix timestamp when the space status changed most recently
    /// </summary>
    [JsonProperty("lastchange", NullValueHandling = NullValueHandling.Ignore)]
    public double? Lastchange { get; set; }

    /// <summary>
    /// An additional free-form string, could be something like <samp>'open for public'</samp>,
    /// <samp>'members only'</samp> or whatever you want it to be
    /// </summary>
    [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
    public string Message { get; set; }

    /// <summary>
    /// A flag which indicates whether the space is currently open or closed. The state
    /// 'undefined' can be achieved by omitting this field. A missing 'open' property carries the
    /// semantics of a temporary unavailability of the state, whereas the absence of the 'state'
    /// property itself means the state is generally not implemented for this space. This field
    /// is also allowed to explicitly have the value null for backwards compatibility with older
    /// schema versions, but this is deprecated and will be removed in a future version.
    /// </summary>
    [JsonProperty("open")]
    public bool? Open { get; set; }

    /// <summary>
    /// The person who lastly changed the state e.g. opened or closed the space
    /// </summary>
    [JsonProperty("trigger_person", NullValueHandling = NullValueHandling.Ignore)]
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
    [JsonProperty("closed")]
    public string Closed { get; set; }

    /// <summary>
    /// The URL to your customized space logo showing an open space
    /// </summary>
    [JsonProperty("open")]
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

public partial class SpaceApi
{
    public static BrixelAPI.SpaceState.Domain.SpaceStateAggregate.SpaceState FromJson(string json) => JsonConvert.DeserializeObject<BrixelAPI.SpaceState.Domain.SpaceStateAggregate.SpaceState>(json, Converter.Settings);
}

public static class Serialize
{
    public static string ToJson(this BrixelAPI.SpaceState.Domain.SpaceStateAggregate.SpaceState self) => JsonConvert.SerializeObject(self, Converter.Settings);
}

internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
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
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
        },
    };
}

internal class BillingIntervalConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(BillingInterval) || t == typeof(BillingInterval?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
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

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (BillingInterval)untypedValue;
        switch (value)
        {
            case BillingInterval.Daily:
                serializer.Serialize(writer, "daily");
                return;
            case BillingInterval.Hourly:
                serializer.Serialize(writer, "hourly");
                return;
            case BillingInterval.Monthly:
                serializer.Serialize(writer, "monthly");
                return;
            case BillingInterval.Other:
                serializer.Serialize(writer, "other");
                return;
            case BillingInterval.Weekly:
                serializer.Serialize(writer, "weekly");
                return;
            case BillingInterval.Yearly:
                serializer.Serialize(writer, "yearly");
                return;
        }
        throw new Exception("Cannot marshal type BillingInterval");
    }

    public static readonly BillingIntervalConverter Singleton = new BillingIntervalConverter();
}

internal class BarometerUnitConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(BarometerUnit) || t == typeof(BarometerUnit?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "hPA":
                return BarometerUnit.UnitHPa;
            case "hPa":
                return BarometerUnit.HPa;
        }
        throw new Exception("Cannot unmarshal type BarometerUnit");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (BarometerUnit)untypedValue;
        switch (value)
        {
            case BarometerUnit.UnitHPa:
                serializer.Serialize(writer, "hPA");
                return;
            case BarometerUnit.HPa:
                serializer.Serialize(writer, "hPa");
                return;
        }
        throw new Exception("Cannot marshal type BarometerUnit");
    }

    public static readonly BarometerUnitConverter Singleton = new BarometerUnitConverter();
}

internal class BeverageSupplyUnitConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(BeverageSupplyUnit) || t == typeof(BeverageSupplyUnit?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        switch (value)
        {
            case "btl":
                return BeverageSupplyUnit.Btl;
            case "crt":
                return BeverageSupplyUnit.Crt;
        }
        throw new Exception("Cannot unmarshal type BeverageSupplyUnit");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (BeverageSupplyUnit)untypedValue;
        switch (value)
        {
            case BeverageSupplyUnit.Btl:
                serializer.Serialize(writer, "btl");
                return;
            case BeverageSupplyUnit.Crt:
                serializer.Serialize(writer, "crt");
                return;
        }
        throw new Exception("Cannot marshal type BeverageSupplyUnit");
    }

    public static readonly BeverageSupplyUnitConverter Singleton = new BeverageSupplyUnitConverter();
}

internal class HumidityUnitConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(HumidityUnit) || t == typeof(HumidityUnit?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "%")
        {
            return HumidityUnit.Empty;
        }
        throw new Exception("Cannot unmarshal type HumidityUnit");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (HumidityUnit)untypedValue;
        if (value == HumidityUnit.Empty)
        {
            serializer.Serialize(writer, "%");
            return;
        }
        throw new Exception("Cannot marshal type HumidityUnit");
    }

    public static readonly HumidityUnitConverter Singleton = new HumidityUnitConverter();
}

internal class TypeEnumConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
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

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (TypeEnum)untypedValue;
        switch (value)
        {
            case TypeEnum.Cable:
                serializer.Serialize(writer, "cable");
                return;
            case TypeEnum.Spacenet:
                serializer.Serialize(writer, "spacenet");
                return;
            case TypeEnum.Wifi:
                serializer.Serialize(writer, "wifi");
                return;
        }
        throw new Exception("Cannot marshal type TypeEnum");
    }

    public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
}

internal class MinMaxValueCheckConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(double) || t == typeof(double?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<double>(reader);
        if (value >= 0)
        {
            return value;
        }
        throw new Exception("Cannot unmarshal type double");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (double)untypedValue;
        if (value >= 0)
        {
            serializer.Serialize(writer, value);
            return;
        }
        throw new Exception("Cannot marshal type double");
    }

    public static readonly MinMaxValueCheckConverter Singleton = new MinMaxValueCheckConverter();
}

internal class PowerConsumptionUnitConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(PowerConsumptionUnit) || t == typeof(PowerConsumptionUnit?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
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

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (PowerConsumptionUnit)untypedValue;
        switch (value)
        {
            case PowerConsumptionUnit.Va:
                serializer.Serialize(writer, "VA");
                return;
            case PowerConsumptionUnit.W:
                serializer.Serialize(writer, "W");
                return;
            case PowerConsumptionUnit.MW:
                serializer.Serialize(writer, "mW");
                return;
        }
        throw new Exception("Cannot marshal type PowerConsumptionUnit");
    }

    public static readonly PowerConsumptionUnitConverter Singleton = new PowerConsumptionUnitConverter();
}

internal class AlphaUnitConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(AlphaUnit) || t == typeof(AlphaUnit?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
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

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (AlphaUnit)untypedValue;
        switch (value)
        {
            case AlphaUnit.Cpm:
                serializer.Serialize(writer, "cpm");
                return;
            case AlphaUnit.MSvA:
                serializer.Serialize(writer, "mSv/a");
                return;
            case AlphaUnit.RH:
                serializer.Serialize(writer, "r/h");
                return;
            case AlphaUnit.ΜSvA:
                serializer.Serialize(writer, "µSv/a");
                return;
            case AlphaUnit.ΜSvH:
                serializer.Serialize(writer, "µSv/h");
                return;
        }
        throw new Exception("Cannot marshal type AlphaUnit");
    }

    public static readonly AlphaUnitConverter Singleton = new AlphaUnitConverter();
}

internal class TemperatureUnitConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(TemperatureUnit) || t == typeof(TemperatureUnit?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
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

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (TemperatureUnit)untypedValue;
        switch (value)
        {
            case TemperatureUnit.K:
                serializer.Serialize(writer, "K");
                return;
            case TemperatureUnit.C:
                serializer.Serialize(writer, "°C");
                return;
            case TemperatureUnit.De:
                serializer.Serialize(writer, "°De");
                return;
            case TemperatureUnit.F:
                serializer.Serialize(writer, "°F");
                return;
            case TemperatureUnit.N:
                serializer.Serialize(writer, "°N");
                return;
            case TemperatureUnit.R:
                serializer.Serialize(writer, "°R");
                return;
            case TemperatureUnit.Ré:
                serializer.Serialize(writer, "°Ré");
                return;
            case TemperatureUnit.Rø:
                serializer.Serialize(writer, "°Rø");
                return;
        }
        throw new Exception("Cannot marshal type TemperatureUnit");
    }

    public static readonly TemperatureUnitConverter Singleton = new TemperatureUnitConverter();
}

internal class DirectionUnitConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(DirectionUnit) || t == typeof(DirectionUnit?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "°")
        {
            return DirectionUnit.Empty;
        }
        throw new Exception("Cannot unmarshal type DirectionUnit");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (DirectionUnit)untypedValue;
        if (value == DirectionUnit.Empty)
        {
            serializer.Serialize(writer, "°");
            return;
        }
        throw new Exception("Cannot marshal type DirectionUnit");
    }

    public static readonly DirectionUnitConverter Singleton = new DirectionUnitConverter();
}

internal class ElevationUnitConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(ElevationUnit) || t == typeof(ElevationUnit?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
        if (value == "m")
        {
            return ElevationUnit.M;
        }
        throw new Exception("Cannot unmarshal type ElevationUnit");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (ElevationUnit)untypedValue;
        if (value == ElevationUnit.M)
        {
            serializer.Serialize(writer, "m");
            return;
        }
        throw new Exception("Cannot marshal type ElevationUnit");
    }

    public static readonly ElevationUnitConverter Singleton = new ElevationUnitConverter();
}

internal class GustUnitConverter : JsonConverter
{
    public override bool CanConvert(Type t) => t == typeof(GustUnit) || t == typeof(GustUnit?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null) return null;
        var value = serializer.Deserialize<string>(reader);
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

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
        if (untypedValue == null)
        {
            serializer.Serialize(writer, null);
            return;
        }
        var value = (GustUnit)untypedValue;
        switch (value)
        {
            case GustUnit.KmH:
                serializer.Serialize(writer, "km/h");
                return;
            case GustUnit.Kn:
                serializer.Serialize(writer, "kn");
                return;
            case GustUnit.MS:
                serializer.Serialize(writer, "m/s");
                return;
        }
        throw new Exception("Cannot marshal type GustUnit");
    }

    public static readonly GustUnitConverter Singleton = new GustUnitConverter();
}