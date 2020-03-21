using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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
       public void Accept(object sender,EventArgs e)
        {
            var code = taed1.Text;
            var codepatern= "^[0-9]*$";


            if(Regex.IsMatch(code, codepatern))
            {
                Navigation.PushModalAsync(new wysp2());
            }
             
            

            else
            {
                taed1.Text = "";
                taed1.Placeholder = "کد اشتباه";
            }
               



           
        }
    }
}