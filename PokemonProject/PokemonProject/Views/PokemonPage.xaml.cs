using PokemonProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokemonProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonPage : ContentPage
    {
        List<Result> pokemons;
        public PokemonPage(List<Result> pokemonsList)
        {
            pokemons = pokemonsList;
            InitializeComponent();
            ShowPokemonList();
        }
        private async Task ShowPokemonList()
        {
            lvwPokemon.ItemsSource = pokemons;
        }

        private void lvwPokemon_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Result pokemon = lvwPokemon.SelectedItem as Result;
            if (pokemon == null) return;
            Navigation.PushAsync(new PokemonDetail(pokemon));
            lvwPokemon.SelectedItem = null;
        }

        private void btnNavBack_Clicked(object sender, EventArgs e)
        {
            GoBack();

        }

        private void GoBack()
        {
            Navigation.PopAsync();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            string Query = Search.Text;
            List<Result> filtered = new List<Result>();
            foreach (var pokemon in pokemons)
            {
                if (pokemon.Name.Contains(Query))
                {
                    filtered.Add(pokemon);
                }
            }
            lvwPokemon.ItemsSource = filtered;
        }
    }
}