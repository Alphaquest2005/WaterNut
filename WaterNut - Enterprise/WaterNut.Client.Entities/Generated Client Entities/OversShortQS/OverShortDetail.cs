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
using OversShortQS.Client.DTO;


using Core.Common.Validation;

namespace OversShortQS.Client.Entities
{
       public partial class OverShortDetail: BaseEntity<OverShortDetail>
    {
        DTO.OverShortDetail overshortdetail;
        public OverShortDetail(DTO.OverShortDetail dto )
        {
              overshortdetail = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.OverShortDetail>(overshortdetail);

        }

        public DTO.OverShortDetail DTO
        {
            get
            {
             return overshortdetail;
            }
            set
            {
                overshortdetail = value;
            }
        }
        


       [RequiredValidationAttribute(ErrorMessage= "OverShortDetail is required")]
       
public int OverShortDetailId
		{ 
		    get { return this.overshortdetail.OverShortDetailId; }
			set
			{
			    if (value == this.overshortdetail.OverShortDetailId) return;
				this.overshortdetail.OverShortDetailId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("OverShortDetailId");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "OversShorts is required")]
       
public int OversShortsId
		{ 
		    get { return this.overshortdetail.OversShortsId; }
			set
			{
			    if (value == this.overshortdetail.OversShortsId) return;
				this.overshortdetail.OversShortsId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("OversShortsId");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> ReceivedQty
		{ 
		    get { return this.overshortdetail.ReceivedQty; }
			set
			{
			    if (value == this.overshortdetail.ReceivedQty) return;
				this.overshortdetail.ReceivedQty = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ReceivedQty");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "ItemNumber is required")]
       
                
                [MaxLength(50, ErrorMessage = "ItemNumber has a max length of 50 letters ")]
public string ItemNumber
		{ 
		    get { return this.overshortdetail.ItemNumber; }
			set
			{
			    if (value == this.overshortdetail.ItemNumber) return;
				this.overshortdetail.ItemNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemNumber");
			}
		}
     

       
       
                
                
public string ItemDescription
		{ 
		    get { return this.overshortdetail.ItemDescription; }
			set
			{
			    if (value == this.overshortdetail.ItemDescription) return;
				this.overshortdetail.ItemDescription = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemDescription");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Cost
		{ 
		    get { return this.overshortdetail.Cost; }
			set
			{
			    if (value == this.overshortdetail.Cost) return;
				this.overshortdetail.Cost = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Cost");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> InvoiceQty
		{ 
		    get { return this.overshortdetail.InvoiceQty; }
			set
			{
			    if (value == this.overshortdetail.InvoiceQty) return;
				this.overshortdetail.InvoiceQty = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("InvoiceQty");
			}
		}
     

       
       
                
                
public string Status
		{ 
		    get { return this.overshortdetail.Status; }
			set
			{
			    if (value == this.overshortdetail.Status) return;
				this.overshortdetail.Status = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Status");
			}
		}
     

        ObservableCollection<OverShortDetailAllocation> _OverShortDetailAllocations = null;
        public  ObservableCollection<OverShortDetailAllocation> OverShortDetailAllocations
		{
            
		    get 
				{ 
					if(_OverShortDetailAllocations != null) return _OverShortDetailAllocations;
					//if (this.overshortdetail.OverShortDetailAllocations == null) Debugger.Break();
					if(this.overshortdetail.OverShortDetailAllocations != null)
					{
						_OverShortDetailAllocations = new ObservableCollection<OverShortDetailAllocation>(this.overshortdetail.OverShortDetailAllocations.Select(x => new OverShortDetailAllocation(x)));
					}
					
						_OverShortDetailAllocations.CollectionChanged += OverShortDetailAllocations_CollectionChanged; 
					
					return _OverShortDetailAllocations; 
				}
			set
			{
			    if (Equals(value, _OverShortDetailAllocations)) return;
				if (value != null)
					this.overshortdetail.OverShortDetailAllocations = new ChangeTrackingCollection<DTO.OverShortDetailAllocation>(value.Select(x => x.DTO).ToList());
                _OverShortDetailAllocations = value;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				if (_OverShortDetailAllocations != null)
				_OverShortDetailAllocations.CollectionChanged += OverShortDetailAllocations_CollectionChanged;               
				NotifyPropertyChanged("OverShortDetailAllocations");
			}
		}
        
        void OverShortDetailAllocations_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (OverShortDetailAllocation itm in e.NewItems)
                    {
                        if (itm != null)
                        overshortdetail.OverShortDetailAllocations.Add(itm.DTO);
                    }
                    if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (OverShortDetailAllocation itm in e.OldItems)
                    {
                        if (itm != null)
                        overshortdetail.OverShortDetailAllocations.Remove(itm.DTO);
                    }
					if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                
            }
        }


        ChangeTrackingCollection<DTO.OverShortDetail> _changeTracker;    
        public ChangeTrackingCollection<DTO.OverShortDetail> ChangeTracker
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
                return this.TrackingState;
            }
            set
            {
                this.TrackingState = value;
                NotifyPropertyChanged("TrackingState");
            }
        }

    }
}


