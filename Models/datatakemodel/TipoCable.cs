using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class TipoCable:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Nombre{ get; set; }

        //Relaciones
        [JsonIgnore]
        public ICollection<DetalleTipoCable> DetalleTipoCables{ get; set; }
    }
}