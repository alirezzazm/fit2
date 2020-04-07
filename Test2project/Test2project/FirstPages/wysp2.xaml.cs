﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test2project.profile;

using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;



using System.IO;

namespace Test2project.FirstPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class wysp2 : ContentPage
    {
        public wysp2()
        {
            
            InitializeComponent();


            
        }
        public void jensiyat( object sender,EventArgs e)
        {

            DisplayActionSheet("نوع جنسیت", "مرد", "زن");
        }
        public void MainPage(object sender, EventArgs e)
        {
            var ax = axprofile.Source.ToString();

            if (!string.IsNullOrWhiteSpace(nameandfamily.Text)
                && !string.IsNullOrWhiteSpace(shomare.Text)
                && !string.IsNullOrWhiteSpace(email.Text)
                 && !string.IsNullOrWhiteSpace(age.Text)
                 && !string.IsNullOrWhiteSpace(qad.Text)
                 && !string.IsNullOrWhiteSpace(vazn.Text)
                 && !string.IsNullOrWhiteSpace(file))
            {
                App.Database.SavePersonAsync(new Person
                {
                    Name = nameandfamily.Text,
                    
                    Email = email.Text,
                    Age = age.Text,
                    Height = qad.Text,
                    Weight = vazn.Text,
                  
                    Image = file,




                });

                nameandfamily.Text = string.Empty;
                shomare.Text = string.Empty;
                email.Text = string.Empty;
                age.Text = string.Empty;
                qad.Text = string.Empty;
                vazn.Text = string.Empty;
               


            }


            Navigation.PushModalAsync(new MainPage());

        }




        private bool isOpen = false;
        private string file;

        private async void imagetab(object sender, EventArgs e)
        {

          //  Grid1.Opacity == "0.5";
            
            
            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller  
                await((Image)sender).ScaleTo(0.1, 50, Easing.SinIn);
                //Wait a moment  
                
                //Scale to normal  
                await((Image)sender).ScaleTo(1, 50, Easing.SinIn);

                display.IsVisible = false;

            }
            else
            {


                isOpen = false;
                //await scar
                //Scale to smaller  
                await((Image)sender).ScaleTo(0.1, 50, Easing.Linear);
                //Wait a moment  
                
                //Scale to normal  
                await((Image)sender).ScaleTo(1, 50, Easing.Linear);

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
                    SaveToAlbum = true,
                    CompressionQuality = 75,
                    CustomPhotoSize = 50,
                    PhotoSize = PhotoSize.MaxWidthHeight,
                    MaxWidthHeight = 2000,
                    DefaultCamera = CameraDevice.Front



                });
            if (file == null)
                return;

           

            axprofile.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
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



            axprofile.Source = ImageSource.FromStream(() =>
            {
               
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });

        }




    }
}