using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2project.Diet;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2project.Diet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pg1 : ContentPage
    {
        public Pg1()
        {
            InitializeComponent();
        }
        public void NextPg2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pg2());
        }

        private void TapGestureRecognizer_TappedforDietPg1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}