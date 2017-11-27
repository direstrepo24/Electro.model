using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Cable:IEntityBase<long>
    {
        public long Id{ get; set; }
        public long Nombre{ get; set; }
        public int Sigla{ get; set; }

        //Relaciones
        [JsonIgnore]
        public virtual ICollection<DetalleTipoCable> DetalleTipoCables{ get; set; }
    }
}