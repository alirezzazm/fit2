using System;
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
        public async void  jensiyat(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("نوع جنسیت", "", "", "زن", "مرد"); 
           jensiyatName.Text = response;

            
        }
        public void MainPage(object sender, EventArgs e)
        {
            Person person = new Person();
           

            if (!string.IsNullOrWhiteSpace(nameandfamily.Text)
                && !string.IsNullOrWhiteSpace(shomare.Text)
                && !string.IsNullOrWhiteSpace(email.Text)
                 && !string.IsNullOrWhiteSpace(age.Text)
                 && !string.IsNullOrWhiteSpace(qad.Text)
                 && !string.IsNullOrWhiteSpace(vazn.Text)
                 && !string.IsNullOrWhiteSpace(file)
                 && !string.IsNullOrWhiteSpace(jensiyatName.Text))
            {
                person.Name = nameandfamily.Text;
                person.Sex = jensiyatName.Text;
                person.Email = email.Text;
                person.Age = age.Text;
                person.Height = qad.Text;
                person.Weight = vazn.Text;
                person.Image = file;
                App.Database.UpdatePersonAsync(person);

                


                //App.Database.SavePersonAsync(new Person
                //{
                //    Name = nameandfamily.Text,
                //    Sex =jensiyatName.Text,
                //    Email = email.Text,
                //    Age = age.Text,
                //    Height = qad.Text,
                //    Weight = vazn.Text,
                  
                //    Image = file,




                //});

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
        public  string file;

        private async void imagetab(object sender, EventArgs e)
        {

          //  Grid1.Opacity == "0.5";
            


            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller  
                await((Image)sender).ScaleTo(1, 50, Easing.SinIn);
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
                await((Image)sender).ScaleTo(1, 50, Easing.Linear);
                //Wait a moment  
                
                //Scale to normal  
                await((Image)sender).ScaleTo(1, 50,Easing.SpringIn);

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

           

            axprofile.Source = ImageSource.FromStream(() =>
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



            axprofile.Source = ImageSource.FromStream(() =>
            {
               
                var stream = file.GetStream();
                file.Dispose();
                display.IsVisible = false;
                return stream;
              

            });

        }




    }
}