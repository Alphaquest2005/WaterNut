//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntryDataQS
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntryDataEx
    {
        public EntryDataEx()
        {
            this.AsycudaDocumentSets = new HashSet<AsycudaDocumentSetEntryData>();
            this.AsycudaDocuments = new HashSet<AsycudaDocumentEntryData>();
            this.EntryDataDetailsExs = new HashSet<EntryDataDetailsEx>();
        }
    
        public string Type { get; set; }
        public string DutyFreePaid { get; set; }
        public Nullable<double> Total { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
    
        public virtual ICollection<AsycudaDocumentSetEntryData> AsycudaDocumentSets { get; set; }
        public virtual ICollection<AsycudaDocumentEntryData> AsycudaDocuments { get; set; }
        public virtual ICollection<EntryDataDetailsEx> EntryDataDetailsExs { get; set; }
    }
}
