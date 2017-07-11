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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class xcuda_Container_Mapping : EntityTypeConfiguration<xcuda_Container>
    {
        public xcuda_Container_Mapping()
        {                        
              this.HasKey(t => t.Container_Id);        
              this.ToTable("xcuda_Container");
              this.Property(t => t.Item_Number).HasColumnName("Item_Number").IsUnicode(false);
              this.Property(t => t.Container_identity).HasColumnName("Container_identity").IsUnicode(false);
              this.Property(t => t.Container_type).HasColumnName("Container_type").IsUnicode(false);
              this.Property(t => t.Empty_full_indicator).HasColumnName("Empty_full_indicator").IsUnicode(false);
              this.Property(t => t.Gross_weight).HasColumnName("Gross_weight");
              this.Property(t => t.Goods_description).HasColumnName("Goods_description").IsUnicode(false);
              this.Property(t => t.Packages_type).HasColumnName("Packages_type").IsUnicode(false);
              this.Property(t => t.Packages_number).HasColumnName("Packages_number").IsUnicode(false);
              this.Property(t => t.Packages_weight).HasColumnName("Packages_weight");
              this.Property(t => t.ASYCUDA_Id).HasColumnName("ASYCUDA_Id");
              this.Property(t => t.Container_Id).HasColumnName("Container_Id");
              this.HasOptional(t => t.xcuda_ASYCUDA).WithMany(t => t.xcuda_Container).HasForeignKey(d => d.ASYCUDA_Id);
         }
    }
}
