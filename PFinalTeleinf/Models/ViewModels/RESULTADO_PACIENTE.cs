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
    using System.Collections.Generic;
    
    public partial class RESULTADO_PACIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESULTADO_PACIENTE()
        {
            this.RESULTADO_EXAMEN = new HashSet<RESULTADO_EXAMEN>();
        }
    
        public int ID_RESULTADOPACIENTE { get; set; }
        public string NOMBREPACIENTE { get; set; }
        public string APELLIDO { get; set; }
        public string CEDULA { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public Nullable<System.DateTime> FECHANACIMIENTO { get; set; }
        public Nullable<System.DateTime> FECHAPROGRAMADA { get; set; }
        public Nullable<System.DateTime> FECHARESULTADO { get; set; }
        public Nullable<int> ID_CITA { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
    
        public virtual CITA CITA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULTADO_EXAMEN> RESULTADO_EXAMEN { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
