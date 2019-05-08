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
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            Task.Run(() => { LoadData(); });
            Task.Run(() => { LoadRSAData(); });

            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (s, e) => ToRegisterPage();
            RegisterLabel.GestureRecognizers.Add(tgr);
        }

        public void LoadRSAData()
        {
            var rsaAssembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            Stream rsaStream = rsaAssembly.GetManifestResourceStream("Group13.RSA.txt");

            //
            var rsaText = new List<string>();
            string rsaLine = null;

            using (var reader = new System.IO.StreamReader(rsaStream))
            {
                while ((rsaLine = reader.ReadLine()) != null)
                {
                    rsaText.Add(rsaLine);
                }

                foreach (var line in rsaText)
                {
                    string[] components = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    App.RSAArray.Add(new RoadSideAssistant
                    {
                        RID = components[0],
                        fName = components[1],
                        lName = components[2],
                        email = components[3],
                        password = components[4],
                        type = components[5],
                        carMake = components[6],
                        carModel = components[7],
                        carColour = components[8],
                        registration = components[9],
                        training = components[10]
                    });
                    App.RSAID++;
                }
                System.Diagnostics.Debug.Write("READ RSA");
            }
        }

        public void LoadData()
        {
            //Read in Users Data
            var assembly1 = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            Stream stream1 = assembly1.GetManifestResourceStream("Group13.UsersData.txt");

            var textlines1 = new List<string>();
            string lines1 = null;

            using (var reader = new System.IO.StreamReader(stream1))
            {
                while ((lines1 = reader.ReadLine()) != null)
                {
                    textlines1.Add(lines1);
                }

                foreach (var line1 in textlines1)
                {
                    string[] components = line1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    App.UsersArray.Add(new Users
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
                        transmission = components[10],
                        cylinders = components[11],
                        registration = components[12]
                    });
                    App.UID++;
                }
                System.Diagnostics.Debug.Write("READ USERS");
            }
        }

        private async void Login_Check(object sender, EventArgs e)
        {
            Boolean check = false;
            Boolean RSACheck = false;

            for (int i=0; i < App.UsersArray.Count; i++)
            {
                if (Username.Text == App.UsersArray[i].email && Password.Text == App.UsersArray[i].password)
                {
                    check = true;
                    App.CURRENTUSERID = App.UsersArray[i].userId;
                }
            }

            for (int j=0; j < App.RSAArray.Count; j++)
            {
                if (Username.Text == App.RSAArray[j].email && Password.Text == App.RSAArray[j].password)
                {
                    RSACheck = true;
                    App.CURRENTUSERID = App.RSAArray[j].RID;
                }
            }

            if (check)
            {
                if (RSACheck)
                {
                    //Load different homepage for RSA - Checks to be done on homepage file
                    await Navigation.PushAsync(new Page());
                }
                else
                {
                    await Navigation.PushAsync(new HomePage());
                }
            }
            else
            {
                await DisplayAlert("Error", "User not found. Please register for an account", "Ok");
            }
        }

        public async void ToRegisterPage()
        {
            await Navigation.PushAsync(new Registration.UserDetails());
        }
    }
}
