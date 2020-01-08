using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2project.profile;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2project.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Me : ContentPage
    {
        public Me()
        {
            InitializeComponent();
        }
        public void profile(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new Pr1());
        }
    }
}