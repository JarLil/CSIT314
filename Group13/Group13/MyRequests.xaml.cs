using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Group13
{
    public partial class MyRequests : ContentPage
    {
        public MyRequests()
        {
            InitializeComponent();

            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            Task.Run(() => { LoadData(); });

            for (int i=0; i < App.CompletedRequestsArray.Count; i++)
            {
                if (App.CURRENTUSERID == App.CompletedRequestsArray[i].UserID)
                {
                    string RSAFNAME = "";
                    string RSALNAME = "";

                    Frame frame = new Frame
                    {
                        HasShadow = false,
                        Margin = new Thickness(0, 0, 0, 0),
                        Padding = new Thickness(10, 0, 10, 0),
                        IsClippedToBounds = true,
                        BackgroundColor = Color.White
                    };

                    Grid grid = new Grid
                    {
                        BackgroundColor = Color.White,
                        Padding = new Thickness(0, 0, 0, 0)
                    };

                    ColumnDefinition cd1 = new ColumnDefinition { };

                    RowDefinition rd1 = new RowDefinition
                    {
                        Height = new GridLength(1, GridUnitType.Star)
                    };

                    for (int j=0; i < App.RSAArray.Count; j++)
                    {
                        if (App.RSAArray[j].RID == App.CompletedRequestsArray[i].RSAID)
                        {
                            RSAFNAME = App.RSAArray[j].fName;
                            RSALNAME = App.RSAArray[j].lName;
                            break;
                        }
                    }

                    Label servicedByLabel = new Label
                    {
                        Text = "Road-Side Assistant:",
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };

                    Label RsaNameLabel = new Label
                    {
                        Text = "",
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };


                    Label carMakeLabel = new Label
                    {
                        Text = "Car Make:",
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };

                    Label carMake = new Label
                    {
                        Text = App.CompletedRequestsArray[i].UserCarMake,
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };

                    Label carModelLabel = new Label
                    {
                        Text = "Car Model:",
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };

                    Label carModel = new Label
                    {
                        Text = App.CompletedRequestsArray[i].UserCarModel,
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };

                    Label carColourLabel = new Label
                    {
                        Text = "Car Colour:",
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };
                    Label carColour = new Label
                    {
                        Text = App.CompletedRequestsArray[i].UserCarColour,
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };

                    Label carRegistrationLabel = new Label
                    {
                        Text = "Car Registration:",
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };
                    Label carRegistration = new Label
                    {
                        Text = App.CompletedRequestsArray[i].UserRego,
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };

                    Label userMessageLabel = new Label
                    {
                        Text = "Message:",
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };
                    Label userMessage = new Label
                    {
                        Text = App.CompletedRequestsArray[i].UserMessage,
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };

                    Label userLocationLabel = new Label
                    {
                        Text = "Location:",
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };
                    Label userLocation = new Label
                    {
                        Text = App.CompletedRequestsArray[i].UserLocation,
                        TextColor = Color.Black,
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Start
                    };

                    RsaNameLabel.Text = RSAFNAME + " " + RSALNAME;

                    grid.RowDefinitions.Add(rd1); //RSA fname + lname
                    grid.RowDefinitions.Add(rd1); //car make
                    grid.RowDefinitions.Add(rd1); //car model
                    grid.RowDefinitions.Add(rd1); //car Colour
                    grid.RowDefinitions.Add(rd1); //Car rego
                    grid.RowDefinitions.Add(rd1); //user message
                    grid.RowDefinitions.Add(rd1); //user location
                    grid.ColumnDefinitions.Add(cd1);
                    grid.ColumnDefinitions.Add(cd1);

                    Grid.SetRow(servicedByLabel, 0);
                    Grid.SetColumn(servicedByLabel, 0);
                    Grid.SetRow(RsaNameLabel, 0);
                    Grid.SetColumn(RsaNameLabel, 1);

                    grid.Children.Add(servicedByLabel);
                    grid.Children.Add(RsaNameLabel);

                    Grid.SetRow(carMakeLabel, 1);
                    Grid.SetColumn(carMakeLabel, 0);
                    Grid.SetRow(carMake, 1);
                    Grid.SetColumn(carMake, 1);

                    grid.Children.Add(carMakeLabel);
                    grid.Children.Add(carMake);

                    Grid.SetRow(carModelLabel, 2);
                    Grid.SetColumn(carModelLabel, 0);
                    Grid.SetRow(carModel, 2);
                    Grid.SetColumn(carModel, 1);

                    grid.Children.Add(carModelLabel);
                    grid.Children.Add(carModel);

                    Grid.SetRow(carColourLabel, 3);
                    Grid.SetColumn(carColourLabel, 0);
                    Grid.SetRow(carColour, 3);
                    Grid.SetColumn(carColour, 1);

                    grid.Children.Add(carColourLabel);
                    grid.Children.Add(carColour);

                    Grid.SetRow(carRegistrationLabel, 4);
                    Grid.SetColumn(carRegistrationLabel, 0);
                    Grid.SetRow(carRegistration, 4);
                    Grid.SetColumn(carRegistration, 1);

                    grid.Children.Add(carRegistrationLabel);
                    grid.Children.Add(carRegistration);

                    Grid.SetRow(userMessageLabel, 5);
                    Grid.SetColumn(userMessageLabel, 0);
                    Grid.SetRow(userMessage, 5);
                    Grid.SetColumn(userMessage, 1);

                    grid.Children.Add(userMessageLabel);
                    grid.Children.Add(userMessage);

                    Grid.SetRow(userLocationLabel, 6);
                    Grid.SetColumn(userLocationLabel, 0);
                    Grid.SetRow(userLocation, 6);
                    Grid.SetColumn(userLocation, 1);

                    grid.Children.Add(userLocationLabel);
                    grid.Children.Add(userLocation);

                    frame.Content = grid;

                    RequestsStack.Children.Add(frame);
                }
            }
        }

        public void LoadData()
        {
            var CompReqAssembly = IntrospectionExtensions.GetTypeInfo(typeof(MainPage)).Assembly;
            Stream CompReqStream = CompReqAssembly.GetManifestResourceStream("Group13.CompletedRequests.txt");

            var CompReqTextLines = new List<string>();
            string CompReqLine = null;

            using (var reader = new System.IO.StreamReader(CompReqStream))
            {
                while ((CompReqLine = reader.ReadLine()) != null)
                {
                    CompReqTextLines.Add(CompReqLine);
                }

                foreach (var line in CompReqTextLines)
                {
                    string[] components = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    App.CompletedRequestsArray.Add(new CompletedRequests
                    {
                        CompletedeID = components[0],
                        RSAID = components[1],
                        UserID = components[2],
                        UserCarMake = components[3],
                        UserCarModel = components[4],
                        UserCarColour = components[5],
                        UserRego = components[6],
                        UserMessage = components[7],
                        UserLocation = components[8]
                    });
                    App.CompletedReqID++;
                }
                System.Diagnostics.Debug.Write("READ COMPLETED REQUESTS");
            }
        }
    }
}
