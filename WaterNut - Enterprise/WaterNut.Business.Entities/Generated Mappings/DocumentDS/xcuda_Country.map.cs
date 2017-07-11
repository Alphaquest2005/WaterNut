﻿namespace DocumentDS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class xcuda_CountryMap : EntityTypeConfiguration<xcuda_Country>
    {
        public xcuda_CountryMap()
        {                        
              this.HasKey(t => t.Country_Id);        
              this.ToTable("xcuda_Country");
              this.Property(t => t.Country_first_destination).HasColumnName("Country_first_destination").IsUnicode(false);
              this.Property(t => t.Country_of_origin_name).HasColumnName("Country_of_origin_name").IsUnicode(false);
              this.Property(t => t.Country_Id).HasColumnName("Country_Id").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.Place_of_loading_Id).HasColumnName("Place_of_loading_Id");
              this.Property(t => t.Trading_country).HasColumnName("Trading_country").IsUnicode(false).HasMaxLength(50);
              this.HasRequired(t => t.xcuda_General_information).WithOptional(t => t.xcuda_Country);
              this.HasOptional(t => t.xcuda_Destination).WithRequired(t => t.xcuda_Country);
              this.HasOptional(t => t.xcuda_Export).WithRequired(t => t.xcuda_Country);
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