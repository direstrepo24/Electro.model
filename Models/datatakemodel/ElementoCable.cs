using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class ElementoCable:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Codigo{ get; set; }
        public long EmpresaId{ get; set; }
        public long Cantidad{ get; set; }
        public bool SobreRbt{ get; set; }
        [JsonIgnore]
        public virtual ICollection<LocalizacionCable> localizacionCable{ get; set; }
        [JsonIgnore]
        public virtual DetalleTipoCable detalleTipoCable{ get; set; }
        public long detalletipocable_id{ get; set; }
        [JsonIgnore]
        public virtual Elemento elemento{ get; set; }
        public long element_id{ get; set; }
    }
}