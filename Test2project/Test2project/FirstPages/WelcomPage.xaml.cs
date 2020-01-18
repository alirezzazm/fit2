using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2project.FirstPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomPage : ContentPage
    {
       

        public WelcomPage()
        {

            InitializeComponent();
            Device.StartTimer(TimeSpan.FromMilliseconds(5000), () =>
            {
                Navigation.PushModalAsync(new WhatIsYourSexPage());
                return false;
            });




        }


    }
}