﻿namespace DocumentDS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class xcuda_Gs_external_freightMap : EntityTypeConfiguration<xcuda_Gs_external_freight>
    {
        public xcuda_Gs_external_freightMap()
        {                        
              this.HasKey(t => t.Valuation_Id);        
              this.ToTable("xcuda_Gs_external_freight");
              this.Property(t => t.Amount_national_currency).HasColumnName("Amount_national_currency");
              this.Property(t => t.Amount_foreign_currency).HasColumnName("Amount_foreign_currency");
              this.Property(t => t.Currency_name).HasColumnName("Currency_name").IsUnicode(false);
              this.Property(t => t.Currency_code).HasColumnName("Currency_code").IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.Currency_rate).HasColumnName("Currency_rate");
              this.Property(t => t.Valuation_Id).HasColumnName("Valuation_Id").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.HasRequired(t => t.xcuda_Valuation).WithOptional(t => (xcuda_Gs_external_freight)t.xcuda_Gs_external_freight);
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
