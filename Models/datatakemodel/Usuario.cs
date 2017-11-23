using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Usuario:IEntityBase<long>
   {

        public long  Id{get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string cedula {get;set;}
        public string Telefono {get;set;}
        public string Direccion{get;set;}
        public string CorreoElectronico{get;set;}
        public string Passsword{get;set;}
        [JsonIgnore]
        public virtual Tipo_Usuario usertypo {get;set;}
        [JsonIgnore]
        public virtual Empresa empresa {get;set;}
        [JsonIgnore]
        public virtual Proyecto proyecto{get;set;}

        public long proyecto_id{get;set;}

        //public virtual ICollection<Dispositivo> dispositivos{get;set;}
        
    }
}