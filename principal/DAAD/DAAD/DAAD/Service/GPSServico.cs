using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace DAAD.Service
{
    class GPSServico
    {
        public static string HorVer;

        public async void PegaGPS()//ainda n funciona
        {
            var location = await Geolocation.GetLastKnownLocationAsync();
            try
            {
               

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
            HorVer = (location.Latitude + location.Longitude).ToString();
        }
    }
}
