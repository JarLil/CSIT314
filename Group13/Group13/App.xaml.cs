using System;
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

        //Current User Info
        public static string CURRENTUSERID = "";
        public static string CURRENTUSERFNAME = "";
        public static string CURRENTUSERLNAME = "";
        public static string CURRENTUSEREMAIL = "";
        public static string CURRENTUSERSUBSCRIPTION = "";
        public static string CURRENTUSERCARMAKE = "";
        public static string CURRENTUSERCARMODEL = "";
        public static string CURRENTUSERCARCOLOUR = "";
        public static string CURRENTUSERREGISTRATION = "";
        public static string CURRENTUSERTRANSMISSION = "";
        public static string CURRENTUSERCYLINDERS = "";

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
