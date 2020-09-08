using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCHotels.Models
{
    public class CitiesCollection
    {
        public static List<City> listCities = new List<City>();
        // статический конструктор
        static CitiesCollection()
        {
            listCities.Add(new City
            {
                Id = 1,
                Title = "Tallinn",
                Hotels = new List<Hotel>()
                {
                    new Hotel {Id = 1, Name = "Radisson Blu Sky Hotel Tallinn", Services = "Free Wifi Restaurant",
                        PhotoFile = "\\Content\\Radisson.png", Aadress = "Ravala Puiestee 3"},
                    new Hotel {Id = 2, Name = "Hotel Palace Tallinn", Services = "Breakfast Included Free Internet",
                        PhotoFile = "\\Content\\Palace.png", Aadress = "Vabaduse Valjak 3"},
                    new Hotel {Id = 3, Name = "Nordic Hotel Forum Tallinn",
                        Services = "Reserve now, pay later Breakfast Included Free Internet",
                        PhotoFile = "\\Content\\Forum.png", Aadress = "Viru Väljak 3"}
                }
            });

            listCities.Add(new City
            {
                Id = 2,
                Title = "Tartu",
                Hotels = new List<Hotel>()
                {
                    new Hotel {Id = 4, Name = "Art Hotel Pallas  Tartu", Services = "Air conditioning Free Wifi Breakfast ",
                        PhotoFile = "\\Content\\PallasTarty.png", Aadress = "Ravala Puiestee 3"},
                    new Hotel {Id = 5, Name = "Hotel Tartu", Services = "Free Wifi Breakfast included",
                        PhotoFile = "\\Content\\Tarty.png", Aadress = "Soola, 3"}                   
                }
            });

            listCities.Add(new City
            {
                Id = 3,
                Title = "Toila",
                Hotels = new List<Hotel>()
                {
                    new Hotel {Id = 6, Name = "Toila Spa Hotel", Services = "Spa and Wellness Center Swimming Pool Free Parking",
                        PhotoFile = "\\Content\\Toila.png", Aadress = "Ranna, 12 Toila"}                   
                }
            });

        }
    };
}