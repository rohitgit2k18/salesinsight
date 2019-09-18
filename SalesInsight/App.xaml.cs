using System;
using SalesInsight.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SalesInsight
{
    public partial class App : Application
    {
        public static  NavigationPage NavigationPage { get;  set; }
        public App()
        {
            InitializeComponent();
            //NavigationPage = new NavigationPage(new LoginPage());
            //MainPage = NavigationPage;
            // MainPage = new AppShell();
            MainPage = new LoginPage();
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
