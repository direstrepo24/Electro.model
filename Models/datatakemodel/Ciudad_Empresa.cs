using System.Collections.Generic;
using datamakerslib.Repository;
using Electro.model.datatakemodel;
using Newtonsoft.Json;

namespace Electro.model.Models.datatakemodel
{
    public class Ciudad_Empresa:IEntityBase<long>
    {
        public long Id{ get; set; }
        //Relaciones
        public long Ciudad_Id {get; set; }
        public long Empresa_Id{ get; set; }

        [JsonIgnore]
        public virtual Ciudad Ciudad{ get; set; }
        
        [JsonIgnore]
        public virtual Empresa Empresa{ get; set; }

        [JsonIgnore]
        public virtual ICollection<ElementoCable> ElementoCables{ get; set; }

        [JsonIgnore]
        public virtual ICollection<EquipoElemento> EquipoElementos{ get; set; }

    }
}