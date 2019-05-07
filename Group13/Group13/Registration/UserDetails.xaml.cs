using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace Group13.Registration
{
    public partial class UserDetails : ContentPage
    {
        public UserDetails()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

        }

        public async void CreateAccount(object sender, EventArgs e)
        {
            //Check Users input here before adding users info to textfile

            fName.Text = FieldChecks.CheckEmoji(fName.Text);
            lName.Text = FieldChecks.CheckEmoji(lName.Text);

            fName.BackgroundColor = FieldChecks.isNotNull(fName.Text) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            lName.BackgroundColor = FieldChecks.isNotNull(lName.Text) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            Email.BackgroundColor = FieldChecks.checkEmail(Email.Text) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            Password.BackgroundColor = FieldChecks.CheckPassword(Password.Text) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            ReEnterPassword.BackgroundColor = (FieldChecks.CheckPassword(ReEnterPassword.Text) && (ReEnterPassword.Text == Password.Text)) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            SubscriptionPicker.BackgroundColor = FieldChecks.CheckPicker(SubscriptionPicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            CarMakePicker.BackgroundColor = FieldChecks.CheckPicker(CarMakePicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            CarModelPicker.BackgroundColor = FieldChecks.CheckPicker(CarModelPicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            CarColourPicker.BackgroundColor = FieldChecks.CheckPicker(CarColourPicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            CarTransPicker.BackgroundColor = FieldChecks.CheckPicker(CarTransPicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            CarCylPicker.BackgroundColor = FieldChecks.CheckPicker(CarCylPicker.SelectedIndex) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");
            CarRegistration.BackgroundColor = FieldChecks.isNotNull(CarRegistration.Text) ? Color.FromHex("#0BDA51") : Color.FromHex("#FFC0CB");

            if (fName.BackgroundColor == Color.FromHex("#0BDA51"))
            {
                if (lName.BackgroundColor == Color.FromHex("#0BDA51"))
                {
                    if (Email.BackgroundColor == Color.FromHex("#0BDA51"))
                    {
                        if (Password.BackgroundColor == Color.FromHex("#0BDA51"))
                        {
                            if (ReEnterPassword.BackgroundColor == Color.FromHex("#0BDA51"))
                            {
                                if (SubscriptionPicker.BackgroundColor == Color.FromHex("#0BDA51"))
                                {
                                    if (CarMakePicker.BackgroundColor == Color.FromHex("#0BDA51"))
                                    {
                                        if (CarModelPicker.BackgroundColor == Color.FromHex("#0BDA51"))
                                        {
                                            if (CarColourPicker.BackgroundColor == Color.FromHex("#0BDA51"))
                                            {
                                                if (CarTransPicker.BackgroundColor == Color.FromHex("#0BDA51"))
                                                {
                                                    if (CarCylPicker.BackgroundColor == Color.FromHex("#0BDA51"))
                                                    {
                                                        if (CarRegistration.BackgroundColor == Color.FromHex("#0BDA51"))
                                                        {
                                                            App.UID++;
                                                            string input = (App.UID.ToString() + " " + fName.Text + " " + lName.Text + " " + Email.Text + " " + Password.Text + " USER " + SubscriptionPicker.SelectedItem + " " + CarMakePicker.SelectedItem + " " + CarModelPicker.SelectedItem + " " + CarColourPicker.SelectedItem + " " + CarTransPicker.SelectedItem + " " + CarCylPicker.SelectedItem + " " + CarRegistration.Text);

                                                            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
                                                            string line = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Group13.UsersData.txt");
                                                            File.WriteAllText(line, input);

                                                            await DisplayAlert("Success", "Account has successfully been created", "Ok");
                                                            await Navigation.PopAsync();
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
                                                    await DisplayAlert("Error", "Invalid Car Transmission", "Ok");
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
                                else
                                {
                                    await DisplayAlert("Error", "Invalid Subscription", "Ok");
                                }
                            }
                            else
                            {
                                await DisplayAlert("Error", "Invalid Password", "Ok");
                            }
                        }
                        else
                        {
                            await DisplayAlert("Error", "Invalid Password", "Ok");
                        }
                    }
                    else
                    {
                        await DisplayAlert("Error", "Invalid Email", "Ok");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Invalid Last Name", "Ok");
                }
            }
            else
            {
                await DisplayAlert("Error", "Invalid First Name", "Ok");
            }

        }

        public async void PrevPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
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
