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
    public partial class Pg3 : ContentPage
    {
        public Pg3()
        {
            InitializeComponent();
        }
        public void NextPg4(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new Pg4());
        }

        private void TapGestureRecognizer_TappedforDietPg3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pg2());
        }
    }
}