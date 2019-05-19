using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Bambu.Clases
{
    class UserManager
    {
        const String URL = "https://sainova.000webhostapp.com/DatosSistemaRiego.php";
        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }
        public async Task<IEnumerable<Usuario>> getUsuarios()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(URL);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Usuario>>(content);
            }
            return Enumerable.Empty<Usuario>();
        }
    }
}
