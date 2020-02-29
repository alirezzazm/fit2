using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2project.FirstPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class accept : ContentPage
    {
        public accept()
        {
            InitializeComponent();
        }
        async void Accept(object sender,EventArgs e)
        {
            await Navigation.PushModalAsync(new wysp2());
        }
    }
}