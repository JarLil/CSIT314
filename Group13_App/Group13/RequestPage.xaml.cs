using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace Group13
{
    public partial class RequestPage : ContentPage
    {
        public RequestPage()
        {
            InitializeComponent();

            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void PrevPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        public async void SubmitRequest(object sender, EventArgs e)
        {
            CarMakePicker.BackgroundColor = FieldChecks.CheckPicker(CarMakePicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            CarModelPicker.BackgroundColor = FieldChecks.CheckPicker(CarModelPicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            CarColourPicker.BackgroundColor = FieldChecks.CheckPicker(CarColourPicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            CarRegistration.BackgroundColor = FieldChecks.isNotNull(CarRegistration.Text) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            ServicePicker.BackgroundColor = FieldChecks.CheckPicker(ServicePicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");

            if (CarMakePicker.BackgroundColor == Color.FromHex("#0BDA51"))
            {
                if (CarModelPicker.BackgroundColor == Color.FromHex("#0BDA51"))
                {
                    if (CarColourPicker.BackgroundColor == Color.FromHex("#0BDA51"))
                    {
                        if (CarRegistration.BackgroundColor == Color.FromHex("#0BDA51"))
                        {
                            if (ServicePicker.BackgroundColor == Color.FromHex("#0BDA51"))
                            {
                                App.ReqID++; 
                                string line = "CREQ" + App.ReqID + " " + App.CURRENTUSERID + " " + CarMakePicker.SelectedItem + " " + CarModelPicker.SelectedItem + " " + CarColourPicker.SelectedItem + " " + CarRegistration.Text + " " + ServicePicker.SelectedItem + " " + LocationPicker.SelectedItem + " " + "PENDING";

                                System.Diagnostics.Debug.Write(line);

                                //Need to write line to text file here!!!

                                await DisplayAlert("Success", "Request Successfully submitted", "Ok");
                                await Navigation.PopAsync();
                            }
                            else
                            {
                                await DisplayAlert("Error", "Invalid Service", "Ok");
                            }
                        }
                        else
                        {
                            await DisplayAlert("Error", "Invalid Car Registration", "Ok");
                        }
                    }
                    else
                    {
                        await DisplayAlert("Error", "Invalid Car Colour", "Ok");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Invalid Car Model", "Ok");
                }
            }
            else
            {
                await DisplayAlert("Error", "Invalid Car Make", "Ok");
            }
        }

        public void PopulatePicker(object sender, EventArgs e)
        {
            CarModelPicker.Items.Clear();

            if (CarMakePicker.SelectedItem == "HONDA")
            {
                CarModelPicker.Items.Add("CIVIC");
                CarModelPicker.Items.Add("ACCORD");
                CarModelPicker.Items.Add("CRV");
                CarModelPicker.Items.Add("ODYSSEY");
                CarModelPicker.Items.Add("CRZ");
            }
            else if (CarMakePicker.SelectedItem == "HOLDEN")
            {
                CarModelPicker.Items.Add("BARINA");
                CarModelPicker.Items.Add("ASTRA");
                CarModelPicker.Items.Add("COMMODORE");
                CarModelPicker.Items.Add("COLORADO");
                CarModelPicker.Items.Add("TRAX");
            }
            else if (CarMakePicker.SelectedItem == "FORD")
            {
                CarModelPicker.Items.Add("MUSTANG");
                CarModelPicker.Items.Add("FIESTA");
                CarModelPicker.Items.Add("FOCUS");
                CarModelPicker.Items.Add("EXPLORER");
                CarModelPicker.Items.Add("RANGER");
            }
            else if (CarMakePicker.SelectedItem == "MAZDA")
            {
                CarModelPicker.Items.Add("3");
                CarModelPicker.Items.Add("6");
                CarModelPicker.Items.Add("MX5");
                CarModelPicker.Items.Add("CX5");
                CarModelPicker.Items.Add("RX8");
            }
            else if (CarMakePicker.SelectedItem == "SUBARU")
            {
                CarModelPicker.Items.Add("FORESTER");
                CarModelPicker.Items.Add("IMPREZA");
                CarModelPicker.Items.Add("OUTBACK");
                CarModelPicker.Items.Add("ASCENT");
                CarModelPicker.Items.Add("LEGACY");
            }
            else if (CarMakePicker.SelectedItem == "AUDI")
            {
                CarModelPicker.Items.Add("A7");
                CarModelPicker.Items.Add("Q5");
                CarModelPicker.Items.Add("A3");
                CarModelPicker.Items.Add("A1");
                CarModelPicker.Items.Add("Q3");
            }
            else if (CarMakePicker.SelectedItem == "PORSCHE")
            {
                CarModelPicker.Items.Add("911");
                CarModelPicker.Items.Add("CAYENNE");
                CarModelPicker.Items.Add("MACAN");
                CarModelPicker.Items.Add("PANAMERA");
                CarModelPicker.Items.Add("718");
            }
            else if (CarMakePicker.SelectedItem == "SUZUKI")
            {
                CarModelPicker.Items.Add("SWIFT");
                CarModelPicker.Items.Add("ALTO");
                CarModelPicker.Items.Add("CULTUS");
                CarModelPicker.Items.Add("XL7");
                CarModelPicker.Items.Add("KIZASHI");
            }
            else if (CarMakePicker.SelectedItem == "TOYOTA")
            {
                CarModelPicker.Items.Add("YARIS");
                CarModelPicker.Items.Add("COROLLA");
                CarModelPicker.Items.Add("PRIUS");
                CarModelPicker.Items.Add("CAMRY");
                CarModelPicker.Items.Add("AVALON");
            }
            else if (CarMakePicker.SelectedItem == "MITSUBISHI")
            {
                CarModelPicker.Items.Add("OUTLANDER");
                CarModelPicker.Items.Add("ECLIPSE");
                CarModelPicker.Items.Add("MIRAGE");
                CarModelPicker.Items.Add("LANCER");
                CarModelPicker.Items.Add("ENDEAVOR");
            }
        }
    }
}
