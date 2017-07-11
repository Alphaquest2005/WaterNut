//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OverShortsQS
{
    using System;
    using System.Collections.Generic;
    
    public partial class AsycudaDocumentItem
    {
        public AsycudaDocumentItem()
        {
            this.OverShortAllocationsEXes = new HashSet<OverShortAllocationsEX>();
        }
    
        public int Item_Id { get; set; }
        public int AsycudaDocumentId { get; set; }
        public Nullable<int> EntryDataDetailsId { get; set; }
        public int LineNumber { get; set; }
        public Nullable<bool> IsAssessed { get; set; }
        public Nullable<bool> DoNotAllocate { get; set; }
        public Nullable<bool> DoNotEX { get; set; }
        public Nullable<bool> AttributeOnlyAllocation { get; set; }
        public string Description_of_goods { get; set; }
        public string Commercial_Description { get; set; }
        public double Gross_weight_itm { get; set; }
        public Nullable<double> Net_weight_itm { get; set; }
        public Nullable<double> Item_price { get; set; }
        public Nullable<double> ItemQuantity { get; set; }
        public string Suppplementary_unit_code { get; set; }
        public string ItemNumber { get; set; }
        public string TariffCode { get; set; }
        public Nullable<bool> TariffCodeLicenseRequired { get; set; }
        public Nullable<bool> TariffCategoryLicenseRequired { get; set; }
        public string TariffCodeDescription { get; set; }
        public Nullable<double> DutyLiability { get; set; }
        public Nullable<double> Total_CIF_itm { get; set; }
        public Nullable<double> Freight { get; set; }
        public Nullable<double> Statistical_value { get; set; }
        public double DPQtyAllocated { get; set; }
        public double DFQtyAllocated { get; set; }
        public Nullable<double> PiQuantity { get; set; }
        public bool ImportComplete { get; set; }
    
        public virtual AsycudaDocument AsycudaDocument { get; set; }
        public virtual ICollection<OverShortAllocationsEX> OverShortAllocationsEXes { get; set; }
    }
}
