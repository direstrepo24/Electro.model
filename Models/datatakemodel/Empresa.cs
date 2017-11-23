using System.Collections.Generic;
using System.Collections.ObjectModel;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Empresa:IEntityBase<long>
    {
        public long Id { get; set; }
        public string Nombre{ get; set; }
        public string Direccion{ get; set; }
        public string Telefono{ get; set; }
        public string Nit{ get; set; }
        [JsonIgnore]
         public virtual ICollection<Proyecto_Empresa> proyectoEmpresa{ get; set; }
    }
}