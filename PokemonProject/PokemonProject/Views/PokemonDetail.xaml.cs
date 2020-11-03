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
    public partial class PokemonDetail : ContentPage
    {

        public Result pokemon;
        public PokemonDetail(Result pokemon)
        {
            InitializeComponent();
    
            LoadName(pokemon);
        }

        private void LoadName(Result item)
        {
            lvwPokemon.Text = item.Name;
        }
    }
}