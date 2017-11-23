using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Novedad:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Descripcion{ get; set; }
        [JsonIgnore]
        public virtual Elemento elemento{ get; set; }
        public long element_id{ get; set; }
        [JsonIgnore]
        public virtual DetalleTipoNovedad detalleTipoNovedad{ get; set; }

        public long detalletiponovedad_id { get; set; }   
    }
}