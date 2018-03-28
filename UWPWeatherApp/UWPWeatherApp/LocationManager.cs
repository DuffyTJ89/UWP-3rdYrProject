using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace UWPWeatherApp
{
    public class LocationManager
    {
        public async static Task<Geoposition> GetPosition()
        {
           var accessStatus = await Geolocator.RequestAccessAsync(); //ask for access to the geo locator on users device
            if (accessStatus != GeolocationAccessStatus.Allowed) throw new Exception();

            var geolocator = new Geolocator { DesiredAccuracyInMeters = 0 }; //get best accuracy that can be got

            var position = await geolocator.GetGeopositionAsync();

            return position;
            
        }
    }
}
