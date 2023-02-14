using System.Text.Json.Serialization;

namespace PostCodes.WebApi.Service.Data
{
    public class PostCodeResult
    {
        //The returned postcode.
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        //The quality of the postcode.
        [JsonPropertyName("quality")]
        public int Quality { get; set; }

        //Country the postcode is in, region.
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        //Parliamentary/council stuff.
        [JsonPropertyName("parliamentary_constituency")]

        public string ParliamentaryConstituency { get; set; }

        [JsonPropertyName("admin_district")]

        public string AdminDistrict { get; set; }

        //Longitude, latitude.
        [JsonPropertyName("longitude")]

        public double Longitude { get; set; }

        [JsonPropertyName("latitude")]

        public double Latitude { get; set; }


        public string Area
        {
            get { return Latitude < 52.229466 ? "South" : 52.229466 <= Latitude ? "Midlands" : Latitude < 53.27169 ? "North" : "NA"; }
        }
    }
}
