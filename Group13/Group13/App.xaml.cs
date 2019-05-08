using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Group13
{
    public partial class App : Application
    {
        //Textfile indexes
        public static int UID = 0;
        public static int ReqID = 0;
        public static int CompletedReqID = 0;
        public static int RSAID = 0;

        //Current logged-in users ID
        public static string CURRENTUSERID;

        public static List<Users> UsersArray = new List<Users>();
        public static List<RoadSideAssistant> RSAArray = new List<RoadSideAssistant>();
        public static List<Request> RequestsArray = new List<Request>();
        public static List<CompletedRequests> CompletedRequestsArray = new List<CompletedRequests>();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
