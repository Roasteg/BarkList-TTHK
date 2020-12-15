using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dog7 : ContentPage
    {
        public Dog7()
        {
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            husk.GestureRecognizers.Add(tap);

        }

        private async void Tap_Tapped(object sender, EventArgs e)
        {
            var wiki = await DisplayAlert("Внимание!", "Сейчас будет открыта википедия, продолжить?", "Да", "Нет");
            if (wiki == true)
            {
                await Browser.OpenAsync("https://ru.wikipedia.org/wiki/Сибирский_хаски", BrowserLaunchMode.SystemPreferred);
            }
        }
    

        private void bark_Pressed(object sender, EventArgs e)
        {
            new StreamSound("HuskyBarking.mp3");
        }
    }
}