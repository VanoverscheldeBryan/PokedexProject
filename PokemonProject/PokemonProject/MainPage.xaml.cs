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
        public MainPage()
        {
            InitializeComponent();
        }

        private void Kanto_Clicked(object sender, EventArgs e)
        {
            NavigateToKanto();
        }

        private void NavigateToKanto()
        {
            Navigation.PushAsync(new KantoPage());

        }

        private void Johto_Clicked(object sender, EventArgs e)
        {
            NavigateToJohto();
        }

        private void NavigateToJohto()
        {
            Navigation.PushAsync(new JohtoPage());

        }

        private void Hoenn_Clicked(object sender, EventArgs e)
        {
            NavigateToHoenn();
        }

        private void NavigateToHoenn()
        {
            Navigation.PushAsync(new HoennPage());

        }
    }
}
