using System.Collections.Generic;
using datamakerslib.Repository;
using Electro.model.Models.datatakemodel;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class ElementoCable:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Codigo{ get; set; }
        public long Cantidad{ get; set; }
        public bool SobreRbt{ get; set; }
        public bool Tiene_Marquilla {get;set;}

        //Relaciones
        public long Empresa_Id{ get; set; }
        public long Ciudad_Id{ get; set; }
        public long? Ciudad_Empresa_Id{ get; set; }

        public long DetalleTipocable_Id{ get; set; }
        public long Elemento_Id{ get; set; }

        //De 1 a Muchos
        [JsonIgnore]
        public virtual ICollection<LocalizacionCable> LocalizacionCables{ get; set; }

        //Relacion de 1
        [JsonIgnore]
        public virtual DetalleTipoCable DetalleTipoCable{ get; set; }
       
        [JsonIgnore]
        public virtual Elemento Elemento{ get; set; }

        [JsonIgnore]
        public virtual Ciudad_Empresa Ciudad_Empresa{ get; set; }
   
    }
}