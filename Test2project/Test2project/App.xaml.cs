using System;
using Test2project.FirstPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using FitDataBase.Data;
using System.Threading.Tasks;

namespace Test2project
{

    public partial class App : Application
    {
        static FitDatabase database;
        public static FitDatabase DataBase
        {
            get
           {
               if(database==null)
               {
                   database= new  FitDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Fitdata.db3"));
               }
                return database;
            }
        }
         
        public App()
        {
            InitializeComponent();

            MainPage = new WelcomPage();
           
          
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
