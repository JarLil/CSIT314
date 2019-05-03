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
        List<Users> UserArray = new List<Users>(200);

        public MainPage()
        {
            InitializeComponent();

            Task.Run(() => { LoadData(); });

            Navigate();
        }

        private void LoadData()
        {
            //Load Users Information into Array
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Group13.UsersData.txt");
            
            using (var reader = new System.IO.StreamReader(stream))
            {
                while (reader.Peek() >= 0)
                {
                    string[] strArray;
                    string str;

                    str = reader.ReadLine(); //Reads in 1 line from text file
                    strArray = str.Split(','); //Splits line by ','

                    Users user = new Users(); //Create new user object

                    user.userId = Convert.ToInt32(strArray[0]);
                    user.fName = strArray[1];
                    user.lName = strArray[2];
                    user.email = strArray[3];
                    user.userType = strArray[4];
                    user.subscription = strArray[5];
                    user.carMake = strArray[6];
                    user.carModel = strArray[7];
                    user.carColour = strArray[8];
                    user.registration = strArray[9];
                    user.transmission = Convert.ToBoolean(strArray[10]);
                    user.cylinders = Convert.ToInt32(strArray[11]);

                    UserArray.Add(user);
                }

                for (int i=0; i < UserArray.Count(); i++)
                {
                    //UserArray.
                }

                foreach (Users u in UserArray)
                {
                    System.Diagnostics.Debug.WriteLine("TEST");
                    System.Diagnostics.Debug.WriteLine(u);
                }

            }
        }

        private async void Navigate()
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
