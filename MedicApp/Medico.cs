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
    
    public partial class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Paciente_actual { get; set; }
        public Nullable<int> Id_role { get; set; }
        public Nullable<System.DateTime> hora_entrada { get; set; }
        public Nullable<System.DateTime> hora_salida { get; set; }
    }
}
