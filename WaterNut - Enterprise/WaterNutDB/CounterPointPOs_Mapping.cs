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
    
    internal partial class CounterPointPOs_Mapping : EntityTypeConfiguration<CounterPointPOs>
    {
        public CounterPointPOs_Mapping()
        {                        
              this.HasKey(t => new {t.PO_NO, t.DATE, t.LIN_CNT});        
              this.ToTable("CounterPointPOs", "WaterNutDBDataLayerStoreContainer");
              this.Property(t => t.PO_NO).HasColumnName("PO_NO").IsRequired().IsUnicode(false).HasMaxLength(20);
              this.Property(t => t.DATE).HasColumnName("DATE");
              this.Property(t => t.LIN_CNT).HasColumnName("LIN_CNT").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
         }
    }
}