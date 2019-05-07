using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using Xamarin.Forms;

namespace Group13
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Navigate();
        }

        private async void Navigate()
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
