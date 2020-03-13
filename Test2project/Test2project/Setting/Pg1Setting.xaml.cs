using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2project.Setting
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pg1Setting : ContentPage
    {
        public Pg1Setting()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tappedforsetting(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}