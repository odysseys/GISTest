using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSO2.Models
{
    public class Place
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
