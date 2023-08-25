namespace Negocio
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Web;
    public class AlphaNumericService
    {
        public string ProcessAsync(string valor)
        {
            try
            {
                List<string> definicion = new List<string>();
                string retorno = "";
                var URL = "https://api.dictionaryapi.dev/api/v2/entries/en/" + valor;

                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(URL);
                myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";

                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                myWebRequest.Proxy = null;
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myStream = myHttpWebResponse.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myStream);
                //Leemos los datos
                string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
                List<Transversal2.Root> data = JsonConvert.DeserializeObject<List<Transversal2.Root>>(Datos);

                foreach (var item in data)
                {
                    foreach (var meaningItem in item.meanings)
                    {
                        foreach (var definition in meaningItem.definitions)
                        {
                            definicion.Add(definition.definition);
                        }
                    }
                }
                var DatosArreglo = definicion;

                foreach (var item in DatosArreglo)
                {
                    retorno += item + ", ";
                }

                return retorno;
            }
            catch (Exception ex)
            {
                return "No se encontraron resultados.";
                //throw new Exception(ex.Message);
            }
        }
    }
}
