using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (s, e) => OnLabelClicked();

            Click_Text.GestureRecognizers.Add(tgr);

        }

        public async void Next_Page(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Second_Page());
        }

        public async void OnLabelClicked()
        {
           var action = await DisplayAlert("Clicked", "Did you click the text?", "Yes", "No");
            if (action)
            {
                Change_Label.Text = "You changed me!";
            }
            else
            {
                await DisplayAlert("error", "You chose no..", "Ok");
            }
        }
    }
}
