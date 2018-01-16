using System.Collections.Generic;
using datamakerslib.Repository;
using Electro.model.Models.datatakemodel;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Ciudad:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Nombre{ get; set; }
        [JsonIgnore]
        public virtual Departamento departmento{ get; set; }
        public long departmentoId{ get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Proyecto> proyecto { get; set; }

        [JsonIgnore]
        public virtual ICollection<Ciudad_Empresa> Ciudad_Empresas { get; set; }


        [JsonIgnore]
        public virtual ICollection<Elemento> Elementos { get; set; }
    }
}