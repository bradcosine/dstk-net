using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dstk.net
{
    public class AddressLocation
    {
        public string address { get; set; }

        public List<Location> location { get; set; }
    }

    public class Location
    {
        public string street_name { get; set; }
        public string country_code { get; set; }
        public double latitude { get; set; }
        public string street_address { get; set; }
        public string country_code3 { get; set; }
        public string fips_county { get; set; }
        public double longitude { get; set; }
        public string country_name { get; set; }
        public double confidence { get; set; }
        public string region { get; set; }
        public string street_number { get; set; }
        public string locality { get; set; }
    }
}
