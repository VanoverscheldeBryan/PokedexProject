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
    public partial class PokemonDetail : ContentPage
    {

        public Result pokemon;
        public PokemonDetail(Result pokemon)
        {
            InitializeComponent();
    
            LoadName(pokemon);

            showDetail(pokemon);
        }

        private async Task showDetail(Result item)
        {
            var name = item.Name;

            PokemonDetails detail = await GetPokemonRepo.GetPokemonDetails(name);
            lvwDetail.Text = detail.Weight.ToString();
            vwImage.Source = detail.Sprites.FrontDefault;


        }

        private async Task LoadName(Result item)
        {
            lvwPokemon.Text = item.Name;

        }
    }
}