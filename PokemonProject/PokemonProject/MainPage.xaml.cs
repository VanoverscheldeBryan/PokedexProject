using PokemonProject.Models;
using PokemonProject.Repository;
using PokemonProject.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PokemonProject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Result> pokemons { get; set; }
        //public List<Result> pokemons;
        public MainPage()
        {
            InitializeComponent();
            getPokemonList();
        }

        private async Task getPokemonList()
        {
            pokemons = await GetPokemonRepo.GetPokemonAllPokemon();
        }

        private void Kanto_Clicked(object sender, EventArgs e)
        {
            NavigateToKanto();
        }

        private void NavigateToKanto()
        {
            Navigation.PushAsync(new PokemonPage(pokemons));

        }

        //private void Johto_Clicked(object sender, EventArgs e)
        //{
        //    NavigateToJohto();
        //}

        //private void NavigateToJohto()
        //{
        //    Navigation.PushAsync(new JohtoPage());

        //}

        //private void Hoenn_Clicked(object sender, EventArgs e)
        //{
        //    NavigateToHoenn();
        //}

        //private void NavigateToHoenn()
        //{
        //    Navigation.PushAsync(new HoennPage());

        //}

        //private void Favorites_Clicked(object sender, EventArgs e)
        //{
        //    NavigateToFavorites();

        //}

        //private void NavigateToFavorites()
        //{
        //    List<Pokemon> favorites = new List<Pokemon>();
        //    //foreach 
        //    //Navigation.PushAsync(new Favorites(favorites));
            
        //}

        private void Favorites_Clicked_1(object sender, EventArgs e)
        {
            List<Result> favorites = GetPokemonRepo.favorites;
     
            
            Navigation.PushAsync(new Favorites(favorites));
        }
    }
}
