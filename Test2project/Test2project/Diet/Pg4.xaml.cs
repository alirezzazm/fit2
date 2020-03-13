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
    public partial class Pg4 : ContentPage
    {
        public Pg4()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_TappedforDietPg4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Pg3());
        }
    }
}