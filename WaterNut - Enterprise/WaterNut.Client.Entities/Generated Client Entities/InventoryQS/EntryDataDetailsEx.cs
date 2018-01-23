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
using TrackableEntities.Client;
using Core.Common.Client.Entities;
using InventoryQS.Client.DTO;


using Core.Common.Validation;

namespace InventoryQS.Client.Entities
{
       public partial class EntryDataDetailsEx: BaseEntity<EntryDataDetailsEx>
    {
        DTO.EntryDataDetailsEx entrydatadetailsex;
        public EntryDataDetailsEx(DTO.EntryDataDetailsEx dto )
        {
              entrydatadetailsex = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.EntryDataDetailsEx>(entrydatadetailsex);

        }

        public DTO.EntryDataDetailsEx DTO
        {
            get
            {
             return entrydatadetailsex;
            }
            set
            {
                entrydatadetailsex = value;
            }
        }
       [RequiredValidationAttribute(ErrorMessage= "EntryDataDetails is required")]
       
public int EntryDataDetailsId
		{ 
		    get { return this.entrydatadetailsex.EntryDataDetailsId; }
			set
			{
			    if (value == this.entrydatadetailsex.EntryDataDetailsId) return;
				this.entrydatadetailsex.EntryDataDetailsId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("EntryDataDetailsId");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "EntryData is required")]
       
                
                [MaxLength(50, ErrorMessage = "EntryDataId has a max length of 50 letters ")]
public string EntryDataId
		{ 
		    get { return this.entrydatadetailsex.EntryDataId; }
			set
			{
			    if (value == this.entrydatadetailsex.EntryDataId) return;
				this.entrydatadetailsex.EntryDataId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("EntryDataId");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> LineNumber
		{ 
		    get { return this.entrydatadetailsex.LineNumber; }
			set
			{
			    if (value == this.entrydatadetailsex.LineNumber) return;
				this.entrydatadetailsex.LineNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("LineNumber");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "ItemNumber is required")]
       
                
                [MaxLength(50, ErrorMessage = "ItemNumber has a max length of 50 letters ")]
public string ItemNumber
		{ 
		    get { return this.entrydatadetailsex.ItemNumber; }
			set
			{
			    if (value == this.entrydatadetailsex.ItemNumber) return;
				this.entrydatadetailsex.ItemNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemNumber");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "Quantity is required")]
       
public float Quantity
		{ 
		    get { return this.entrydatadetailsex.Quantity; }
			set
			{
			    if (value == this.entrydatadetailsex.Quantity) return;
				this.entrydatadetailsex.Quantity = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Quantity");
			}
		}
     

       
       
                
                [MaxLength(15, ErrorMessage = "Units has a max length of 15 letters ")]
public string Units
		{ 
		    get { return this.entrydatadetailsex.Units; }
			set
			{
			    if (value == this.entrydatadetailsex.Units) return;
				this.entrydatadetailsex.Units = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Units");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "ItemDescription is required")]
       
                
                
public string ItemDescription
		{ 
		    get { return this.entrydatadetailsex.ItemDescription; }
			set
			{
			    if (value == this.entrydatadetailsex.ItemDescription) return;
				this.entrydatadetailsex.ItemDescription = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemDescription");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "Cost is required")]
       
public float Cost
		{ 
		    get { return this.entrydatadetailsex.Cost; }
			set
			{
			    if (value == this.entrydatadetailsex.Cost) return;
				this.entrydatadetailsex.Cost = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Cost");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "QtyAllocated is required")]
       [NumberValidationAttribute]
public double QtyAllocated
		{ 
		    get { return this.entrydatadetailsex.QtyAllocated; }
			set
			{
			    if (value == this.entrydatadetailsex.QtyAllocated) return;
				this.entrydatadetailsex.QtyAllocated = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("QtyAllocated");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "UnitWeight is required")]
       
public float UnitWeight
		{ 
		    get { return this.entrydatadetailsex.UnitWeight; }
			set
			{
			    if (value == this.entrydatadetailsex.UnitWeight) return;
				this.entrydatadetailsex.UnitWeight = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("UnitWeight");
			}
		}
     

       
       
public Nullable<bool> DoNotAllocate
		{ 
		    get { return this.entrydatadetailsex.DoNotAllocate; }
			set
			{
			    if (value == this.entrydatadetailsex.DoNotAllocate) return;
				this.entrydatadetailsex.DoNotAllocate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DoNotAllocate");
			}
		}
     

       
       
                
                [MaxLength(8, ErrorMessage = "TariffCode has a max length of 8 letters ")]
public string TariffCode
		{ 
		    get { return this.entrydatadetailsex.TariffCode; }
			set
			{
			    if (value == this.entrydatadetailsex.TariffCode) return;
				this.entrydatadetailsex.TariffCode = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TariffCode");
			}
		}
     

       
       
                
                
public string CNumber
		{ 
		    get { return this.entrydatadetailsex.CNumber; }
			set
			{
			    if (value == this.entrydatadetailsex.CNumber) return;
				this.entrydatadetailsex.CNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("CNumber");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> CLineNumber
		{ 
		    get { return this.entrydatadetailsex.CLineNumber; }
			set
			{
			    if (value == this.entrydatadetailsex.CLineNumber) return;
				this.entrydatadetailsex.CLineNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("CLineNumber");
			}
		}
     

       
       
public Nullable<bool> Downloaded
		{ 
		    get { return this.entrydatadetailsex.Downloaded; }
			set
			{
			    if (value == this.entrydatadetailsex.Downloaded) return;
				this.entrydatadetailsex.Downloaded = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Downloaded");
			}
		}
     

       
       
                
                [MaxLength(9, ErrorMessage = "DutyFreePaid has a max length of 9 letters ")]
public string DutyFreePaid
		{ 
		    get { return this.entrydatadetailsex.DutyFreePaid; }
			set
			{
			    if (value == this.entrydatadetailsex.DutyFreePaid) return;
				this.entrydatadetailsex.DutyFreePaid = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DutyFreePaid");
			}
		}
     

       
       
public Nullable<float> Total
		{ 
		    get { return this.entrydatadetailsex.Total; }
			set
			{
			    if (value == this.entrydatadetailsex.Total) return;
				this.entrydatadetailsex.Total = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Total");
			}
		}
     

       
       
public Nullable<int> AsycudaDocumentSetId
		{ 
		    get { return this.entrydatadetailsex.AsycudaDocumentSetId; }
			set
			{
			    if (value == this.entrydatadetailsex.AsycudaDocumentSetId) return;
				this.entrydatadetailsex.AsycudaDocumentSetId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("AsycudaDocumentSetId");
			}
		}
     

       private InventoryItemsEx _InventoryItemsEx;
        public  InventoryItemsEx InventoryItemsEx
		{
		    get
               { 
                  if (this.entrydatadetailsex != null)
                   {
                       if (_InventoryItemsEx != null)
                       {
                           if (this.entrydatadetailsex.InventoryItemsEx !=
                               _InventoryItemsEx.DTO)
                           {
                                if (this.entrydatadetailsex.InventoryItemsEx  != null)
                               _InventoryItemsEx = new InventoryItemsEx(this.entrydatadetailsex.InventoryItemsEx);
                           }
                       }
                       else
                       {
                             if (this.entrydatadetailsex.InventoryItemsEx  != null)
                           _InventoryItemsEx = new InventoryItemsEx(this.entrydatadetailsex.InventoryItemsEx);
                       }
                   }


             //       if (_InventoryItemsEx != null) return _InventoryItemsEx;
                       
             //       var i = new InventoryItemsEx(){TrackingState = TrackingState.Added};
			//		//if (this.entrydatadetailsex.InventoryItemsEx == null) Debugger.Break();
			//		if (this.entrydatadetailsex.InventoryItemsEx != null)
            //        {
            //           i. = this.entrydatadetailsex.InventoryItemsEx;
            //        }
            //        else
            //        {
            //            this.entrydatadetailsex.InventoryItemsEx = i.;
             //       }
                           
            //        _InventoryItemsEx = i;
                     
                    return _InventoryItemsEx;
               }
			set
			{
			    if (value == _InventoryItemsEx) return;
                _InventoryItemsEx = value;
                if(value != null)
                     this.entrydatadetailsex.InventoryItemsEx = value.DTO;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                NotifyPropertyChanged("InventoryItemsEx");
			}
		}
        


        ChangeTrackingCollection<DTO.EntryDataDetailsEx> _changeTracker;    
        public ChangeTrackingCollection<DTO.EntryDataDetailsEx> ChangeTracker
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


