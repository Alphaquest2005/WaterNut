﻿namespace DocumentDS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class xcuda_ASYCUDA_ExtendedPropertiesMap : EntityTypeConfiguration<xcuda_ASYCUDA_ExtendedProperties>
    {
        public xcuda_ASYCUDA_ExtendedPropertiesMap()
        {                        
              this.HasKey(t => t.ASYCUDA_Id);        
              this.ToTable("xcuda_ASYCUDA_ExtendedProperties");
              this.Property(t => t.ASYCUDA_Id).HasColumnName("ASYCUDA_Id").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.AsycudaDocumentSetId).HasColumnName("AsycudaDocumentSetId");
              this.Property(t => t.FileNumber).HasColumnName("FileNumber");
              this.Property(t => t.IsManuallyAssessed).HasColumnName("IsManuallyAssessed");
              this.Property(t => t.CNumber).HasColumnName("CNumber").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.RegistrationDate).HasColumnName("RegistrationDate");
              this.Property(t => t.ReferenceNumber).HasColumnName("ReferenceNumber").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.Customs_ProcedureId).HasColumnName("Customs_ProcedureId");
              this.Property(t => t.Document_TypeId).HasColumnName("Document_TypeId");
              this.Property(t => t.Description).HasColumnName("Description");
              this.Property(t => t.ExportTemplateId).HasColumnName("ExportTemplateId");
              this.Property(t => t.BLNumber).HasColumnName("BLNumber").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.AutoUpdate).HasColumnName("AutoUpdate");
              this.Property(t => t.EffectiveRegistrationDate).HasColumnName("EffectiveRegistrationDate");
              this.Property(t => t.DoNotAllocate).HasColumnName("DoNotAllocate");
              this.Property(t => t.ImportComplete).HasColumnName("ImportComplete");
              this.Property(t => t.DocumentLines).HasColumnName("DocumentLines");
              this.Property(t => t.Cancelled).HasColumnName("Cancelled");
              this.Property(t => t.ApportionMethod).HasColumnName("ApportionMethod");
              this.Property(t => t.TotalWeight).HasColumnName("TotalWeight");
              this.Property(t => t.TotalFreight).HasColumnName("TotalFreight");
              this.Property(t => t.TotalInternalFreight).HasColumnName("TotalInternalFreight");
              this.Property(t => t.TotalPackages).HasColumnName("TotalPackages");
              this.HasOptional(t => t.AsycudaDocumentSet).WithMany(t => t.xcuda_ASYCUDA_ExtendedProperties).HasForeignKey(d => d.AsycudaDocumentSetId);
              this.HasOptional(t => t.Customs_Procedure).WithMany(t => t.xcuda_ASYCUDA_ExtendedProperties).HasForeignKey(d => d.Customs_ProcedureId);
              this.HasOptional(t => t.Document_Type).WithMany(t => t.xcuda_ASYCUDA_ExtendedProperties).HasForeignKey(d => d.Document_TypeId);
              this.HasOptional(t => t.ExportTemplate).WithMany(t => t.xcuda_ASYCUDA_ExtendedProperties).HasForeignKey(d => d.ExportTemplateId);
              this.HasRequired(t => t.xcuda_ASYCUDA).WithOptional(t => t.xcuda_ASYCUDA_ExtendedProperties);
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
