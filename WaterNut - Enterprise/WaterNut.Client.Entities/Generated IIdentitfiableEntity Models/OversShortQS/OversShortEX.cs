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
    public partial class OversShortEX
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.OversShortsId.ToString();//this.OversShortsId == null?"0":			
            }
            set
            {
                this.OversShortsId = Convert.ToInt32(value);
            }
        }
        public string OverShortSuggestedDocumentsEntityName
        {
            get
            {
                return this.OverShortSuggestedDocuments == null ? "" : this.OverShortSuggestedDocuments.EntityName;
            }
            set
            {
                                if (string.IsNullOrEmpty(value)) return;
                string[] vals = value.Split(',');
               
                    using (OverShortSuggestedDocumentClient ctx = new OverShortSuggestedDocumentClient())
                    {
                        var dto = ctx.GetOverShortSuggestedDocuments().Result.AsEnumerable().FirstOrDefault(x => x.EntityName == value);
                        

                        if ( dto == null)
                        {
                            this.OverShortSuggestedDocuments = (OverShortSuggestedDocument)new OverShortSuggestedDocument().CreateEntityFromString(value);
							
							this.OversShortsId = Convert.ToInt32(this.OverShortSuggestedDocuments.OversShortsId);
                            this.TrackingState=TrackableEntities.TrackingState.Modified;
                           NotifyPropertyChanged("AddOverShortSuggestedDocuments");
                        }
                        else
                        {
                            var obj = new OverShortSuggestedDocument(dto);
                           if (this.OverShortSuggestedDocuments == null || this.OverShortSuggestedDocuments.EntityId != obj.EntityId) this.OverShortSuggestedDocuments = obj;
                           
                        }
                         


                    }
            
            }

      }



         #endregion
    }
   
}
		