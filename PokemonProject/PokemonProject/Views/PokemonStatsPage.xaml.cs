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
        public Result pokemon { get; set; }
        public PokemonStatsPage(Result pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            showDetail(pokemon);

        }

        private async Task showDetail(Result pokemon)
        {
            var name = pokemon.Name;

            PokemonDetails detail = await GetPokemonRepo.GetPokemonDetails(name);

            lvstatHp.Text = detail.Stats[0].StatStat.Name;
            lvstatAttack.Text = detail.Stats[1].StatStat.Name;
            lvstatDefence.Text = detail.Stats[2].StatStat.Name;
            lvstatSpecialAtt.Text = detail.Stats[3].StatStat.Name;
            lvstatSpecialDef.Text = detail.Stats[4].StatStat.Name;
            lvstatSpeed.Text = detail.Stats[5].StatStat.Name;
            lvstatHpx.Text = detail.Stats[0].BaseStat.ToString();
            lvstatAttackx.Text = detail.Stats[1].BaseStat.ToString();
            lvstatDefencex.Text = detail.Stats[2].BaseStat.ToString();
            lvstatSpecialAttx.Text = detail.Stats[3].BaseStat.ToString();
            lvstatSpecialDefx.Text = detail.Stats[4].BaseStat.ToString();
            lvstatSpeedx.Text = detail.Stats[5].BaseStat.ToString();
        }

        private void btnnavBack_Clicked(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            Navigation.PopAsync();

        }
    }
}