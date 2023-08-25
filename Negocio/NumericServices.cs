namespace Negocio
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.IO;
    using System.Net;
    using System.Web;

    public class NumericServices
    {
        public  string ProcessAsync(string valor )
        {
            try
            {
                double ValorFinal = 0; 
                string rateValue="";
                var URL = "https://api.coinbase.com/v2/exchange-rates?currency=USD";

                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(URL);
                myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";

                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                myWebRequest.Proxy = null;
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myStream = myHttpWebResponse.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myStream);
                //Leemos los datos
                string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());

                JObject jsonObject = JObject.Parse(Datos);
                JObject ratesObject = (JObject)jsonObject["data"]["rates"];

                foreach (var rate in ratesObject)
                {
                    if (rate.Key == "COP")
                    {
                        rateValue = rate.Value.ToString();
                        break;
                    }
                }
                ValorFinal = double.Parse(valor) / double.Parse(rateValue);
                return ValorFinal.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
