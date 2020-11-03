using PokemonProject.Models;
using PokemonProject.Repository;
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
    public partial class KantoPage : ContentPage
    {
        public KantoPage()
        {
            InitializeComponent();
            ShowPokemonList();


        }

        private async Task ShowPokemonList()
        {
            Pokemon pokemons = await GetPokemonRepo.GetPokemonKantoAsync();
            lvwPokemon.ItemsSource = pokemons.Results;
        }

        private void lvwPokemon_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Result pokemon = lvwPokemon.SelectedItem as Result;
            if (pokemon == null) return;
            Navigation.PushAsync(new PokemonDetail(pokemon));
            lvwPokemon.SelectedItem = null;
        }
    }
}