﻿namespace SalesDataQS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class SalesDataDetailMap : EntityTypeConfiguration<SalesDataDetail>
    {
        public SalesDataDetailMap()
        {                        
              this.HasKey(t => t.EntryDataDetailsId);        
              this.ToTable("SalesDataDetails");
              this.Property(t => t.EntryDataDetailsId).HasColumnName("EntryDataDetailsId").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.EntryDataId).HasColumnName("EntryDataId").IsRequired().IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.LineNumber).HasColumnName("LineNumber");
              this.Property(t => t.ItemNumber).HasColumnName("ItemNumber").IsRequired().IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.Quantity).HasColumnName("Quantity");
              this.Property(t => t.Units).HasColumnName("Units").IsUnicode(false).HasMaxLength(15);
              this.Property(t => t.ItemDescription).HasColumnName("ItemDescription").IsRequired().IsUnicode(false);
              this.Property(t => t.Cost).HasColumnName("Cost");
              this.Property(t => t.QtyAllocated).HasColumnName("QtyAllocated");
              this.Property(t => t.UnitWeight).HasColumnName("UnitWeight");
              this.Property(t => t.DoNotAllocate).HasColumnName("DoNotAllocate");
              this.Property(t => t.TariffCode).HasColumnName("TariffCode").IsUnicode(false).HasMaxLength(8);
              this.Property(t => t.CNumber).HasColumnName("CNumber").IsUnicode(false);
              this.Property(t => t.CLineNumber).HasColumnName("CLineNumber");
              this.Property(t => t.Downloaded).HasColumnName("Downloaded");
              this.Property(t => t.ASYCUDA_Id).HasColumnName("ASYCUDA_Id");
              this.Property(t => t.SalesValue).HasColumnName("SalesValue");
              this.Property(t => t.EntryDataDate).HasColumnName("EntryDataDate");
              this.HasRequired(t => t.SalesData).WithMany(t =>(ICollection<SalesDataDetail>) t.SalesDataDetails).HasForeignKey(d => d.EntryDataId);
              this.HasMany(t => t.AsycudaDocumentSetEntryDataDetails).WithRequired(t => (SalesDataDetail)t.SalesDataDetail);
             // Tracking Properties
    			this.Ignore(t => t.TrackingState);
    			this.Ignore(t => t.ModifiedProperties);
    
    
             // IIdentifibleEntity
                this.Ignore(t => t.EntityId);
                this.Ignore(t => t.EntityName); 
    
                this.Ignore(t => t.EntityKey);
             // Nav Property Names
                  
    
    
              
    
         }
    }
}
