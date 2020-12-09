using Newtonsoft.Json;
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

        public static List<Result> favorites = new List<Result>();
        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public static async Task<Pokemon> GetPokemonKantoAsync()
        {
            string url = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=151";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    Pokemon pokemons = JsonConvert.DeserializeObject<Pokemon>(json);
                    return pokemons;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public static async Task<Pokemon> GetPokemonJohtoAsync()
        {
            string url = "https://pokeapi.co/api/v2/pokemon?offset=151&limit=251";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    Pokemon pokemons = JsonConvert.DeserializeObject<Pokemon>(json);
                    return pokemons;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public static async Task<Pokemon> GetPokemonHoennAsync()
        {
            string url = "https://pokeapi.co/api/v2/pokemon?offset=251&limit=386";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    Pokemon pokemons = JsonConvert.DeserializeObject<Pokemon>(json);
                    return pokemons;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }


        public static async Task<PokemonDetails> GetPokemonDetails(string name)
        {
            string url = "https://pokeapi.co/api/v2/pokemon/" + name;

            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    PokemonDetails details = JsonConvert.DeserializeObject<PokemonDetails>(json);
                    return details;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public static async Task<List<Result>> GetPokemonAllPokemon()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?offset=0&limit=800";

            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);
                    
                    List<Result> pokemons = JsonConvert.DeserializeObject<Pokemon>(json).Results;
                    return pokemons;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public static void addToFavorite(Result favorite)
        {
            favorites.Add(favorite);
        }

        public static void removeFromFavorites(Result favorite)
        {
            favorites.Remove(favorite);
        }



    }
}

