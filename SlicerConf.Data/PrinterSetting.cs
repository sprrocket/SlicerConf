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
    
    public partial class PrinterSetting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double LayerHeight { get; set; }
        public int Perimeters { get; set; }
        public int TopShells { get; set; }
        public int BottomShells { get; set; }
        public int PrinterId { get; set; }
    
        public virtual Printer Printer { get; set; }
    }
}
