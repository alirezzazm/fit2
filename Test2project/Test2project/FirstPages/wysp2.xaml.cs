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
            public void MainPage(object sender,EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameandfamily.Text))
            {
                 App.Database.SavePersonAsync(new Person
                {
                    Name = nameandfamily.Text,
                   
                });

                nameandfamily.Text = string.Empty;
                

            }


            Navigation.PushModalAsync(new MainPage());
            
        }
       
    }
}