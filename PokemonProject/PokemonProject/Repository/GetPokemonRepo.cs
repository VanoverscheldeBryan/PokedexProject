﻿using Newtonsoft.Json;
using PokemonProject.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProject.Repository
{
    public static class GetPokemonRepo
    {
        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public static async Task<List<Pokemon>> GetDigimonItemsAsync()
        {
            string url = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=151";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    List<Pokemon> digimons = JsonConvert.DeserializeObject<List<Pokemon>>(json);
                    return digimons;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

    }
}
