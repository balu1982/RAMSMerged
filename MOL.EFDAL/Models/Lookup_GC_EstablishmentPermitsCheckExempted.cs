//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOL.EFDAL.Models
{
    using System;

    public partial class Lookup_GC_EstablishmentPermitsCheckExempted
    {
        public int ID { get; set; }
        public long EstablishmentID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public long CreatedBy { get; set; }
    
        public virtual MOL_User MOL_User { get; set; }
        public virtual MOL_Establishment MOL_Establishment { get; set; }
    }
}
