using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class DetalleTipoNovedad:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Nombre{ get; set; }
        public string Descripcion{ get; set; }
         [JsonIgnore]
        public virtual ICollection<Novedad> elementoNovedad{ get; set; }
         [JsonIgnore]
        public virtual TipoNovedad tipoNovedad{ get; set; }
        public long tiponovedad_id{ get; set; }
    }
}