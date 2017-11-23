using System.Collections.Generic;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class DepartCiudades
    {
        [JsonProperty("ciudades")]
        public List<string> Ciudades { get; set; }

        [JsonProperty("departamento")]
        public string Departamento { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }
}