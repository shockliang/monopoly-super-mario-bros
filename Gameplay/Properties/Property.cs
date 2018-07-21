using System;
using Newtonsoft.Json;

namespace Monopoly.SuperMarioBros.Gameplay.Properties
{
    public class PropertiesAsset
    {
        [JsonProperty("Properties")]
        public Property[] Properties { get; set; }
    }
    
    public class Property
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Colour")]
        public ColourSet Colour { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Rent")]
        public int Rent { get; set; }

        [JsonProperty("RentWithColourSet")]
        public int RentWithColourSet { get; set; }

        [JsonProperty("Point")]
        public int Point { get; set; }
    }
}