using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Plugin.SimpleAudioPlayer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dog : ContentPage
    {
        
        public Dog()
        {
            InitializeComponent();
            

        }
       
        private void bark_Pressed(object sender, EventArgs e)
        {
            var stream = GetStreamFromFile("DachhundBarking.mp3");
            var player = CrossSimpleAudioPlayer.Current;
            player.Load(stream);
            player.Play();
        }
         Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("MasterDetail.sounds." + filename);

            return stream;
        }
    }
}