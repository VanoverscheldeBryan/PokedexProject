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
            showType(pokemon);
        }

        private async Task showDetail(Result item)
        {
            var name = item.Name;

            PokemonDetails detail = await GetPokemonRepo.GetPokemonDetails(name);
            vwDetailWeight.Text = detail.Weight.ToString();
            vwImage.Source = detail.Sprites.FrontDefault;
            vwDetailType.Text = detail.Types.ToString();

        }
        private async Task showType(Result item)
        {
            var name = item.Name;

            TypeDetail detail = await GetPokemonRepo.GetPokemonDetails(name);
            vwDetailType.Text = detail.NameType;

        }



        private async Task LoadName(Result item)
        {
            lvwPokemon.Text = item.Name;

        }
    }
}