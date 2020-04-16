using System;
using Xamarin.Forms;
using System.IO;

using Test2project.FirstPages;
using Test2project.Post;
using Test2project.profile;
using Test2project.Diet;
using SQLite;
using SQLitePCL;
using System.Threading.Tasks;
using System.Collections.Generic;
using Test2project;
using Xamarin.Forms.Xaml;
using Test2project.Setting;

namespace Test2project
{

    public partial class App : Application
    {
        static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
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
