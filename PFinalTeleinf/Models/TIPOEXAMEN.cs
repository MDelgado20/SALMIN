//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PFinalTeleinf.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPOEXAMEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOEXAMEN()
        {
            this.CITA_TIPOEXAMEN = new HashSet<CITA_TIPOEXAMEN>();
            this.NOMBRE_EXAMEN = new HashSet<NOMBRE_EXAMEN>();
            this.RESULTADO_EXAMEN = new HashSet<RESULTADO_EXAMEN>();
        }
    
        public int ID_TIPOEXAMEN { get; set; }
        public string NOMBRE_TIPOEXAMEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CITA_TIPOEXAMEN> CITA_TIPOEXAMEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOMBRE_EXAMEN> NOMBRE_EXAMEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULTADO_EXAMEN> RESULTADO_EXAMEN { get; set; }
    }
}
