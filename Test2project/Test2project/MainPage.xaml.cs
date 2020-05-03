using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2project.profile;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Test2project.Post;
using Test2project.Setting;
using Test2project.Diet;
using Test2project.Data;
using Test2project.Models;
using Test2project;
using SQLite;
using SQLitePCL;
using SkiaSharp;
using Microcharts;

using Xamarin.Forms.Xaml;


using Xamarin.Essentials;
using Urho;
using Urho.Forms;


namespace Test2project
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        FaddyModels monkeyDo;
        List<Microcharts.Entry> chart = new List<Microcharts.Entry>
        {
            new Microcharts.Entry(100)
            {
                Color=SKColor.Parse("#ff1493"),
                Label="january",
                ValueLabel="200"
            },
             new Microcharts.Entry(300)
            {
                Color=SKColor.Parse("#00bfff"),
                Label="February",
                ValueLabel="400"
            },
              new Microcharts.Entry(20)
            {
                Color=SKColor.Parse("#00ced1"),
                Label="March",
                ValueLabel="-100"
            },


        };
        public MainPage()
        {
          // Chart2.Chart = new LineChart { Entries = chart };
            
            InitializeComponent();
            //  On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            //خرسه
            OrientationSensor.ReadingChanged += (sender, args) =>
            {
                System.Numerics.Quaternion q = args.Reading.Orientation;

                // Convert to Urho Quaternion, and swap Y and Z values to 
                //  convert from right-hand to left-hand coordinates.
                monkeyDo.Orientation = new Quaternion(q.X, q.Z, q.Y, q.W);
            };
            //خرسه

        }
        private bool isOpen = false;
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller  
                await ((Image)sender).ScaleTo(0.1, 50, Easing.Linear);
                //Wait a moment  
                await Task.Delay(0);
                //Scale to normal  
                await ((Image)sender).ScaleTo(1, 50, Easing.Linear);

                Fab.IsVisible = false;
                //await Fab.TranslateTo(0, 0, 100);
                //await Fab.TranslateTo(0, -20, 100);
                //await Fab.TranslateTo(0, 0, 200);
                //Show FloatMenuItem1  
                Fab1.IsVisible = true;
                //await Fab1.TranslateTo(0, 0, 100);
                //await Fab1.TranslateTo(0, -20, 100);
                //await Fab1.TranslateTo(0, 0, 200);

                //Show FloatMenuItem2  
                Fab2.IsVisible = true;
                //await Fab2.TranslateTo(0, 0, 100);
                //await Fab2.TranslateTo(0, -20, 100);
                //await Fab2.TranslateTo(0, 0, 200);

                //Show FloatMenuItem3  
                Fab3.IsVisible = true;
                //await Fab3.TranslateTo(0, 0, 100);
                //await Fab3.TranslateTo(0, -20, 100);
                //await Fab3.TranslateTo(0, 0, 200);

                Fab4.IsVisible = true;
                //await Fab4.TranslateTo(0, 0, 100);
                //await Fab4.TranslateTo(0, -20, 100);
                //await Fab4.TranslateTo(0, 0, 200);
            }
            else
            {


                isOpen = false;
                //await scar
                //Scale to smaller  
                await ((Image)sender).ScaleTo(0.1, 50, Easing.Linear);
                //Wait a moment  
                await Task.Delay(0);
                //Scale to normal  
                await ((Image)sender).ScaleTo(1, 50, Easing.Linear);

                Fab.IsVisible = true;
                //await Fab.TranslateTo(0, 0, 100);
                //await Fab.TranslateTo(0, -20, 100);
                //await Fab.TranslateTo(0, 0, 200);

                //Hide FloatMenuItem1  
                //await Fab1.TranslateTo(0, 0, 100);
                //await Fab1.TranslateTo(0, -20, 100);
                //await Fab1.TranslateTo(0, 0, 200);
                Fab1.IsVisible = false;

                //Hide FloatMenuItem2  
                //await Fab2.TranslateTo(0, 0, 100);
                //await Fab2.TranslateTo(0, -20, 100);
                //await Fab2.TranslateTo(0, 0, 200);
                Fab2.IsVisible = false;

                //Hide FloatMenuItem3  
                //await Fab3.TranslateTo(0, 0, 100);
                //await Fab3.TranslateTo(0, -20, 100);
                //await Fab3.TranslateTo(0, 0, 200);
                Fab3.IsVisible = false;


                //await Fab4.TranslateTo(0, 0, 100);
                //await Fab4.TranslateTo(0, -20, 100);
                //await Fab4.TranslateTo(0, 0, 200);
                Fab4.IsVisible = false;



            }
        }
        public void Post(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new Post1());
        }

        public void Profile(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new Pr1());
        }
         public void Setting(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new Pg1Setting());
        }
         public  void Diet(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new Pg1());
        }
        private async void Notif_Open(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller  
                await ((Image)sender).ScaleTo(0.1, 50, Easing.SinIn);
                //Wait a moment  
                await Task.Delay(0);
                //Scale to normal  
                await ((Image)sender).ScaleTo(1, 50, Easing.SinIn);

                Notif.IsVisible = false;

            }
            else
            {


                isOpen = false;
                //await scar
                //Scale to smaller  
                await ((Image)sender).ScaleTo(0.1, 50, Easing.Linear);
                //Wait a moment  
                await Task.Delay(0);
                //Scale to normal  
                await ((Image)sender).ScaleTo(1, 50, Easing.Linear);

                Notif.IsVisible = true;




            }
        }
        public void ChangeIcon(object sender, Syncfusion.XForms.TabView.SelectionChangedEventArgs e)
        {
         // Tab1.ImageSource.
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        protected override async void OnAppearing()
        {
            //خرسه
            base.OnAppearing();

            monkeyDo = await urhoSurface.Show<FaddyModels>(new ApplicationOptions(assetsFolder: "DataFaddyModels"));

            try
            {
                OrientationSensor.Start(SensorSpeed.Default);
            }
            catch
            {
                Content = new Label
                {
                    Text = "Sorry, the OrientationSensor is not supported on this device.",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    Margin = new Thickness(50)
                };
            }
            //خرسه








            //  var amc = await App.Database.GetPeopleAsync();



            //try
            //{

            //    foreach (Person creatstack1 in amc)
            //    {


            //        stackpost2.Children.Add(stackpost);




            //    }

            //}

            //catch
            //{
            //    mozoe1.Text = string.Empty;
            //}

        }

        //خرسه
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            OrientationSensor.Stop();
            UrhoSurface.OnDestroy();
        }
        //خرسه






    }
}
