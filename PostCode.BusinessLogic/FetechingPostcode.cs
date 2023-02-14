namespace PostCode.BusinessLogic
{
    public static class FetechingPostcode
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="postcode"></param>
        /// <returns></returns>
        public static string GetPostCode(string postcode)
        {
            postcode = postcode.Replace(" ", "%20");
            string contents;
            using (System.Net.WebClient? wc = new System.Net.WebClient())
            {
                contents = wc.DownloadString("http://api.postcodes.io/postcodes/" + postcode);
            }

            return contents;
        }


        public static string GetPostCodes(string postcode)
        {
            string contents;

            using (System.Net.WebClient? wc = new System.Net.WebClient())
            {
                contents = wc.DownloadString("http://api.postcodes.io/postcodes/" + postcode + "/autocomplete");
            }

            return contents;
        }
    }
}