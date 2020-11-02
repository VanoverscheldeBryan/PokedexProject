using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonProject.Models
{
    public class Pokemon
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
