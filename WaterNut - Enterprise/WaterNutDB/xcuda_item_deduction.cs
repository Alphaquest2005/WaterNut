//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaterNutDB
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class xcuda_item_deduction
    {
        public float Amount_national_currency { get; set; }
        public float Amount_foreign_currency { get; set; }
        public string Currency_name { get; set; }
        public string Currency_rate { get; set; }
        public int Valuation_item_Id { get; set; }
    
        public virtual xcuda_Valuation_item xcuda_Valuation_item { get; set; }
    }
}