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
    
    public partial class xcuda_Transit_Destination
    {
        public int Destination_Id { get; set; }
        public string Office { get; set; }
        public string Country { get; set; }
        public int Transit_Id { get; set; }
    
        public virtual xcuda_Transit xcuda_Transit { get; set; }
    }
}