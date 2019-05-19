using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Bambu.Clases
{
    class AlarmaManager
    {
        const String URL = "https://sainova.000webhostapp.com/ListarValvulas.php";
        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }
        public async Task<IEnumerable<Alertas>> getAlertas()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(URL);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync(); 
                return JsonConvert.DeserializeObject<IEnumerable<Alertas>>(content);
            }
            return Enumerable.Empty<Alertas>();
        }
    }
}
