//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SlicerConf.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Printer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Printer()
        {
            this.PrinterSettings = new HashSet<PrinterSetting>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxBuildX { get; set; }
        public int MaxBuildY { get; set; }
        public int MaxBuildZ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrinterSetting> PrinterSettings { get; set; }
    }
}