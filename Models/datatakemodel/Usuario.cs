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
        public string Cedula {get;set;}
        public string Telefono {get;set;}
        public string Direccion{get;set;}
        public string CorreoElectronico{get;set;}
        public string Passsword{get;set;}

        //Relaciones
        public int  Tipo_Usuario_Id{get;set;}

        public long  Empresa_Id{get;set;}


        [JsonIgnore]
        public virtual Tipo_Usuario Tipo_Usuario {get;set;}
        [JsonIgnore]
        public virtual Empresa Empresa {get;set;}

       [JsonIgnore]
        public virtual ICollection<ProyectoUsuario> ProyectoUsuarios{get;set;}
        
    }
}