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
        public long AlturaDisponible{ get; set; }
        public long UsuarioId{ get; set; }
        public virtual ICollection<Novedad> novedad{ get; set; }
        public virtual ICollection<LocalizacionElemento> localizacionElemento{ get; set; }
        public virtual ICollection<ElementoCable> elementoCable{ get; set; }
        public virtual Estado Estado{ get; set; }
        public long estado_id{ get; set; }
        public virtual LongitudElemento longitudelemento{ get; set; }

        public long longitudlemento_id{ get; set; }

        public virtual Material material{ get; set; }
        public long material_id{ get; set; }
        [JsonIgnore]
        public virtual NivelTensionElemento NivelTensionElemento{get;set;}
        public long niveltensionelemento_id{ get; set; }
        [JsonIgnore]
        public virtual Proyecto proyecto{ get; set; }

        public long proyecto_id{ get; set; }
    }
}