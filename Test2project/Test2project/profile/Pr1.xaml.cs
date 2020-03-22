using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using SQLite;
using SQLitePCL;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test2project;


namespace Test2project.profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pr1 : ContentPage
    {
        
        public Pr1()
        {
            InitializeComponent();
            
            
        }

        public void TapGestureRecognizer_TappedforPr1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //listView.ItemsSource = await App.Database.GetPeopleAsync();
            nameandfamily1.Text = await App.Database.GetPeopleAsync();


        }
    }
}