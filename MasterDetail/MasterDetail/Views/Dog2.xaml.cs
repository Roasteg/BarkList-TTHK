﻿using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dog2 : ContentPage
    {
        public Dog2()
        {
            InitializeComponent();
        }

        private void bark_Pressed(object sender, EventArgs e)
        {
            new StreamSound("GermanShepherd.mp3");
        }
    }
}