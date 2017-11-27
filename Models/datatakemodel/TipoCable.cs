using System.Collections.Generic;
using datamakerslib.Repository;

namespace Electro.model.datatakemodel
{
    public class TipoCable:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Nombre{ get; set; }

        //Relaciones
        public ICollection<DetalleTipoCable> DetalleTipoCables{ get; set; }
    }
}