using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Group13
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void GoToRequest (Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RequestPage());
        }

        public async void GoToMyRequests(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyRequests());
        }

        public async void GoToServicesWeProvide(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }

        public async void GoToMyAccount(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyAccount());
        }

        public async void GoToContactUs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }
    }
}
