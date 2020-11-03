using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace PokemonProject.Models
{
    public class PokemonDetails
    {
        [JsonProperty("abilities")]
        public List<Ability> Abilities { get; set; }

        [JsonProperty("base_experience")]
        public long BaseExperience { get; set; }


        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }

        //[JsonProperty("stats")]
        //public List<Stat> Stats { get; set; }

        [JsonProperty("types")]
        public List<TypeElement> Types { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }

    public class Ability
    {
        [JsonProperty("ability")]
        public Species AbilityAbility { get; set; }

        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }
    }
    public class Species
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public class TypeElement
    {
        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("type")]
        public Species Type { get; set; }
    }

    public class Sprites
    {

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }


        public ImageSource ImageSrc
        {
            get
            {
                return ImageSource.FromStream(() => new HttpClient().GetStreamAsync(FrontDefault).Result);
            }

        }


    
    }

}
