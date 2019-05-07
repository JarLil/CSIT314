using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Group13
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (s, e) => ToRegisterPage();
            RegisterLabel.GestureRecognizers.Add(tgr);
        }

        private async void Login_Check(object sender, EventArgs e)
        {
            //if (Username.Text != null /* Change to check array for username */ && Password.Text != null /*Change to check array for password*/)
            //{
                await Navigation.PushAsync(new HomePage());
            //}
            //else
            //{
            //   await DisplayAlert("Error", "User not found. Please register for a new account", "Ok");
            //}
        }

        public async void ToRegisterPage()
        {
            await Navigation.PushAsync(new Registration.UserDetails());
        }
    }
}
