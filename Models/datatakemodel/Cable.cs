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

        public bool Ismarquilla {get;set;}
        [JsonIgnore]
        public virtual ICollection<DetalleTipoCable> detalleTipoCable{ get; set; }
    }
}