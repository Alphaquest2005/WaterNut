﻿// <autogenerated>
//   This file was generated by T4 code generator AllObjectContext.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

            


using System.Data.Entity;
using CoreEntities.Business.Entities;
using System.Data.Entity.Infrastructure;
using OversShortQS.Business.Entities.Mapping;
using WaterNut.Data;
using System.Data.Entity.Core.Objects;
using TrackableEntities;


namespace OversShortQS.Business.Entities
{
    [DbConfigurationType(typeof(DBConfiguration))] 
    public partial class OversShortQSContext : DbContext
    {
        static OversShortQSContext()
        {
            var x = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            Database.SetInitializer<OversShortQSContext>(null);
        }

        public OversShortQSContext()
            : base("Name=OversShortQS")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
               // Get the ObjectContext related to this DbContext
            var objectContext = (this as IObjectContextAdapter).ObjectContext;

            // Sets the command timeout for all the commands
            objectContext.CommandTimeout = 120;

            objectContext.ObjectMaterialized += ObjectContext_OnObjectMaterialized;
        }
        
        public bool StartTracking { get; set; }

        private void ObjectContext_OnObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            if (StartTracking == true) ((dynamic)e.Entity).StartTracking();
        }

        public DbSet<InventoryItem> InventoryItems { get; set; }
     
        public DbSet<OverShortDetailAllocation> OverShortDetailAllocations { get; set; }
     
        public DbSet<OverShortDetail> OverShortDetails { get; set; }
     
        public DbSet<OversShort> OversShorts { get; set; }
     
        public DbSet<OverShortAllocationsEX> OverShortAllocationsEXes { get; set; }
     
        public DbSet<AsycudaDocumentItem> AsycudaDocumentItems { get; set; }
     
        public DbSet<AsycudaDocument> AsycudaDocuments { get; set; }
     
        public DbSet<OverShortSuggestedDocument> OverShortSuggestedDocuments { get; set; }
     


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new InventoryItemMap());
         
            modelBuilder.Configurations.Add(new OverShortDetailAllocationMap());
         
            modelBuilder.Configurations.Add(new OverShortDetailMap());
         
            modelBuilder.Configurations.Add(new OversShortMap());
         
            modelBuilder.Configurations.Add(new OverShortAllocationsEXMap());
         
            modelBuilder.Configurations.Add(new AsycudaDocumentItemMap());
         
            modelBuilder.Configurations.Add(new AsycudaDocumentMap());
         
            modelBuilder.Configurations.Add(new OverShortSuggestedDocumentMap());
         
            modelBuilder.Configurations.Add(new OverShortDetailsEXMap());
      
            modelBuilder.Configurations.Add(new OversShortEXMap());
      
            modelBuilder.Entity<OverShortDetailsEX>().ToTable("OverShortDetails_OverShortDetailsEX");
      
            modelBuilder.Entity<OversShortEX>().ToTable("OversShorts_OversShortEX");
      
			OnModelCreatingExtentsion(modelBuilder);

        }
		partial void OnModelCreatingExtentsion(DbModelBuilder modelBuilder);
    }
}

 	