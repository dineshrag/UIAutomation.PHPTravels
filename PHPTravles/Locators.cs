using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravles.TestAutomation.PageObjectModels
{
    public class Locators
    {
        public class HomePage
        {
            public const string hotels = "//span[contains(text(), 'Hotels')]";
            public const string flights = "//span[contains(text(), 'Flights')]";
            public const string tours = "//span[contains(text(), 'Tours')]";
            public const string roundtrip = "//label[contains(text(), 'Round Trip')]";
            public const string cabinclass = "cabinclass";
            public const string enterfromcityorairport = "//div[@id='s2id_location_from']/a/span[1]";
            public const string fromcityorairport = "//div[@id='select2-drop']/div/input";
            public const string cityairport = "//div[@id='select2-drop']/ul/li/div/span";
            public const string entertocityorairport = "//div[@id='s2id_location_to']/a/span[1]";
            public const string tocityorairport = "//div[@id='select2-drop']/div/input";
            public const string depature = "departure";
            public const string arrival = "arrival";
            public const string totalnumberofpassengers = "totalManualPassenger";
            public const string adultpassengers = "madult";
            public const string done = "sumManualPassenger";
            public const string search = "//div[@id='flights']/form/div[6]/button";
            public const string searchbyhotelorcityname = "//div[@id='s2id_autogen3']/a/span[1]";
            public const string hotelorcityname = "//*[@id='select2-drop']/div/input";
        }
        public class AvailableFlights
        {
            public const string availablefirstflight = "//table[@id='load_data']/tbody/tr[1]/td/div[2]/p/button";
        }
        public class Booking
        {
            public const string Signin = "signintab";
            public const string username = "username";
            public const string password = "password";
            public const string passengername = "passenger_name_0";
            public const string passengerage = "passenger_age_0";
            public const string passportnumber = "passenger_passport_0";
            public const string confirmbooking = "login";
        }
        public class Invoice
        {
            public const string invoive = "//div[contains(text(), 'Invoice')]";
        }
    }
}
