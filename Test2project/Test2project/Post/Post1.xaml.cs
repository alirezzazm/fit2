using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using SQLitePCL;
using Test2project.Data;
using Test2project;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace Test2project.Post
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Post1 : ContentPage
    {
       

        public Post1()
        {
           
            InitializeComponent();
        }

        private bool isOpen = false;
        private async void imagetab(object sender, EventArgs e)
        {

            //  Grid1.Opacity == "0.5";



            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller  
                await ((Image)sender).ScaleTo(1, 50, Easing.SinIn);
                //Wait a moment  

                //Scale to normal  
                await ((Image)sender).ScaleTo(1, 50, Easing.SinIn);

                display.IsVisible = false;


            }
            else
            {


                isOpen = false;
                //await scar
                //Scale to smaller  
                await ((Image)sender).ScaleTo(1, 50, Easing.Linear);
                //Wait a moment  

                //Scale to normal  
                await ((Image)sender).ScaleTo(1, 50, Easing.SpringIn);

                display.IsVisible = true;




            }

        }

        public async void axgereftan(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable
                || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":(No camera available.", "OK");
                return;

            }
            var file = await CrossMedia.Current.TakePhotoAsync(
                new StoreCameraMediaOptions
                {
                    Directory = "Test",
                    SaveToAlbum = false,
                    CompressionQuality = 75,
                    CustomPhotoSize = 50,
                    PhotoSize = PhotoSize.Custom,
                    MaxWidthHeight = 2000,
                    DefaultCamera = CameraDevice.Front



                });
            if (file == null)
                return;



            axpost.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                display.IsVisible = false;

                return stream;

            });



        }

        public async void gallery(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Oops", "Pick photo is not supported !", "OK");
                return;

            }
            var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,


            });

            if (file == null)
                return;



            axpost.Source = ImageSource.FromStream(() =>
            {

                var stream = file.GetStream();
                file.Dispose();
                display.IsVisible = false;
                return stream;


            });

        }



        public void comeback(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage ());
        }


        protected override bool OnBackButtonPressed()
        {
            return true;
        }



        public async void post(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new MainPage());

            if (!string.IsNullOrWhiteSpace(mozoe.Text)
                && string.IsNullOrWhiteSpace(tamrin.Text))
            {
                await App.Databasepost.SavePersonAsync(new PostData
                {
                    Mozoe = mozoe.Text,

                    Tamrin=tamrin.Text,

                });

                mozoe.Text = string.Empty;
                tamrin.Text = string.Empty;



            }

        }
    }
}