﻿using System;
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
            new StreamSound("CorgiBarking.mp3");
        }
        
    }
}