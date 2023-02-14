using System.Text.Json.Serialization;

namespace PostCodes.WebApi.Service.Data
{
    //The full postcode info for a requested postcode.
    public class PostCodesInfo
    {
        //The HTTP status response from Postcodes.IO.
        [JsonPropertyName("status")]

        public int Status { get; set; }

        //If an error is returned, it is held here.
        [JsonPropertyName("error")]

        public string Error { get; set; }

        //The actual result of the API call.
        [JsonPropertyName("result")]

        public List<string> Result { get; set; }
    }
}
