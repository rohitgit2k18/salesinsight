using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SalesInsight.Views
{
    public partial class LoginPage : ContentPage
    {
        
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new AppShell();
        }
    }
}
