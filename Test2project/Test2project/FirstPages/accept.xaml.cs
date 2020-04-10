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
       
       public async void Accept(object sender,EventArgs e)
        {
            var code = taed1.Text;
            var codepatern= "^[0-9]*$";


            if(Regex.IsMatch(code, codepatern))
            {
                await Navigation.PushModalAsync(new wysp2());
                taed1.Text = string.Empty;
            }
             
            

            else
            {
                Person person = await App.Database.GetPeopleAsync();
              
                taed1.BackgroundColor = Color.Red;
                taed1.PlaceholderColor = Color.Black;
                
                taed1.Placeholder = "کد اشتباه";
                taed1.Text = string.Empty;
                Labelfaile.Text = person.Tel + "این شماره درست؟";
            }
               



           
        }
    }
}