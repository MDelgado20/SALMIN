//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PFinalTeleinf.Models.ViewModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class laboratorioDBEntities4 : DbContext
    {
        public laboratorioDBEntities4()
            : base("name=laboratorioDBEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CITA> CITA { get; set; }
        public virtual DbSet<CITA_TIPOEXAMEN> CITA_TIPOEXAMEN { get; set; }
        public virtual DbSet<NOMBRE_EXAMEN> NOMBRE_EXAMEN { get; set; }
        public virtual DbSet<RESULTADO_EXAMEN> RESULTADO_EXAMEN { get; set; }
        public virtual DbSet<RESULTADO_PACIENTE> RESULTADO_PACIENTE { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TIPOEXAMEN> TIPOEXAMEN { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}
