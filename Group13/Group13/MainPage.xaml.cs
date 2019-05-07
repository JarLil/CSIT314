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
        List<Users> UserArray = new List<Users>();

        public MainPage()
        {
            InitializeComponent();

            Task.Run(() => { LoadData(); });

            Navigate();
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
            int userCounter = 0;

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
                }

                foreach (Users u in UserArray)
                {
                    System.Diagnostics.Debug.WriteLine(u.print());
                }

            }
        }

        private async void Navigate()
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
