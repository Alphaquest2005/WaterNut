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
    
    public partial class xcuda_Packages
    {
        public float Number_of_packages { get; set; }
        public string Kind_of_packages_code { get; set; }
        public string Kind_of_packages_name { get; set; }
        public int Packages_Id { get; set; }
        public Nullable<int> Item_Id { get; set; }
        public string Marks1_of_packages { get; set; }
        public string Marks2_of_packages { get; set; }
    
        public virtual xcuda_Item xcuda_Item { get; set; }
    }
}
