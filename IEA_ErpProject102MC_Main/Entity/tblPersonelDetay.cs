//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_ErpProject102MC_Main.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPersonelDetay
    {
        public int Id { get; set; }
        public Nullable<int> CariId { get; set; }
        public Nullable<System.DateTime> IsBasiTarih { get; set; }
        public Nullable<System.DateTime> IsBitisTarih { get; set; }
    
        public virtual tblCariler tblCariler { get; set; }
    }
}
