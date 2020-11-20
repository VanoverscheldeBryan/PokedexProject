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
    public partial class PokemonStatsPage : ContentPage
    {
        public Result pokemon;
        public PokemonStatsPage()
        {
            InitializeComponent();


            showDetail(pokemon);
        }

        private async Task showDetail(Result item)
        {
            var name = item.Name;

            PokemonDetails detail = await GetPokemonRepo.GetPokemonDetails(name);

           
            //lvStats.ItemsSource = detail.Stats[0].StatStat.Name;
            //lvStats.ItemsSource = detail.Stats[0].BaseStat.ToString();
        }

    }
}