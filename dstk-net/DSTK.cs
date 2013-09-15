using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.Text;

namespace dstk.net {

    /// <summary>
    /// Summary description for DSTK
    /// </summary>
    public class DSTK
    {

        private string _DSTK_API_BASE = @"http://www.datasciencetoolkit.org";

        public DSTK()
        {
            DSTK_API_BASE = _DSTK_API_BASE;
        }

        public string DSTK_API_BASE { get; set; }

        public AddressLocation street2coordinates(string query)
        {
            var svcUri = "{0}/street2coordinates/{1}".Fmt(DSTK_API_BASE, query);

            var json = svcUri.GetStringFromUrl(acceptContentType: "application/json");

            var result = JsonObject.Parse(json);

            var alt = JsonObject.Parse(json).ConvertTo(x => new AddressLocation
            {
                address = x.Keys.FirstOrDefault() ?? "",
                location = x.ArrayObjects(x.Keys.First())
                    .ConvertAll<Location>(r =>new Location {
                        street_name = r.Get("street_name"),
                        country_code = r.Get("country_code"),
                        latitude = Double.Parse(r.Get("latitude")),
                        street_address = r.Get("street_address"),
                        country_code3 = r.Get("country_code3"),
                        fips_county = r.Get("fips_county"),
                        longitude = Double.Parse(r.Get("longitude")),
                        country_name = r.Get("country_name"),
                        confidence = Double.Parse(r.Get("confidence")),
                        region = r.Get("region"),
                        street_number = r.Get("street_number"),
                        locality = r.Get("locality")
                    })
            });

            return alt;
        }
    }

}