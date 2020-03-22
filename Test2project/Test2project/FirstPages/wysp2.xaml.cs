using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test2project.profile;

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
            if (!string.IsNullOrWhiteSpace(nameandfamily.Text)
                && !string.IsNullOrWhiteSpace(shomare.Text)
                && !string.IsNullOrWhiteSpace(email.Text)
                 && !string.IsNullOrWhiteSpace(age.Text)
                 && !string.IsNullOrWhiteSpace(qad.Text)
                 && !string.IsNullOrWhiteSpace(vazn.Text))
            {
                App.Database.SavePersonAsync(new Person
                {
                    Name = nameandfamily.Text,
                    Tel = shomare.Text,
                    Email = email.Text,
                    Age = age.Text,
                    Height = qad.Text,
                    Weight = vazn.Text,




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
        private async void imagetab(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller  
                await((Image)sender).ScaleTo(0.1, 50, Easing.SinIn);
                //Wait a moment  
                await Task.Delay(0);
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
                await Task.Delay(0);
                //Scale to normal  
                await((Image)sender).ScaleTo(1, 50, Easing.Linear);

                display.IsVisible = true;




            }

        }

        public void axgereftan(object sender,EventArgs e)
        {
           // Device.OpenUri
        }

        public void gallery(object sender, EventArgs e)
        {

        }




    }
}