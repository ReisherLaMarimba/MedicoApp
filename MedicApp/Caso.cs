//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Caso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Caso()
        {
            this.Medicos = new HashSet<Medico>();
        }
    
        public int Id { get; set; }
        public int Paciente_Id { get; set; }
        public int Doctor_Id { get; set; }
        public System.DateTime Fecha_entrada { get; set; }
        public System.DateTime Fecha_salida { get; set; }
    
        public virtual Paciente Paciente { get; set; }
        public virtual Medico Medico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
