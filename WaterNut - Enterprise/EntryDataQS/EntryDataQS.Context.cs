﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntryDataQS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntryDataQS : DbContext
    {
        public EntryDataQS()
            : base("name=EntryDataQS")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<InventoryItemsEx> InventoryItemsEx { get; set; }
        public DbSet<EntryDataEx> EntryDataEx { get; set; }
        public DbSet<AsycudaDocumentEntryData> AsycudaDocumentEntryDatas { get; set; }
        public DbSet<AsycudaDocumentSetEntryData> AsycudaDocumentSetEntryDatas { get; set; }
        public DbSet<EntryDataDetailsEx> EntryDataDetailsExes { get; set; }
        public DbSet<AsycudaDocumentSetEntryDataDetail> AsycudaDocumentSetEntryDataDetails { get; set; }
    }
}