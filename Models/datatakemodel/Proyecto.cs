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
        [JsonIgnore]
        public virtual Ciudad ciudad{ get; set; }

        public long ciudad_id{ get; set; }

        [JsonIgnore]
        public virtual ICollection<Usuario> proyectoUsuario{ get; set; }
        [JsonIgnore]
        public virtual ICollection<Elemento> elemento{ get; set; }
    }
}