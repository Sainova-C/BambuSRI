using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Bambu.Clases
{
    class DatosGManager
    {
        const String URL = "https://sainova.000webhostapp.com/DatosSistemaRiego.php";
        private HttpClient getClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }

        public async Task<IEnumerable<DatosG>> getDatos()
        {
            HttpClient client = getClient();
            var res = await client.GetAsync(URL);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<DatosG>>(content);
            }
            return Enumerable.Empty<DatosG>();
        }
    }
}
