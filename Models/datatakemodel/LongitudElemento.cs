using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class LongitudElemento:IEntityBase<long>
    {
        public long Id { get; set; }
        public double Valor { get; set; }
        public string UnidadMedida { get; set; }
        
        [JsonIgnore]
        public ICollection<Elemento> Elementos { get; set; }
    }
}