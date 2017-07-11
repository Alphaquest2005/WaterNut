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
using CounterPointQS.Client.DTO;
using TrackableEntities.Client;
using TrackableEntities;
using Core.Common.Validation;

namespace CounterPointQS.Client.Entities
{
       public partial class CounterPointPODetails: BaseEntity<CounterPointPODetails>
    {
        DTO.CounterPointPODetails counterpointpodetails;
        public CounterPointPODetails(DTO.CounterPointPODetails dto )
        {
              counterpointpodetails = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.CounterPointPODetails>(counterpointpodetails);

        }

        public DTO.CounterPointPODetails DTO
        {
            get
            {
             return counterpointpodetails;
            }
            set
            {
                counterpointpodetails = value;
            }
        }
       [RequiredValidationAttribute(ErrorMessage= "PO_NO is required")]
       
                
                [MaxLength(20, ErrorMessage = "PO_NO has a max length of 20 letters ")]
public string PO_NO
		{ 
		    get { return this.counterpointpodetails.PO_NO; }
			set
			{
			    if (value == this.counterpointpodetails.PO_NO) return;
				this.counterpointpodetails.PO_NO = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("PO_NO");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "SEQ_NO is required")]
       [NumberValidationAttribute]
public int SEQ_NO
		{ 
		    get { return this.counterpointpodetails.SEQ_NO; }
			set
			{
			    if (value == this.counterpointpodetails.SEQ_NO) return;
				this.counterpointpodetails.SEQ_NO = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("SEQ_NO");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "ITEM_NO is required")]
       
                
                [MaxLength(20, ErrorMessage = "ITEM_NO has a max length of 20 letters ")]
public string ITEM_NO
		{ 
		    get { return this.counterpointpodetails.ITEM_NO; }
			set
			{
			    if (value == this.counterpointpodetails.ITEM_NO) return;
				this.counterpointpodetails.ITEM_NO = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ITEM_NO");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "ORD_QTY is required")]
       [NumberValidationAttribute]
public decimal ORD_QTY
		{ 
		    get { return this.counterpointpodetails.ORD_QTY; }
			set
			{
			    if (value == this.counterpointpodetails.ORD_QTY) return;
				this.counterpointpodetails.ORD_QTY = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ORD_QTY");
			}
		}
     

       
       
                
                [MaxLength(15, ErrorMessage = "ORD_UNIT has a max length of 15 letters ")]
public string ORD_UNIT
		{ 
		    get { return this.counterpointpodetails.ORD_UNIT; }
			set
			{
			    if (value == this.counterpointpodetails.ORD_UNIT) return;
				this.counterpointpodetails.ORD_UNIT = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ORD_UNIT");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "ITEM_DESCR is required")]
       
                
                [MaxLength(50, ErrorMessage = "ITEM_DESCR has a max length of 50 letters ")]
public string ITEM_DESCR
		{ 
		    get { return this.counterpointpodetails.ITEM_DESCR; }
			set
			{
			    if (value == this.counterpointpodetails.ITEM_DESCR) return;
				this.counterpointpodetails.ITEM_DESCR = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ITEM_DESCR");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "ORD_COST is required")]
       [NumberValidationAttribute]
public decimal ORD_COST
		{ 
		    get { return this.counterpointpodetails.ORD_COST; }
			set
			{
			    if (value == this.counterpointpodetails.ORD_COST) return;
				this.counterpointpodetails.ORD_COST = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ORD_COST");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<decimal> UNIT_WEIGHT
		{ 
		    get { return this.counterpointpodetails.UNIT_WEIGHT; }
			set
			{
			    if (value == this.counterpointpodetails.UNIT_WEIGHT) return;
				this.counterpointpodetails.UNIT_WEIGHT = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("UNIT_WEIGHT");
			}
		}
     


        ChangeTrackingCollection<DTO.CounterPointPODetails> _changeTracker;    
        public ChangeTrackingCollection<DTO.CounterPointPODetails> ChangeTracker
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

