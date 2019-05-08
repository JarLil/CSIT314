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

            for (int i=0; i < App.UsersArray.Count; i++)
            {
                if (App.UsersArray[i].userId == App.CURRENTUSERID)
                {
                    nameLabel.Text = App.UsersArray[i].fName + " " + App.UsersArray[i].lName;
                    emailLabel.Text = App.UsersArray[i].email;
                    subscriptionLabel.Text = App.UsersArray[i].subscription;
                    carMakeLabel.Text = App.UsersArray[i].carMake;
                    carModelLabel.Text = App.UsersArray[i].carModel;
                    carColourLabel.Text = App.UsersArray[i].carColour;
                    carRegoLabel.Text = App.UsersArray[i].registration;
                    carTransLabel.Text = App.UsersArray[i].transmission;
                    carCylLabel.Text = App.UsersArray[i].cylinders;
                }
            }
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
