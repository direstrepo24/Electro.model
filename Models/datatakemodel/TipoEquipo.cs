using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class TipoEquipo:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Nombre{ get; set; }
        [JsonIgnore]
        public virtual ICollection<EquipoElemento> equipoElemento{ get; set; }
    }
}