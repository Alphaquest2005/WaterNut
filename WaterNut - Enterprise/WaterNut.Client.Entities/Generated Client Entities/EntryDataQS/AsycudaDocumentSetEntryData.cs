﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using WaterNut.Interfaces;
using Core.Common.Client.Entities;
using EntryDataQS.Client.DTO;
using TrackableEntities.Client;
using TrackableEntities;
using Core.Common.Validation;

namespace EntryDataQS.Client.Entities
{
       public partial class AsycudaDocumentSetEntryData: BaseEntity<AsycudaDocumentSetEntryData>
    {
        DTO.AsycudaDocumentSetEntryData asycudadocumentsetentrydata;
        public AsycudaDocumentSetEntryData(DTO.AsycudaDocumentSetEntryData dto )
        {
              asycudadocumentsetentrydata = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.AsycudaDocumentSetEntryData>(asycudadocumentsetentrydata);

        }

        public DTO.AsycudaDocumentSetEntryData DTO
        {
            get
            {
             return asycudadocumentsetentrydata;
            }
            set
            {
                asycudadocumentsetentrydata = value;
            }
        }
       [RequiredValidationAttribute(ErrorMessage= "AsycudaDocumentSet is required")]
       
public int AsycudaDocumentSetId
		{ 
		    get { return this.asycudadocumentsetentrydata.AsycudaDocumentSetId; }
			set
			{
			    if (value == this.asycudadocumentsetentrydata.AsycudaDocumentSetId) return;
				this.asycudadocumentsetentrydata.AsycudaDocumentSetId = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("AsycudaDocumentSetId");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "EntryData is required")]
       
                
                [MaxLength(50, ErrorMessage = "EntryDataId has a max length of 50 letters ")]
public string EntryDataId
		{ 
		    get { return this.asycudadocumentsetentrydata.EntryDataId; }
			set
			{
			    if (value == this.asycudadocumentsetentrydata.EntryDataId) return;
				this.asycudadocumentsetentrydata.EntryDataId = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("EntryDataId");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= " is required")]
       
public int Id
		{ 
		    get { return this.asycudadocumentsetentrydata.Id; }
			set
			{
			    if (value == this.asycudadocumentsetentrydata.Id) return;
				this.asycudadocumentsetentrydata.Id = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Id");
			}
		}
     

       private EntryDataEx _EntryDataEx;
        public  EntryDataEx EntryDataEx
		{
		    get
               { 
                  if (this.asycudadocumentsetentrydata != null)
                   {
                       if (_EntryDataEx != null)
                       {
                           if (this.asycudadocumentsetentrydata.EntryDataEx !=
                               _EntryDataEx.DTO)
                           {
                                if (this.asycudadocumentsetentrydata.EntryDataEx  != null)
                               _EntryDataEx = new EntryDataEx(this.asycudadocumentsetentrydata.EntryDataEx);
                           }
                       }
                       else
                       {
                             if (this.asycudadocumentsetentrydata.EntryDataEx  != null)
                           _EntryDataEx = new EntryDataEx(this.asycudadocumentsetentrydata.EntryDataEx);
                       }
                   }


             //       if (_EntryDataEx != null) return _EntryDataEx;
                       
             //       var i = new EntryDataEx(){TrackingState = TrackingState.Added};
			//		//if (this.asycudadocumentsetentrydata.EntryDataEx == null) Debugger.Break();
			//		if (this.asycudadocumentsetentrydata.EntryDataEx != null)
            //        {
            //           i. = this.asycudadocumentsetentrydata.EntryDataEx;
            //        }
            //        else
            //        {
            //            this.asycudadocumentsetentrydata.EntryDataEx = i.;
             //       }
                           
            //        _EntryDataEx = i;
                     
                    return _EntryDataEx;
               }
			set
			{
			    if (value == _EntryDataEx) return;
                _EntryDataEx = value;
                if(value != null)
                     this.asycudadocumentsetentrydata.EntryDataEx = value.DTO;
				if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
                NotifyPropertyChanged("EntryDataEx");
			}
		}
        


        ChangeTrackingCollection<DTO.AsycudaDocumentSetEntryData> _changeTracker;    
        public ChangeTrackingCollection<DTO.AsycudaDocumentSetEntryData> ChangeTracker
        {
            get
            {
                return _changeTracker;
            }
        }

        public new TrackableEntities.TrackingState TrackingState
        {
            get
            {
                return this.DTO.TrackingState;
            }
            set
            {
                this.DTO.TrackingState = value;
                NotifyPropertyChanged("TrackingState");
            }
        }

    }
}


