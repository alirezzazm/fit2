using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2project.FirstPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FitDataBase.ModelFitDataBase;

namespace Test2project.FirstPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WhatIsYourSexPage : ContentPage
    {

        public WhatIsYourSexPage()
        {
            InitializeComponent();
        }



        async void NextPage(object sender, EventArgs e)
       {
            //var fit = (Fit)BindingContext;
            //fit.Date = DateTime.UtcNow;
            //await App.DataBase.SaveFitAsync(fit);
            Navigation.PushModalAsync(new Page3());

        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("What's the value?","kg", "ok");
        //}
        public void Button_Clicked(object sender, EventArgs e)
        {

            DisplayActionSheet("What's the value?", "", "", "kg", "cup");

            //if (DisplayActionSheet.Click == "kg")
            //{
            //    _ = Button1.Text == "kg";
            //    _ = Entry1.Text == "kg";

            //}
            //else if (action == "cup")
            //{
            //    _ = Button1.Text == "cup";
            //    _ = Entry1.Text == "cup";
            //}
            //else
            //{
            //    return;
            //}


        }

        public void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayActionSheet("what s sex?", "", "", "Men", "Women");

        }
  
        public void Button_Clicked_2(object sender, EventArgs e)
        {
            DisplayActionSheet("?", "", "", "cm", "m");

        }

        public void BoxView_tap1(object sender, EventArgs e)
        {
            BoxView1.Color = Color.Black;
            BoxView2.Color = Color.White;
            BoxView3.Color = Color.White;
            BoxView4.Color = Color.White;
            //if (BoxView1.Color == Color.Black)
            //{
            //    sender()
            //}

        }
        public void BoxView_tap2(object sender, EventArgs e)
        {
            BoxView1.Color = Color.White;
            BoxView2.Color = Color.Black;
            BoxView3.Color = Color.White;
            BoxView4.Color = Color.White;

        }
        public void BoxView_tap3(object sender, EventArgs e)
        {
            BoxView1.Color = Color.White;
            BoxView2.Color = Color.White;
            BoxView3.Color = Color.Black;
            BoxView4.Color = Color.White;

        }
        public void BoxView_tap4(object sender, EventArgs e)
        {
            BoxView1.Color = Color.White;
            BoxView2.Color = Color.White;
            BoxView3.Color = Color.White;
            BoxView4.Color = Color.Black;

        }
       

        public void BoxView_tap5(object sender, EventArgs e)
        {
            BoxView5.Color = Color.Black;
            BoxView6.Color = Color.White;
            BoxView7.Color = Color.White;
            BoxView8.Color = Color.White;

        }
        public void BoxView_tap6(object sender, EventArgs e)
        {
            BoxView5.Color = Color.White;
            BoxView6.Color = Color.Black;
            BoxView7.Color = Color.White;
            BoxView8.Color = Color.White;

        }
        public void BoxView_tap7(object sender, EventArgs e)
        {
            BoxView5.Color = Color.White;
            BoxView6.Color = Color.White;
            BoxView7.Color = Color.Black;
            BoxView8.Color = Color.White;

        }
        public void BoxView_tap8(object sender, EventArgs e)
        {
            BoxView5.Color = Color.White;
            BoxView6.Color = Color.White;
            BoxView7.Color = Color.White;
            BoxView8.Color = Color.Black;

        }

    }
}