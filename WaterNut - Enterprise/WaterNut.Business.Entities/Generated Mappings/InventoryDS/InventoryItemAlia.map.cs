﻿namespace InventoryDS.Business.Entities.Mapping
{
    //#pragma warning disable 1573
    using Entities;
    using System.Data.Entity.ModelConfiguration;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class InventoryItemAliaMap : EntityTypeConfiguration<InventoryItemAlia>
    {
        public InventoryItemAliaMap()
        {                        
              this.HasKey(t => t.AliasId);        
              this.ToTable("InventoryItemAlias");
              this.Property(t => t.AliasId).HasColumnName("AliasId").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.Identity));
              this.Property(t => t.ItemNumber).HasColumnName("ItemNumber").IsRequired().IsUnicode(false).HasMaxLength(50);
              this.Property(t => t.AliasName).HasColumnName("AliasName").IsRequired().IsUnicode(false).HasMaxLength(50);
              this.HasRequired(t => t.InventoryItem).WithMany(t =>(ICollection<InventoryItemAlia>) t.InventoryItemAlias).HasForeignKey(d => d.ItemNumber);
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
