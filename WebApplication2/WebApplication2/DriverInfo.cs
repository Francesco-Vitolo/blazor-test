using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using ErgastApi.Client;
using ErgastApi.Requests;
using ErgastApi.Responses;
using System.Windows.Input;
using ErgastApi.Responses.Models;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class DriverInfo
    {
        static ErgastClient client = new ErgastClient();
        static DriverInfoRequest request = new DriverInfoRequest{Season = "2022"};
        public static async Task<Driver[]> GetDriverInfo()
        {      
            DriverResponse response = await client.GetResponseAsync(request);
            return response.Drivers.ToArray();
        }
    }
}
