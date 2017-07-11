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
    
    internal partial class AsycudaDocumentSet_Mapping : EntityTypeConfiguration<AsycudaDocumentSet>
    {
        public AsycudaDocumentSet_Mapping()
        {                        
              this.HasKey(t => t.AsycudaDocumentSetId);        
              this.ToTable("AsycudaDocumentSet");
              this.Property(t => t.AsycudaDocumentSetId).HasColumnName("AsycudaDocumentSetId");
              this.Property(t => t.Declarant_Reference_Number).HasColumnName("Declarant_Reference_Number").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.Exchange_Rate).HasColumnName("Exchange_Rate");
              this.Property(t => t.Customs_ProcedureId).HasColumnName("Customs_ProcedureId");
              this.Property(t => t.Country_of_origin_code).HasColumnName("Country_of_origin_code").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.Currency_Code).HasColumnName("Currency_Code").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.Document_Type_Id).HasColumnName("Document_Type_Id");
              this.Property(t => t.Description).HasColumnName("Description");
              this.Property(t => t.ExportTemplate_Id).HasColumnName("ExportTemplate_Id");
              this.Property(t => t.Manifest_Number).HasColumnName("Manifest_Number").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.BLNumber).HasColumnName("BLNumber").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.EntryTimeStamp).HasColumnName("EntryTimeStamp");
              this.HasOptional(t => t.Customs_Procedure).WithMany(t => t.AsycudaDocumentSet).HasForeignKey(d => d.Customs_ProcedureId);
              this.HasOptional(t => t.Document_Type).WithMany(t => t.AsycudaDocumentSet).HasForeignKey(d => d.Document_Type_Id);
              this.HasOptional(t => t.ExportTemplate).WithMany(t => t.AsycudaDocumentSet).HasForeignKey(d => d.ExportTemplate_Id);
         }
    }
}
