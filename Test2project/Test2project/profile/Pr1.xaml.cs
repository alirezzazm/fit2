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
            Person person = await App.Database.GetPeopleAsync();

            nameandfamily1.Text = person.Name;
            shomare1.Text = person.Tel;
            email1.Text = person.Email;
            age1.Text = person.Age;
            qad1.Text = person.Height;
            vazn1.Text = person.Weight;
            esm.Text = person.Name;
            axprofile1.Source = person.Image;






        }
    }
}