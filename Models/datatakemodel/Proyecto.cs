using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Proyecto:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string Nombre{ get; set; }
        public string Descripcion{ get; set; }
        public DateTime FechaInicio{ get; set; }
        public DateTime FechaFin{ get; set; }
        public string OrdenTrabajo{ get; set; }
        public bool IsActivo{ get; set; }
        
        //Relaciones
        public long Ciudad_Id{ get; set; }

        [JsonIgnore]
        public virtual Ciudad Ciudad{ get; set; }

        [JsonIgnore]
        public virtual ICollection<ProyectoUsuario> ProyectoUsuarios{ get; set; }

        [JsonIgnore]
        public virtual ICollection<Proyecto_Empresa> Proyecto_Empresa{ get; set; }
        [JsonIgnore]
        public virtual ICollection<Elemento> Elementos{ get; set; }
    }
}