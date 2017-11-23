using System.Collections.Generic;
using datamakerslib.Repository;

namespace Electro.model.datatakemodel
{
    public class TipoCable:IEntityBase<long>
    {
        public long Id{ get; set; }
        public long Nombre{ get; set; }
   
        public ICollection<DetalleTipoCable> detalleTipoCable{ get; set; }
    }
}