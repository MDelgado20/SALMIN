//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PFinalTeleinf.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class NOMBRE_EXAMEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOMBRE_EXAMEN()
        {
            this.CITA_TIPOEXAMEN = new HashSet<CITA_TIPOEXAMEN>();
            this.RESULTADO_EXAMEN = new HashSet<RESULTADO_EXAMEN>();
        }
    
        public int ID_NOMBRE_EXAMEN { get; set; }
        public Nullable<int> ID_TIPOEXAMEN { get; set; }
        public string NOMBRE_EXAMEN1 { get; set; }
        public string RANGO_INFERIOR { get; set; }
        public string RANGO_SUPERIOR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CITA_TIPOEXAMEN> CITA_TIPOEXAMEN { get; set; }
        public virtual TIPOEXAMEN TIPOEXAMEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULTADO_EXAMEN> RESULTADO_EXAMEN { get; set; }
    }
}
