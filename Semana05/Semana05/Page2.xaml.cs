﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs)
        {
            Navigation.PopAsync();
        }
        private void Button_Clicked_1(object sender,)
        {

        }
    }
}