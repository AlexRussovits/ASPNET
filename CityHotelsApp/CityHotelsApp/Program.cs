using System;
using System.Linq;

namespace CityHotelsApp
{
    class Program
    {
        //Aleksander Russovits JPTVR18

        class Hotel
        {
            public string City { get; set; }
            public string HotelName { get; set; }
            public string Address { get; set; }
            public string Services { get; set; }

            public override string ToString()
            {
                return "Hotel: " + HotelName + " " + City + " " + Address + " " + Services; 
            }
        }


        static void Main(string[] args)
        {
            Hotel[] hotels =
            {
                new Hotel{HotelName = "Radisson Sky Blue", City = "Tallinn", Address = "Rävala pst 3", Services = "Wi-fi, Parking, SPA"},
                new Hotel{HotelName = "Hilton Tallinn Park", City = "Tallinn", Address = "Fr. R. Kreutzwaldi 23", Services = "Wi-fi, Parking, SPA, Cafeteria"},
                new Hotel{HotelName = "Centennial Hotel Tallinn", City = "Tallinn", Address = "15 Endla", Services = "Wi-fi, SPA"},
                new Hotel{HotelName = "Dorpat Conference Hotel", City = "Tartu", Address = "Soola 6", Services = "Wi-fi, TV, SPA"},
                new Hotel{HotelName = "V Spa & Conference Hotel", City = "Tartu", Address = "Riia 2", Services = "Wi-fi, Parking, SPA,Restaurant, Bar"},
                new Hotel{HotelName = "Hedon Spa & Hotel", City = "Pärnu", Address = " Ranna Puiestee 1", Services = "Wi-fi, Parking, SPA,TV"},
                new Hotel{HotelName = "Strand Spa & Conference Hotel", City = "Pärnu", Address = "Tammsaare pst 35", Services = "Wi-fi, Parking, SPA, Bar"},
                new Hotel{HotelName = "Toila Spa Hotel ", City = "Toila", Address = "Ranna 12", Services = "Wi-fi, Parking, SPA, TV, Bar"},
            };

            var selectedHotel = from hotel in hotels
                                where hotel.City == "Tallinn"                               
                                select hotel;

            int j = 0;

            foreach(Hotel hotel in selectedHotel)
            {
                j++;
                Console.WriteLine(j + ". " + hotel);
            }


            Console.Write("\n\nPress any key...");
            Console.ReadKey();
        }
    }
}
