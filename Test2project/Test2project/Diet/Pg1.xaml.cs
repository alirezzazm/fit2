using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2project.Diet;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.ComponentModel;


namespace Test2project.Diet
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pg1 : ContentPage
    {
        List<Microcharts.Entry> entries = new List<Microcharts.Entry>
        {
            new Microcharts.Entry(200)
            {
                Color=SKColor.Parse("#ff1493"),
                Label="january",
                ValueLabel="200"
            },
             new Microcharts.Entry(400)
            {
                Color=SKColor.Parse("#00bfff"),
                Label="February",
                ValueLabel="400"
            },
              new Microcharts.Entry(-100)
            {
                Color=SKColor.Parse("#00ced1"),
                Label="March",
                ValueLabel="-100"
            },


        };

        public Pg1()
        {
            InitializeComponent();
            Chart1.Chart = new BarChart { Entries = entries };
        }
        public void NextPg2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pg2());
        }

        private async void TapGestureRecognizer_TappedforDietPg1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
           
        }
       
        protected override bool OnBackButtonPressed()
        {

           return true;
        }
    }
}