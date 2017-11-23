using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class DetalleTipoCable:IEntityBase<long>
    {
        public long Id{ get; set; }
        public virtual TipoCable tipoCable{ get; set; }
        public long tipocable_id {get; set; }

        public long cable_id{ get; set; }
        [JsonIgnore]
        public virtual Cable cable{ get; set; }
        [JsonIgnore]
       public virtual ICollection<ElementoCable> elementoCable{ get; set; }
    
    }
}