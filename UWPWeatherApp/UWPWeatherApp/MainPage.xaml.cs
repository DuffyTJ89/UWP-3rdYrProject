using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPWeatherApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_click(object sender, RoutedEventArgs e)
        {
            var position = await LocationManager.GetPosition();

            //53.2707° N, 9.0568° W galway
            RootObject myWeather = await OpenWeatherMapProxy.GetWeather(position.Coordinate.Latitude, position.Coordinate.Longitude);



            //String icon = String.Format("ms-appx:///Assets/WeatherIcons/{0}.png", myWeather.weather[0].icon); //access local resource with uri
            //ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

            ResultTextBlock.Text = "Current location : " + myWeather.name + " \n" +
                "Current Temperture : " + ((int)myWeather.main.temp).ToString() + "°C" + " \n" +
                "Humidity : " + myWeather.main.humidity + "%" + "\n"+
                "Description : " + myWeather.weather[0].description;


            ResultTextBlock2.Text = "Current Coordinates :" + "\n" + "Latitude : " + position.Coordinate.Latitude + "\n" + "Longitude : " + position.Coordinate.Longitude;
        }
    }
}
