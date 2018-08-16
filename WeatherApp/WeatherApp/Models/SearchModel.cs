using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WeatherApp.Models
{
    public class SearchModel
    {
        public int id { get; set; }
        public int zipcode { get; set; }
        public string location { get; set; }

        [DisplayName("Forecast: ")]
        public string forecast { get; set; }

        [DisplayName("Temperature: ")]
        public int temperature { get; set; }
       
    }
}