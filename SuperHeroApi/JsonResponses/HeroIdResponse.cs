using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SuperHeroApi.JsonResponses
{
    public partial class HeroIdResponse
    {
        [JsonPropertyName("response")]
        public string Response { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("powerstats")]
        public Powerstats Powerstats { get; set; }

        [JsonPropertyName("biography")]
        public Biography Biography { get; set; }

        [JsonPropertyName("appearance")]
        public Appearance Appearance { get; set; }

        [JsonPropertyName("work")]
        public Work Work { get; set; }

        [JsonPropertyName("connections")]
        public Connections Connections { get; set; }

        [JsonPropertyName("image")]
        public Image Image { get; set; }
    }

    public partial class Appearance
    {
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("race")]
        public string Race { get; set; }

        [JsonPropertyName("height")]
        public List<string> Height { get; set; }

        [JsonPropertyName("weight")]
        public List<string> Weight { get; set; }

        [JsonPropertyName("eye-color")]
        public string EyeColor { get; set; }

        [JsonPropertyName("hair-color")]
        public string HairColor { get; set; }
    }

    public partial class Biography
    {
        [JsonPropertyName("full-name")]
        public string FullName { get; set; }

        [JsonPropertyName("alter-egos")]
        public string AlterEgos { get; set; }

        [JsonPropertyName("aliases")]
        public List<string> Aliases { get; set; }

        [JsonPropertyName("place-of-birth")]
        public string PlaceOfBirth { get; set; }

        [JsonPropertyName("first-appearance")]
        public string FirstAppearance { get; set; }

        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        [JsonPropertyName("alignment")]
        public string Alignment { get; set; }
    }

    public partial class Connections
    {
        [JsonPropertyName("group-affiliation")]
        public string GroupAffiliation { get; set; }

        [JsonPropertyName("relatives")]
        public string Relatives { get; set; }
    }

    public partial class Image
    {
        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }

    public partial class Powerstats
    {
        [JsonPropertyName("intelligence")]
        
        public long Intelligence { get; set; }

        [JsonPropertyName("strength")]
       
        public long Strength { get; set; }

        [JsonPropertyName("speed")]
        
        public long Speed { get; set; }

        [JsonPropertyName("durability")]
       
        public long Durability { get; set; }

        [JsonPropertyName("power")]
        
        public long Power { get; set; }

        [JsonPropertyName("combat")]
       
        public long Combat { get; set; }
    }

    public partial class Work
    {
        [JsonPropertyName("occupation")]
        public string Occupation { get; set; }

        [JsonPropertyName("base")]
        public string Base { get; set; }
    }

    public partial class HeroIdResponse
    {
        public static HeroIdResponse FromJson(string json)
        {
            return JsonSerializer.Deserialize<HeroIdResponse>(json);
        }
    }
}
