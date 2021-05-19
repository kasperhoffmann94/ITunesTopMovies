using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ITunesTopMovies.Data
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Name
    {
        public string label { get; set; }
    }

    public class Uri
    {
        public string label { get; set; }
    }

    public class Author
    {
        public Name name { get; set; }
        public Uri uri { get; set; }
    }

    public class ImName
    {
        public string label { get; set; }
    }

    public class Attributes
    {
        public string height { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public string term { get; set; }
        public string label { get; set; }
        public string rel { get; set; }
        public string type { get; set; }
        public string href { get; set; }
        public string title { get; set; }

        [JsonProperty("im:assetType")]
        public string ImAssetType { get; set; }

        [JsonProperty("im:id")]
        public string ImId { get; set; }
        public string scheme { get; set; }
    }

    public class ImImage
    {
        public string label { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Summary
    {
        public string label { get; set; }
    }

    public class ImPrice
    {
        public string label { get; set; }
        public Attributes attributes { get; set; }
    }

    public class ImContentType
    {
        public Attributes attributes { get; set; }
    }

    public class Rights
    {
        public string label { get; set; }
    }

    public class Title
    {
        public string label { get; set; }
    }

    public class ImDuration
    {
        public string label { get; set; }
    }

    public class Link
    {
        public Attributes attributes { get; set; }

        [JsonProperty("im:duration")]
        public ImDuration ImDuration { get; set; }
    }

    public class Id
    {
        public string label { get; set; }
        public Attributes attributes { get; set; }
    }

    public class ImArtist
    {
        public string label { get; set; }
    }

    public class Category
    {
        public Attributes attributes { get; set; }
    }

    public class ImReleaseDate
    {
        public DateTime label { get; set; }
        public Attributes attributes { get; set; }
    }

    public class ImRentalPrice
    {
        public string label { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Entry
    {
        [JsonProperty("im:name")]
        public ImName ImName { get; set; }

        [JsonProperty("im:image")]
        public List<ImImage> ImImage { get; set; }
        public Summary summary { get; set; }

        [JsonProperty("im:price")]
        public ImPrice ImPrice { get; set; }

        [JsonProperty("im:contentType")]
        public ImContentType ImContentType { get; set; }
        public Rights rights { get; set; }
        public Title title { get; set; }
        public List<Link> link { get; set; }
        public Id id { get; set; }

        [JsonProperty("im:artist")]
        public ImArtist ImArtist { get; set; }
        public Category category { get; set; }

        [JsonProperty("im:releaseDate")]
        public ImReleaseDate ImReleaseDate { get; set; }

        [JsonProperty("im:rentalPrice")]
        public ImRentalPrice ImRentalPrice { get; set; }
    }

    public class Updated
    {
        public DateTime label { get; set; }
    }

    public class Icon
    {
        public string label { get; set; }
    }

    public class Feed
    {
        public Author author { get; set; }
        public List<Entry> entry { get; set; }
        public Updated updated { get; set; }
        public Rights rights { get; set; }
        public Title title { get; set; }
        public Icon icon { get; set; }
        public List<Link> link { get; set; }
        public Id id { get; set; }
    }

    public class OpenDataItem
    {
        public Feed feed { get; set; }
    }


}
