using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class DetalleTipoCable:IEntityBase<long>
    {
        public long Id{ get; set; }
        //Relaciones
        public long Tipocable_Id {get; set; }
        public long Cable_Id{ get; set; }
      
        [JsonIgnore]
        public virtual ICollection<ElementoCable> ElementoCable{ get; set; }

        [JsonIgnore]
        public virtual Cable Cable{ get; set; }
        
        [JsonIgnore]
        public virtual TipoCable TipoCable{ get; set; }
    
    }
}