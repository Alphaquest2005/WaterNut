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
    
    public partial class xcuda_General_information
    {
        public string Value_details { get; set; }
        public int ASYCUDA_Id { get; set; }
        public string CAP { get; set; }
        public string Additional_information { get; set; }
        public string Comments_free_text { get; set; }
    
        public virtual xcuda_ASYCUDA xcuda_ASYCUDA { get; set; }
        public virtual xcuda_Country xcuda_Country { get; set; }
    }
}
