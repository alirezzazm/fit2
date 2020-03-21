using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


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
    }
}