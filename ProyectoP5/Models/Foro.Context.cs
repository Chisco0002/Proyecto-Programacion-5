﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class proyectoProgramacionVEntities3 : DbContext
    {
        public proyectoProgramacionVEntities3()
            : base("name=proyectoProgramacionVEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<foroConsulata> foroConsulata { get; set; }
        public virtual DbSet<foroRespuestas> foroRespuestas { get; set; }
        public virtual DbSet<asddsa> asddsa { get; set; }
        public virtual DbSet<tasaBasicaPasiva> tasaBasicaPasiva { get; set; }
        public virtual DbSet<tasaDePolíticaMonetaria> tasaDePolíticaMonetaria { get; set; }
        public virtual DbSet<tipoDeCambioCompra> tipoDeCambioCompra { get; set; }
        public virtual DbSet<tipoDeCambioVenta> tipoDeCambioVenta { get; set; }
    }
}
