﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using CoreEntities.Client.Entities;
using CoreEntities.Client.Services;
//using WaterNut.Client.Services;
using EntryDataQS.Client.Services;

using System;

namespace EntryDataQS.Client.Entities
{
    public partial class EntryDataDetailsEx
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.EntryDataDetailsId.ToString();//this.EntryDataDetailsId == null?"0":			
            }
            set
            {
                this.EntryDataDetailsId = Convert.ToInt32(value);
            }
        }
        public string InventoryItemsExEntityName
        {
            get
            {
                return this.InventoryItemsEx == null ? "" : this.InventoryItemsEx.EntityName;
            }
            set
            {
                                if (string.IsNullOrEmpty(value)) return;
                string[] vals = value.Split(',');
               
                    using (InventoryItemsExClient ctx = new InventoryItemsExClient())
                    {
                        var dto = ctx.GetInventoryItemsEx().Result.AsEnumerable().FirstOrDefault(x => x.EntityName == value);
                        

                        if ( dto == null)
                        {
                            this.InventoryItemsEx = (InventoryItemsEx)new InventoryItemsEx().CreateEntityFromString(value);
							
							this.EntryDataDetailsId = Convert.ToInt32(this.InventoryItemsEx.ItemNumber);
                            this.TrackingState=TrackableEntities.TrackingState.Modified;
                           NotifyPropertyChanged("AddInventoryItemsEx");
                        }
                        else
                        {
                            var obj = new InventoryItemsEx(dto);
                           if (this.InventoryItemsEx == null || this.InventoryItemsEx.EntityId != obj.EntityId) this.InventoryItemsEx = obj;
                           
                        }
                         


                    }
            
            }

      }
        public string EntryDataExEntityName
        {
            get
            {
                return this.EntryDataEx == null ? "" : this.EntryDataEx.EntityName;
            }
            set
            {
                                if (string.IsNullOrEmpty(value)) return;
                string[] vals = value.Split(',');
               
                    using (EntryDataExClient ctx = new EntryDataExClient())
                    {
                        var dto = ctx.GetEntryDataEx().Result.AsEnumerable().FirstOrDefault(x => x.EntityName == value);
                        

                        if ( dto == null)
                        {
                            this.EntryDataEx = (EntryDataEx)new EntryDataEx().CreateEntityFromString(value);
							
							this.EntryDataDetailsId = Convert.ToInt32(this.EntryDataEx.InvoiceNo);
                            this.TrackingState=TrackableEntities.TrackingState.Modified;
                           NotifyPropertyChanged("AddEntryDataEx");
                        }
                        else
                        {
                            var obj = new EntryDataEx(dto);
                           if (this.EntryDataEx == null || this.EntryDataEx.EntityId != obj.EntityId) this.EntryDataEx = obj;
                           
                        }
                         


                    }
            
            }

      }



         #endregion
    }
   
}
		