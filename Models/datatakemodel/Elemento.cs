using System;
using System.Collections.Generic;
using datamakerslib.Repository;
using Newtonsoft.Json;

namespace Electro.model.datatakemodel
{
    public class Elemento:IEntityBase<long>
    {
        public long Id{ get; set; }
        public string CodigoApoyo{ get; set; }
        public long NumeroApoyo{ get; set; }
        public DateTime FechaLevantamiento{ get; set; }
        public string HoraInicio{ get; set; }
        public string HoraFin{ get; set; }
        public string ResistenciaMecanica{ get; set; }
        public long Retenidas{ get; set; }
        public double AlturaDisponible{ get; set; }

        //Relaciones
        public long Usuario_Id{ get; set; }
        public long Estado_id{ get; set; }
        public long Longitud_Elemento_Id{ get; set; }
        public long Material_Id{ get; set; }
        public long Proyecto_Id{ get; set; }
        public long Nivel_Tension_Id{ get; set; }
        public long Ciudad_Id{ get; set; }

        //Relacion de muchos
        [JsonIgnore]
        public virtual ICollection<Novedad> Novedades{ get; set; }
        [JsonIgnore]
        public virtual ICollection<Perdida> Perdidas{ get; set; }
        [JsonIgnore]
        public virtual ICollection<LocalizacionElemento> LocalizacionElementos{ get; set; }
        [JsonIgnore]
        public virtual ICollection<ElementoCable> Cables{ get; set; }
        [JsonIgnore]
        public virtual ICollection<EquipoElemento> Equipos{ get; set; }

        //Relacion de 1
        [JsonIgnore]
        public virtual Proyecto Proyecto{ get; set; }
         [JsonIgnore]
        public virtual Material Material{ get; set; }
         [JsonIgnore]
        public virtual LongitudElemento LongitudElemento{ get; set; }
        [JsonIgnore]
        public virtual Estado Estado{ get; set; }
         [JsonIgnore]
        public virtual NivelTensionElemento NivelTensionElemento{get;set;}

       
    }
}