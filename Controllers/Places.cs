using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;

namespace helloworld.Controllers
{
    public class Places
    {
        private const string API_KEY= "AIzaSyA6OGoQdv_0AqFIh78-RQShkLAUm7EsqEw";

        public Places(){}

        public void queryLocation(string code){
            getdata(code);
        }

        static async public void getdata(string code)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(string.Format("https://maps.googleapis.com/maps/api/place/autocomplete/json?key="+ API_KEY + "&input=" +code));
                    Console.WriteLine(response);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}