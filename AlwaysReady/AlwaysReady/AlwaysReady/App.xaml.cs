using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlwaysReady
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage Nav = new NavigationPage(new MainPage());
            MainPage = Nav;
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
