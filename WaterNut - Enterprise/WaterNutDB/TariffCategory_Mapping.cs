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
    
    internal partial class TariffCategory_Mapping : EntityTypeConfiguration<TariffCategory>
    {
        public TariffCategory_Mapping()
        {                        
              this.HasKey(t => t.TariffCategoryCode);        
              this.ToTable("TariffCategory");
              this.Property(t => t.TariffCategoryCode).HasColumnName("TariffCategoryCode").IsRequired().IsUnicode(false).HasMaxLength(8);
              this.Property(t => t.Description).HasColumnName("Description").IsUnicode(false).HasMaxLength(999);
              this.Property(t => t.ParentTariffCategoryCode).HasColumnName("ParentTariffCategoryCode").IsUnicode(false).HasMaxLength(5);
              this.Property(t => t.LicenseRequired).HasColumnName("LicenseRequired");
         }
    }
}
