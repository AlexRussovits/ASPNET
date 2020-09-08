using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCHotels.Models
{
    public class City { 
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Hotel> Hotels { get; set; }

    }
}