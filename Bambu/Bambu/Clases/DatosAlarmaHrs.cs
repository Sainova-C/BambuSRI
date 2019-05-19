using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Bambu.Clases
{
    class DatosAlarmaHrs
    {
        public String Dia { get; set; }
        public String HoraIni { get; set; }
        public String HoraFin { get; set; }
    }
}
