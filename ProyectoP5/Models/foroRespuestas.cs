//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoP5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class foroRespuestas
    {
        public int respuestaID { get; set; }
        public string nombreReceptor { get; set; }
        public string detalleRespuesta { get; set; }
        public int consultaID { get; set; }
    
        public virtual foroConsulata foroConsulata { get; set; }
    }
}
