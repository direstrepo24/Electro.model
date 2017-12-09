using System.Collections.Generic;
using System.Collections.ObjectModel;
using datamakerslib.Repository;
using Electro.model.Models.datatakemodel;
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
        public bool Is_Operadora{ get; set; }


        [JsonIgnore]
         public virtual ICollection<Proyecto_Empresa> ProyectoEmpresas{ get; set; }


        [JsonIgnore]
        public virtual ICollection<Usuario> Usuarios{ get; set; }

         [JsonIgnore]
        public virtual ICollection<Ciudad_Empresa> Ciudad_Empresas { get; set; }
    }
}