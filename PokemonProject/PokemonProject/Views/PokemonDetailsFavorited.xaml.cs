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
    public partial class PokemonDetailsFavorited : ContentPage
    {
        public Result pokemon;

        public PokemonDetailsFavorited(Result pokemon)
        {
            this.pokemon = pokemon;
            InitializeComponent();

            LoadName(pokemon);

            showDetail(pokemon);
        }

        private async Task showDetail(Result item)
        {
            var name = item.Name;

            PokemonDetails detail = await GetPokemonRepo.GetPokemonDetails(name);

            vwDetailWeight.Text = detail.Weight.ToString();
            vwImage.Source = detail.Sprites.FrontDefault;
            vwDetailType.Text = detail.Types[0].TypeDetail.NameType;
            vwDetailAbility.Text = detail.Abilities[0].AbilityAbility.Name;
            //lvStats.ItemsSource = detail.Stats[0].StatStat.Name;
            //lvStats.ItemsSource = detail.Stats[0].BaseStat.ToString();
        }
        private async Task LoadName(Result item)
        {
            lvwPokemon.Text = item.Name;

        }
        private void btnNavBack_Clicked(object sender, EventArgs e)
        {
            goBack();
        }
        private void goBack()
        {
            Navigation.PopAsync();
        }


        private void btnStats_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PokemonStatsPage(pokemon));

        }

        private void deleteFav_Clicked(object sender, EventArgs e)
        {
            GetPokemonRepo.removeFromFavorites(pokemon);
            Navigation.PopAsync();
            Navigation.PopAsync();
            DisplayAlert("Bye bye :(", "Pokemon removed from favorites", "Close");
         

        }
    }
}