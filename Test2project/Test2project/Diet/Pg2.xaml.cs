using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2project.Diet
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pg2 : ContentPage
    {
        public Pg2()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_TappedforDietPg2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pg1());
        }
         private void NextPg3(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new Pg3());
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}