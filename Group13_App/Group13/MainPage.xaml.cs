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

            //Task.Run(() => { LoadData(); });
            LoadData();

            Navigate();
        }

        public void LoadData()
        {
            //Current requests
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("Group13.Requests.txt");

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

                    App.RequestsArray.Add(new Request
                    {
                        REQID = components[0],
                        UserID = components[1],
                        UserCarMake = components[2],
                        UserCarModel = components[3],
                        UserCarColour = components[4],
                        UserRego = components[5],
                        UserMessage = components[6],
                        UserLocation = components[7],
                        Status = components[8]
                    });
                    App.ReqID++;
                }
            }
        }

        private async void Navigate()
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
