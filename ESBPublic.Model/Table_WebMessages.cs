//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESBPublic.Model
{
    using System;

    public partial class Table_WebMessages
    {
        public long Id { get; set; }
        public int FK_ProjectId { get; set; }
        public int FK_LanguageId { get; set; }
        public string MessageCode { get; set; }
        public string Body { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Lookup_Language Lookup_Language { get; set; }
        public virtual Lookup_Projects Lookup_Projects { get; set; }
    }
}
