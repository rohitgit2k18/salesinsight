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
            string userName = xfEntUserName.Text;
            string password = xfEntPassword.Text;
            if(string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                DisplayAlert("Info", "Please type something in  user and password filed !", "OK");
            }
            else
            {
                App.Current.MainPage = new AppShell();
            }
            
        }
    }
}
