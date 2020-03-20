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
 
        private bool isOpen = false;

        private async void mavad(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller  
                await ((Grid)sender).ScaleTo(0.1, 50, Easing.SinIn);
                //Wait a moment  
                await Task.Delay(0);
                //Scale to normal  
                await ((Grid)sender).ScaleTo(1, 50, Easing.SinIn);

                Bt2.IsVisible = false;

            }
            else
            {


                isOpen = false;
                //await scar
                //Scale to smaller  
                await ((Grid)sender).ScaleTo(0.1, 50, Easing.Linear);
                //Wait a moment  
                await Task.Delay(0);
                //Scale to normal  
                await ((Grid)sender).ScaleTo(1, 50, Easing.Linear);

                Bt2.IsVisible = true;




            }
        }
        private async void khavas(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller  
                await ((Grid)sender).ScaleTo(0.1, 50, Easing.SinIn);
                //Wait a moment  
                await Task.Delay(0);
                //Scale to normal  
                await ((Grid)sender).ScaleTo(1, 50, Easing.SinIn);

                Bt1.IsVisible = false;

            }
            else
            {


                isOpen = false;
                //await scar
                //Scale to smaller  
                await ((Grid)sender).ScaleTo(0.1, 50, Easing.Linear);
                //Wait a moment  
                await Task.Delay(0);
                //Scale to normal  
                await ((Grid)sender).ScaleTo(1, 50, Easing.Linear);

                Bt1.IsVisible = true;




            }
        }

    }
}