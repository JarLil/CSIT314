using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Group13
{
    public partial class MyAccount : ContentPage
    {
        public MyAccount()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            nameLabel.Text = App.CURRENTUSERFNAME + " " + App.CURRENTUSERLNAME;
            emailLabel.Text = App.CURRENTUSEREMAIL;
            subscriptionLabel.Text = App.CURRENTUSERSUBSCRIPTION;
            carMakeLabel.Text = App.CURRENTUSERCARMAKE;
            carModelLabel.Text = App.CURRENTUSERCARMODEL;
            carColourLabel.Text = App.CURRENTUSERCARCOLOUR;
            carRegoLabel.Text = App.CURRENTUSERREGISTRATION;
            carTransLabel.Text = App.CURRENTUSERTRANSMISSION;
            carCylLabel.Text = App.CURRENTUSERCYLINDERS;

        }

        public async void GoBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        public async void EditDetails(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditDetails());
        }
    }
}
