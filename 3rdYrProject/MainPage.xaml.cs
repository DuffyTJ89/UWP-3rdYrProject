using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _3rdYrProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String Lat, Lng;

        public MainPage()
        {
            this.InitializeComponent();
            HideStatusBar();
        }

        private async void HideStatusBar()
        {
            if (ApiInformation.IsApiContractPresent ("Windows.Phone.PhoneContract", 1, 0))
            {
                var statusBar = StatusBar.GetForCurrentView();
                await statusBar.HideAsync();
            }
        }

        private async void btnGetWeather_Click (object sender, RoutedEventArgs e)
        {
            progressRing.IsActive = true;
            var geoLocator = new Geolocator();
            geoLocator.DesiredAccuracy = PositionAccuracy.High;
            Geoposition pos = await geoLocator.GetGeopositionAsync();

            Lat = pos.Coordinate.Point.Position.Latitude.ToString();
            Lng = pos.Coordinate.Point.Position.Longitude.ToString();

            var data = await Helper.Helper.GetWeather(Lat, Lng);
            if(data != null)
            {
                txtCity.Text = $"{data.name},{ data.sys.country}";
                txtLastUpdate.Text = $"Last updated : {DateTime.Now.ToString("dd mm yyyy HH:mm")} ";

                BitmapImage image = new BitmapImage(new Uri ($"http://openweathermap.org/img/w/{data.weather[0].icon}.png", UriKind.Absolute));
                imgWeather.Source = image;

                txtDescription.Text = $"{data.weather[0].description}";
                txtHumidity.Text = $"Humidity : {data.main.humidity}%";
                txtTime.Text = "";
            }
        }
    }
}
