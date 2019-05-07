using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Group13
{
    public partial class LoginPage : ContentPage
    {
        public List<Users> UserArray = new List<Users>();

        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            Task.Run(() => { LoadData(); });

            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (s, e) => ToRegisterPage();
            RegisterLabel.GestureRecognizers.Add(tgr);
        }

        private async void Login_Check(object sender, EventArgs e)
        {
            Boolean check = false;

           for (int i=0; i < UserArray.Count; i++)
            {
                if (Username.Text == UserArray[i].email && Password.Text == UserArray[i].password)
                {
                    check = true;
                }
            }
            if (check)
            {
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Error", "User not found. Please register for a new account", "Ok");
            }
        }

        private void LoadData()
        {
            //Load Users Information into Array
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            //var assembly = typeof(MainPage).GetTypeInfo().Assembly; -- Works
            Stream stream = assembly.GetManifestResourceStream("Group13.UsersData.txt");

            //
            var textlines = new List<string>();
            string lines = null;

            using (var reader = new System.IO.StreamReader(stream))
            {
                while ((lines = reader.ReadLine()) != null)
                {
                    textlines.Add(lines);
                }

                foreach (var line in textlines)
                {
                    string[] components = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    this.UserArray.Add(new Users
                    {
                        userId = components[0],
                        fName = components[1],
                        lName = components[2],
                        email = components[3],
                        password = components[4],
                        userType = components[5],
                        subscription = components[6],
                        carMake = components[7],
                        carModel = components[8],
                        carColour = components[9],
                        registration = components[10],
                        cylinders = components[11]
                    });
                    App.UID++;
                }
            }
        }

        public async void ToRegisterPage()
        {
            await Navigation.PushAsync(new Registration.UserDetails());
        }
    }
}
