using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2project.profile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pr1 : ContentPage
    {
        
        public Pr1()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_TappedforPr1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}