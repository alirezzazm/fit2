using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test2project.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private bool isOpen = false;
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller  
                await ((Button)sender).ScaleTo(0.8, 50, Easing.Linear);
                //Wait a moment  
                await Task.Delay(100);
                //Scale to normal  
                await ((Button)sender).ScaleTo(1, 50, Easing.Linear);

                //Show FloatMenuItem1  
                Fab1.IsVisible = true;
                await Fab1.TranslateTo(0, 0, 100);
                await Fab1.TranslateTo(0, -20, 100);
                await Fab1.TranslateTo(0, 0, 200);

                //Show FloatMenuItem2  
                Fab2.IsVisible = true;
                await Fab2.TranslateTo(0, 0, 100);
                await Fab2.TranslateTo(0, -20, 100);
                await Fab2.TranslateTo(0, 0, 200);

                //Show FloatMenuItem3  
                Fab3.IsVisible = true;
                await Fab3.TranslateTo(0, 0, 100);
                await Fab3.TranslateTo(0, -20, 100);
                await Fab3.TranslateTo(0, 0, 200);
            }
            else
            {
                isOpen = false;
                //Scale to smaller  
                await ((Button)sender).ScaleTo(0.8, 50, Easing.Linear);
                //Wait a moment  
                await Task.Delay(100);
                //Scale to normal  
                await ((Button)sender).ScaleTo(1, 50, Easing.Linear);

                //Hide FloatMenuItem1  
                await Fab1.TranslateTo(0, 0, 100);
                await Fab1.TranslateTo(0, -20, 100);
                await Fab1.TranslateTo(0, 0, 200);
                Fab1.IsVisible = false;

                //Hide FloatMenuItem2  
                await Fab2.TranslateTo(0, 0, 100);
                await Fab2.TranslateTo(0, -20, 100);
                await Fab2.TranslateTo(0, 0, 200);
                Fab2.IsVisible = false;

                //Hide FloatMenuItem3  
                await Fab3.TranslateTo(0, 0, 100);
                await Fab3.TranslateTo(0, -20, 100);
                await Fab3.TranslateTo(0, 0, 200);
                Fab3.IsVisible = false;

            }
        }
    }
}