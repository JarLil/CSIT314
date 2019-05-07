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
    }
}
