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
using AllocationQS.Client.DTO;


using Core.Common.Validation;

namespace AllocationQS.Client.Entities
{
       public partial class AsycudaSalesAllocationsEx: BaseEntity<AsycudaSalesAllocationsEx>
    {
        DTO.AsycudaSalesAllocationsEx asycudasalesallocationsex;
        public AsycudaSalesAllocationsEx(DTO.AsycudaSalesAllocationsEx dto )
        {
              asycudasalesallocationsex = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.AsycudaSalesAllocationsEx>(asycudasalesallocationsex);

        }

        public DTO.AsycudaSalesAllocationsEx DTO
        {
            get
            {
             return asycudasalesallocationsex;
            }
            set
            {
                asycudasalesallocationsex = value;
            }
        }
       [RequiredValidationAttribute(ErrorMessage= "Allocation is required")]
       
public int AllocationId
		{ 
		    get { return this.asycudasalesallocationsex.AllocationId; }
			set
			{
			    if (value == this.asycudasalesallocationsex.AllocationId) return;
				this.asycudasalesallocationsex.AllocationId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("AllocationId");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> TotalValue
		{ 
		    get { return this.asycudasalesallocationsex.TotalValue; }
			set
			{
			    if (value == this.asycudasalesallocationsex.TotalValue) return;
				this.asycudasalesallocationsex.TotalValue = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TotalValue");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> AllocatedValue
		{ 
		    get { return this.asycudasalesallocationsex.AllocatedValue; }
			set
			{
			    if (value == this.asycudasalesallocationsex.AllocatedValue) return;
				this.asycudasalesallocationsex.AllocatedValue = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("AllocatedValue");
			}
		}
     

       
       
                
                
public string Status
		{ 
		    get { return this.asycudasalesallocationsex.Status; }
			set
			{
			    if (value == this.asycudasalesallocationsex.Status) return;
				this.asycudasalesallocationsex.Status = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Status");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> QtyAllocated
		{ 
		    get { return this.asycudasalesallocationsex.QtyAllocated; }
			set
			{
			    if (value == this.asycudasalesallocationsex.QtyAllocated) return;
				this.asycudasalesallocationsex.QtyAllocated = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("QtyAllocated");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> xLineNumber
		{ 
		    get { return this.asycudasalesallocationsex.xLineNumber; }
			set
			{
			    if (value == this.asycudasalesallocationsex.xLineNumber) return;
				this.asycudasalesallocationsex.xLineNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("xLineNumber");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "PreviousItem_ is required")]
       
public int PreviousItem_Id
		{ 
		    get { return this.asycudasalesallocationsex.PreviousItem_Id; }
			set
			{
			    if (value == this.asycudasalesallocationsex.PreviousItem_Id) return;
				this.asycudasalesallocationsex.PreviousItem_Id = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("PreviousItem_Id");
			}
		}
     

       
       
public Nullable<System.DateTime> InvoiceDate
		{ 
		    get { return this.asycudasalesallocationsex.InvoiceDate; }
			set
			{
			    if (value == this.asycudasalesallocationsex.InvoiceDate) return;
				this.asycudasalesallocationsex.InvoiceDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("InvoiceDate");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> SalesQuantity
		{ 
		    get { return this.asycudasalesallocationsex.SalesQuantity; }
			set
			{
			    if (value == this.asycudasalesallocationsex.SalesQuantity) return;
				this.asycudasalesallocationsex.SalesQuantity = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("SalesQuantity");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> SalesQtyAllocated
		{ 
		    get { return this.asycudasalesallocationsex.SalesQtyAllocated; }
			set
			{
			    if (value == this.asycudasalesallocationsex.SalesQtyAllocated) return;
				this.asycudasalesallocationsex.SalesQtyAllocated = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("SalesQtyAllocated");
			}
		}
     

       
       
                
                [MaxLength(50, ErrorMessage = "InvoiceNo has a max length of 50 letters ")]
public string InvoiceNo
		{ 
		    get { return this.asycudasalesallocationsex.InvoiceNo; }
			set
			{
			    if (value == this.asycudasalesallocationsex.InvoiceNo) return;
				this.asycudasalesallocationsex.InvoiceNo = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("InvoiceNo");
			}
		}
     

       
       
                
                [MaxLength(50, ErrorMessage = "ItemNumber has a max length of 50 letters ")]
public string ItemNumber
		{ 
		    get { return this.asycudasalesallocationsex.ItemNumber; }
			set
			{
			    if (value == this.asycudasalesallocationsex.ItemNumber) return;
				this.asycudasalesallocationsex.ItemNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemNumber");
			}
		}
     

       
       
                
                
public string ItemDescription
		{ 
		    get { return this.asycudasalesallocationsex.ItemDescription; }
			set
			{
			    if (value == this.asycudasalesallocationsex.ItemDescription) return;
				this.asycudasalesallocationsex.ItemDescription = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemDescription");
			}
		}
     

       
       
public Nullable<int> EntryDataDetailsId
		{ 
		    get { return this.asycudasalesallocationsex.EntryDataDetailsId; }
			set
			{
			    if (value == this.asycudasalesallocationsex.EntryDataDetailsId) return;
				this.asycudasalesallocationsex.EntryDataDetailsId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("EntryDataDetailsId");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "xBond_Item_ is required")]
       
public int xBond_Item_Id
		{ 
		    get { return this.asycudasalesallocationsex.xBond_Item_Id; }
			set
			{
			    if (value == this.asycudasalesallocationsex.xBond_Item_Id) return;
				this.asycudasalesallocationsex.xBond_Item_Id = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("xBond_Item_Id");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "DutyFreePaid is required")]
       
                
                [MaxLength(9, ErrorMessage = "DutyFreePaid has a max length of 9 letters ")]
public string DutyFreePaid
		{ 
		    get { return this.asycudasalesallocationsex.DutyFreePaid; }
			set
			{
			    if (value == this.asycudasalesallocationsex.DutyFreePaid) return;
				this.asycudasalesallocationsex.DutyFreePaid = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DutyFreePaid");
			}
		}
     

       
       
                
                
public string pCNumber
		{ 
		    get { return this.asycudasalesallocationsex.pCNumber; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pCNumber) return;
				this.asycudasalesallocationsex.pCNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pCNumber");
			}
		}
     

       
       
public Nullable<System.DateTime> pRegistrationDate
		{ 
		    get { return this.asycudasalesallocationsex.pRegistrationDate; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pRegistrationDate) return;
				this.asycudasalesallocationsex.pRegistrationDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pRegistrationDate");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> pQuantity
		{ 
		    get { return this.asycudasalesallocationsex.pQuantity; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pQuantity) return;
				this.asycudasalesallocationsex.pQuantity = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pQuantity");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> pQtyAllocated
		{ 
		    get { return this.asycudasalesallocationsex.pQtyAllocated; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pQtyAllocated) return;
				this.asycudasalesallocationsex.pQtyAllocated = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pQtyAllocated");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> PiQuantity
		{ 
		    get { return this.asycudasalesallocationsex.PiQuantity; }
			set
			{
			    if (value == this.asycudasalesallocationsex.PiQuantity) return;
				this.asycudasalesallocationsex.PiQuantity = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("PiQuantity");
			}
		}
     

       
       
                
                
public string xCNumber
		{ 
		    get { return this.asycudasalesallocationsex.xCNumber; }
			set
			{
			    if (value == this.asycudasalesallocationsex.xCNumber) return;
				this.asycudasalesallocationsex.xCNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("xCNumber");
			}
		}
     

       
       
public Nullable<System.DateTime> xRegistrationDate
		{ 
		    get { return this.asycudasalesallocationsex.xRegistrationDate; }
			set
			{
			    if (value == this.asycudasalesallocationsex.xRegistrationDate) return;
				this.asycudasalesallocationsex.xRegistrationDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("xRegistrationDate");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> pLineNumber
		{ 
		    get { return this.asycudasalesallocationsex.pLineNumber; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pLineNumber) return;
				this.asycudasalesallocationsex.pLineNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pLineNumber");
			}
		}
     

       
       
public Nullable<int> xASYCUDA_Id
		{ 
		    get { return this.asycudasalesallocationsex.xASYCUDA_Id; }
			set
			{
			    if (value == this.asycudasalesallocationsex.xASYCUDA_Id) return;
				this.asycudasalesallocationsex.xASYCUDA_Id = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("xASYCUDA_Id");
			}
		}
     

       
       
public Nullable<int> pASYCUDA_Id
		{ 
		    get { return this.asycudasalesallocationsex.pASYCUDA_Id; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pASYCUDA_Id) return;
				this.asycudasalesallocationsex.pASYCUDA_Id = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pASYCUDA_Id");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Cost
		{ 
		    get { return this.asycudasalesallocationsex.Cost; }
			set
			{
			    if (value == this.asycudasalesallocationsex.Cost) return;
				this.asycudasalesallocationsex.Cost = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Cost");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Total_CIF_itm
		{ 
		    get { return this.asycudasalesallocationsex.Total_CIF_itm; }
			set
			{
			    if (value == this.asycudasalesallocationsex.Total_CIF_itm) return;
				this.asycudasalesallocationsex.Total_CIF_itm = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Total_CIF_itm");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> DutyLiability
		{ 
		    get { return this.asycudasalesallocationsex.DutyLiability; }
			set
			{
			    if (value == this.asycudasalesallocationsex.DutyLiability) return;
				this.asycudasalesallocationsex.DutyLiability = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DutyLiability");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> TaxAmount
		{ 
		    get { return this.asycudasalesallocationsex.TaxAmount; }
			set
			{
			    if (value == this.asycudasalesallocationsex.TaxAmount) return;
				this.asycudasalesallocationsex.TaxAmount = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TaxAmount");
			}
		}
     

       
       
public Nullable<bool> pIsAssessed
		{ 
		    get { return this.asycudasalesallocationsex.pIsAssessed; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pIsAssessed) return;
				this.asycudasalesallocationsex.pIsAssessed = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pIsAssessed");
			}
		}
     

       
       
public Nullable<bool> DoNotAllocateSales
		{ 
		    get { return this.asycudasalesallocationsex.DoNotAllocateSales; }
			set
			{
			    if (value == this.asycudasalesallocationsex.DoNotAllocateSales) return;
				this.asycudasalesallocationsex.DoNotAllocateSales = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DoNotAllocateSales");
			}
		}
     

       
       
public Nullable<bool> DoNotAllocatePreviousEntry
		{ 
		    get { return this.asycudasalesallocationsex.DoNotAllocatePreviousEntry; }
			set
			{
			    if (value == this.asycudasalesallocationsex.DoNotAllocatePreviousEntry) return;
				this.asycudasalesallocationsex.DoNotAllocatePreviousEntry = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DoNotAllocatePreviousEntry");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> SANumber
		{ 
		    get { return this.asycudasalesallocationsex.SANumber; }
			set
			{
			    if (value == this.asycudasalesallocationsex.SANumber) return;
				this.asycudasalesallocationsex.SANumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("SANumber");
			}
		}
     

       
       
                
                
public string pReferenceNumber
		{ 
		    get { return this.asycudasalesallocationsex.pReferenceNumber; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pReferenceNumber) return;
				this.asycudasalesallocationsex.pReferenceNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pReferenceNumber");
			}
		}
     

       
       
                
                
public string xReferenceNumber
		{ 
		    get { return this.asycudasalesallocationsex.xReferenceNumber; }
			set
			{
			    if (value == this.asycudasalesallocationsex.xReferenceNumber) return;
				this.asycudasalesallocationsex.xReferenceNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("xReferenceNumber");
			}
		}
     

       
       
                
                [MaxLength(8, ErrorMessage = "TariffCode has a max length of 8 letters ")]
public string TariffCode
		{ 
		    get { return this.asycudasalesallocationsex.TariffCode; }
			set
			{
			    if (value == this.asycudasalesallocationsex.TariffCode) return;
				this.asycudasalesallocationsex.TariffCode = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TariffCode");
			}
		}
     

       
       
public Nullable<bool> Invalid
		{ 
		    get { return this.asycudasalesallocationsex.Invalid; }
			set
			{
			    if (value == this.asycudasalesallocationsex.Invalid) return;
				this.asycudasalesallocationsex.Invalid = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Invalid");
			}
		}
     

       
       
public Nullable<System.DateTime> pExpiryDate
		{ 
		    get { return this.asycudasalesallocationsex.pExpiryDate; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pExpiryDate) return;
				this.asycudasalesallocationsex.pExpiryDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pExpiryDate");
			}
		}
     

       
       
                
                
public string CustomerName
		{ 
		    get { return this.asycudasalesallocationsex.CustomerName; }
			set
			{
			    if (value == this.asycudasalesallocationsex.CustomerName) return;
				this.asycudasalesallocationsex.CustomerName = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("CustomerName");
			}
		}
     

       
       
                
                [MaxLength(8, ErrorMessage = "pTariffCode has a max length of 8 letters ")]
public string pTariffCode
		{ 
		    get { return this.asycudasalesallocationsex.pTariffCode; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pTariffCode) return;
				this.asycudasalesallocationsex.pTariffCode = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pTariffCode");
			}
		}
     

       
       
                
                [MaxLength(50, ErrorMessage = "pItemNumber has a max length of 50 letters ")]
public string pItemNumber
		{ 
		    get { return this.asycudasalesallocationsex.pItemNumber; }
			set
			{
			    if (value == this.asycudasalesallocationsex.pItemNumber) return;
				this.asycudasalesallocationsex.pItemNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("pItemNumber");
			}
		}
     


        ChangeTrackingCollection<DTO.AsycudaSalesAllocationsEx> _changeTracker;    
        public ChangeTrackingCollection<DTO.AsycudaSalesAllocationsEx> ChangeTracker
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


