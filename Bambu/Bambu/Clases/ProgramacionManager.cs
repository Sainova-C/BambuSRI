using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Bambu.Clases
{
    class ProgramacionManager
    {
        const String URL = "https://sainova.000webhostapp.com/ListarAlarmasRiego.php";
        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }
        public async Task<IEnumerable<Programacion>> getProgramacion()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(URL);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Programacion>>(content);
            }
            return Enumerable.Empty<Programacion>();
        }
    }
}
