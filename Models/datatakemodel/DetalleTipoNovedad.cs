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

        public long Tipo_Novedad_id{ get; set; }

         [JsonIgnore]
        public virtual ICollection<Novedad> Novedades{ get; set; }
         [JsonIgnore]
        public virtual TipoNovedad TipoNovedad{ get; set; }
       
    }
}