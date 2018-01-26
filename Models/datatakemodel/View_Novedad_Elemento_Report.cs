using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electro.model.Models.datatakemodel
{
    [Table("view_novedad_elemento_report")]
    public class View_Novedad_Elemento_Report
    {

        //Propereties Novedad
        [Column("novedad_id")]
        public long Novedad_Id { get; set; }

        [Column("nombre_tipo_novedad")]
        public string Nombre_Tipo_Novedad { get; set; }

        [Column("nombre_detalle_tipo_novedad")]
        public string Nombre_Detalle_Tipo_Novedad { get; set; }

        [Column("tipo_novedad_id")]
        public long Tipo_Novedad_id { get; set; }

        [Column("descripcion_novedad")]
        public string Descripcion_Novedad { get; set; }

        [Column("detalle_tipo_novedad_id")]
        public long Detalle_Tipo_Novedad_Id { get; set; }


        //Properties Elemento
        [Column("elemento_id")]
        public long Elemento_Id { get; set; }

        [Column("codigoapoyo")]
        public string CodigoApoyo { get; set; }

        [Column("numeroapoyo")]
        public long NumeroApoyo { get; set; }

        [Column("fechalevantamiento")]
        public DateTime FechaLevantamiento { get; set; }

        [Column("horainicio")]
        public string HoraInicio { get; set; }
        
        [Column("imei_device")]
        public string Imei_Device { get; set; }

        [Column("fecha_sincronizacion")]
        public DateTime? Fecha_Sincronizacion {get; set;}
        
        [Column("hora_sincronizacion")]
        public string Hora_Sincronizacion {get; set;}

        [Column("horafin")]
        public string HoraFin { get; set; }

        [Column("resistenciamecanica")]
        public string ResistenciaMecanica { get; set; }

        [Column("retenidas")]
        public long Retenidas { get; set; }

        [Column("alturadisponible")]
        public double AlturaDisponible { get; set; }
        
        //Relaciones
        [Column("ciudad_id")]
        public long Ciudad_Id { get; set; }

        [Column("usuario_id")]
        public long Usuario_Id { get; set; }

        [Column("estado_id")]
        public long Estado_id { get; set; }

        [Column("longitud_elemento_id")]
        public long Longitud_Elemento_Id { get; set; }

        [Column("material_id")]
        public long Material_Id { get; set; }

        [Column("proyecto_id")]
        public long Proyecto_Id { get; set; }

        [Column("nivel_tension_id")]
        public long Nivel_Tension_Id { get; set; }

        //Properties Others Tables
        [Column("nombre_estado")]
        public string Nombre_Estado { get; set; }

        [Column("nombre_material")]
        public string Nombre_Material { get; set; }

        [Column("longitud")]
        public double Longitud { get; set; }

        [Column("nombre_nivel_tension")]
        public string Nombre_Nivel_Tension { get; set; }

        [Column("sigla_nivel_tension")]
        public string Sigla_Nivel_Tension { get; set; }

        [Column("valor_nivel_tension")]
        public long Valor_Nivel_Tension { get; set; }

        [Column("nombre_proyecto")]
        public string Nombre_Proyecto { get; set; }

        [Column("nombre_usuario")]
        public string Nombre_Usuario { get; set; }

        [Column("apellido_usuario")]
        public string Apellido_Usuario { get; set; }

        [Column("cedula_usuario")]
        public string Cedula_Usuario { get; set; }

        [Column("ciudad")]
        public string Ciudad { get; set; }

        [Column("departamento")]
        public string Departamento { get; set; }

        [Column("departamento_id")]
        public long Departamento_Id { get; set; }

        //Localizacion

        [Column("coordenadas_elemento")]
        public string Coordenadas_Elemento { get; set; }

        [Column("direccion_elemento")]
        public string Direccion_Elemento { get; set; }

        [Column("latitud_elemento")]
        public decimal Latitud_Elemento { get; set; }

         [Column("longitud_elemento")]
        public decimal Longitud_Elemento { get; set; }

         [Column("direccion_gps")]
        public string Direccion_Gps { get; set; }
       
        
    }
}