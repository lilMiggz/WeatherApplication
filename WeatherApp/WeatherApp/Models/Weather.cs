using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WeatherApp.Models
{
    public class Weather
    {
        public int ID { get; set; }
        public int ZIPCODE { get; set; }
        public string LOCATION { get; set; }
        public string FORECAST { get; set; }
        public int TEMPERATURE { get; set; }

    }

    public class WeatherDBContext : DbContext {
        public DbSet<Weather> Weathers { get; set; }

       
    }
}