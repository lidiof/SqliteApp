using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SqliteApp.DataBase;
using System.IO;
using SqliteApp.Views;

namespace SqliteApp
{
    public partial class App : Application
    {
       static DataBase.DataBase sqlitedata;

        public static DataBase.DataBase Sqlitedata
        {
            get
            {
                if (sqlitedata == null)
                {
                    sqlitedata = new DataBase.DataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Company1.db3"));
                }
                return sqlitedata;
            }
        }
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
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
