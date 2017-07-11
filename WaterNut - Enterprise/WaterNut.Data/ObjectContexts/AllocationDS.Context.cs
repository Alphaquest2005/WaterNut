﻿// <autogenerated>
//   This file was generated by T4 code generator ObjectContext.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

            


using System.Data.Entity;
using CoreEntities.Business.Entities;
using System.Data.Entity.Infrastructure;
using AllocationDS.Business.Entities.Mapping;
using WaterNut.Data;
using System.Data.Entity.Core.Objects;
using TrackableEntities;


namespace AllocationDS.Business.Entities
{
    [DbConfigurationType(typeof(DBConfiguration))] 
    public partial class AllocationDSContext : DbContext
    {
        static AllocationDSContext()
        {
            var x = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            Database.SetInitializer<AllocationDSContext>(null);
        }

        public AllocationDSContext()
            : base("Name=AllocationDS")
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

        public DbSet<AsycudaSalesAllocations> AsycudaSalesAllocations { get; set; }
     
        public DbSet<EntryDataDetails> EntryDataDetails { get; set; }
     
        public DbSet<xcuda_Item> xcuda_Item { get; set; }
     
        public DbSet<EntryDataDetailsEx> EntryDataDetailsEx { get; set; }
     
        public DbSet<EntryData> EntryData { get; set; }
     
        public DbSet<xcuda_PreviousItem> xcuda_PreviousItem { get; set; }
     
        public DbSet<AsycudaDocument> AsycudaDocument { get; set; }
     
        public DbSet<SubItems> SubItems { get; set; }
     
        public DbSet<InventoryItems> InventoryItems { get; set; }
     
        public DbSet<TariffCategory> TariffCategory { get; set; }
     
        public DbSet<TariffCodes> TariffCodes { get; set; }
     
        public DbSet<TariffSupUnitLkps> TariffSupUnitLkps { get; set; }
     
        public DbSet<xcuda_Goods_description> xcuda_Goods_description { get; set; }
     
        public DbSet<xcuda_HScode> xcuda_HScode { get; set; }
     
        public DbSet<xcuda_Item_Invoice> xcuda_Item_Invoice { get; set; }
     
        public DbSet<xcuda_Supplementary_unit> xcuda_Supplementary_unit { get; set; }
     
        public DbSet<xcuda_Tarification> xcuda_Tarification { get; set; }
     
        public DbSet<xcuda_Taxation> xcuda_Taxation { get; set; }
     
        public DbSet<xcuda_Taxation_line> xcuda_Taxation_line { get; set; }
     
        public DbSet<xcuda_Valuation_item> xcuda_Valuation_item { get; set; }
     
        public DbSet<xcuda_Weight> xcuda_Weight { get; set; }
     
        public DbSet<xcuda_Weight_itm> xcuda_Weight_itm { get; set; }
     
        public DbSet<AsycudaLkpLst> AsycudaLkpLst { get; set; }
     
        public DbSet<xBondAllocations> xBondAllocations { get; set; }
     
        public DbSet<InventoryItemAlias> InventoryItemAlias { get; set; }
     
        public DbSet<EX9AsycudaSalesAllocations> EX9AsycudaSalesAllocations { get; set; }
     
        public DbSet<EntryPreviousItems> EntryPreviousItems { get; set; }
     


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AsycudaSalesAllocationsMap());
         
            modelBuilder.Configurations.Add(new EntryDataDetailsMap());
         
            modelBuilder.Configurations.Add(new xcuda_ItemMap());
         
            modelBuilder.Configurations.Add(new EntryDataDetailsExMap());
         
            modelBuilder.Configurations.Add(new EntryDataMap());
         
            modelBuilder.Configurations.Add(new xcuda_PreviousItemMap());
         
            modelBuilder.Configurations.Add(new AsycudaDocumentMap());
         
            modelBuilder.Configurations.Add(new SubItemsMap());
         
            modelBuilder.Configurations.Add(new InventoryItemsMap());
         
            modelBuilder.Configurations.Add(new TariffCategoryMap());
         
            modelBuilder.Configurations.Add(new TariffCodesMap());
         
            modelBuilder.Configurations.Add(new TariffSupUnitLkpsMap());
         
            modelBuilder.Configurations.Add(new xcuda_Goods_descriptionMap());
         
            modelBuilder.Configurations.Add(new xcuda_HScodeMap());
         
            modelBuilder.Configurations.Add(new xcuda_Item_InvoiceMap());
         
            modelBuilder.Configurations.Add(new xcuda_Supplementary_unitMap());
         
            modelBuilder.Configurations.Add(new xcuda_TarificationMap());
         
            modelBuilder.Configurations.Add(new xcuda_TaxationMap());
         
            modelBuilder.Configurations.Add(new xcuda_Taxation_lineMap());
         
            modelBuilder.Configurations.Add(new xcuda_Valuation_itemMap());
         
            modelBuilder.Configurations.Add(new xcuda_WeightMap());
         
            modelBuilder.Configurations.Add(new xcuda_Weight_itmMap());
         
            modelBuilder.Configurations.Add(new AsycudaLkpLstMap());
         
            modelBuilder.Configurations.Add(new xBondAllocationsMap());
         
            modelBuilder.Configurations.Add(new InventoryItemAliasMap());
         
            modelBuilder.Configurations.Add(new EX9AsycudaSalesAllocationsMap());
         
            modelBuilder.Configurations.Add(new EntryPreviousItemsMap());
         
            modelBuilder.Configurations.Add(new SalesMap());
      
            modelBuilder.Entity<Sales>().ToTable("EntryData_Sales");
      
			OnModelCreatingExtentsion(modelBuilder);

        }
		partial void OnModelCreatingExtentsion(DbModelBuilder modelBuilder);
    }
}

 	
