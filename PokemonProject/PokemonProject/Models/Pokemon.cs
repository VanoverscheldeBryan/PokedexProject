using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonProject.Models
{


    public class Pokemon
    {


        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }

    }

    public class Result
    {
        public bool isFavorite { get; set; }

        [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }
        }
    }


