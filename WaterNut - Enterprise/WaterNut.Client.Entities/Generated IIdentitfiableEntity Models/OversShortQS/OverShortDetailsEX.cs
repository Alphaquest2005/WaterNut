﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using OversShortQS.Client.Entities;
using OversShortQS.Client.Services;
//using WaterNut.Client.Services;
using OversShortQS.Client.Services;

using System;

namespace OversShortQS.Client.Entities
{
    public partial class OverShortDetailsEX
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.OverShortDetailId.ToString();//this.OverShortDetailId == null?"0":			
            }
            set
            {
                this.OverShortDetailId = Convert.ToInt32(value);
            }
        }
        public string OversShortEXEntityName
        {
            get
            {
                return this.OversShortEX == null ? "" : this.OversShortEX.EntityName;
            }
            set
            {
                                if (string.IsNullOrEmpty(value)) return;
                string[] vals = value.Split(',');
               
                    using (OversShortEXClient ctx = new OversShortEXClient())
                    {
                        var dto = ctx.GetOversShorts().Result.AsEnumerable().FirstOrDefault(x => x.EntityName == value);
                        

                        if ( dto == null)
                        {
                            this.OversShortEX = (OversShortEX)new OversShortEX().CreateEntityFromString(value);
							
							this.OverShortDetailId = Convert.ToInt32(this.OversShortEX.OversShortsId);
                            this.TrackingState=TrackableEntities.TrackingState.Modified;
                           NotifyPropertyChanged("AddOversShortEX");
                        }
                        else
                        {
                            var obj = new OversShortEX(dto);
                           if (this.OversShortEX == null || this.OversShortEX.EntityId != obj.EntityId) this.OversShortEX = obj;
                           
                        }
                         


                    }
            
            }

      }
        public string InventoryItemEntityName
        {
            get
            {
                return this.InventoryItem == null ? "" : this.InventoryItem.EntityName;
            }
            set
            {
                                if (string.IsNullOrEmpty(value)) return;
                string[] vals = value.Split(',');
               
                    using (InventoryItemClient ctx = new InventoryItemClient())
                    {
                        var dto = ctx.GetInventoryItems().Result.AsEnumerable().FirstOrDefault(x => x.EntityName == value);
                        

                        if ( dto == null)
                        {
                            this.InventoryItem = (InventoryItem)new InventoryItem().CreateEntityFromString(value);
							
							this.OverShortDetailId = Convert.ToInt32(this.InventoryItem.ItemNumber);
                            this.TrackingState=TrackableEntities.TrackingState.Modified;
                           NotifyPropertyChanged("AddInventoryItem");
                        }
                        else
                        {
                            var obj = new InventoryItem(dto);
                           if (this.InventoryItem == null || this.InventoryItem.EntityId != obj.EntityId) this.InventoryItem = obj;
                           
                        }
                         


                    }
            
            }

      }



         #endregion
    }
   
}
		