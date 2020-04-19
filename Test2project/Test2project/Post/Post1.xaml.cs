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

namespace Test2project.Post
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Post1 : ContentPage
    {
       

        public Post1()
        {
           
            InitializeComponent();
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
                await App.Database.SavePostDataAsync(new PostData
                {
                    Mozoe = mozoe.Text,

                    //Tamrin=tamrin.Text,

                });

                mozoe.Text = string.Empty;
                tamrin.Text = string.Empty;



            }

        }
    }
}