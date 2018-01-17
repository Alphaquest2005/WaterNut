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
using SalesDataQS.Client.DTO;


using Core.Common.Validation;

namespace SalesDataQS.Client.Entities
{
       public partial class SalesDataDetail: BaseEntity<SalesDataDetail>
    {
        DTO.SalesDataDetail salesdatadetail;
        public SalesDataDetail(DTO.SalesDataDetail dto )
        {
              salesdatadetail = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.SalesDataDetail>(salesdatadetail);

        }

        public DTO.SalesDataDetail DTO
        {
            get
            {
             return salesdatadetail;
            }
            set
            {
                salesdatadetail = value;
            }
        }
        


       [RequiredValidationAttribute(ErrorMessage= "EntryDataDetails is required")]
       
public int EntryDataDetailsId
		{ 
		    get { return this.salesdatadetail.EntryDataDetailsId; }
			set
			{
			    if (value == this.salesdatadetail.EntryDataDetailsId) return;
				this.salesdatadetail.EntryDataDetailsId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("EntryDataDetailsId");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "EntryData is required")]
       
                
                [MaxLength(50, ErrorMessage = "EntryDataId has a max length of 50 letters ")]
public string EntryDataId
		{ 
		    get { return this.salesdatadetail.EntryDataId; }
			set
			{
			    if (value == this.salesdatadetail.EntryDataId) return;
				this.salesdatadetail.EntryDataId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("EntryDataId");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> LineNumber
		{ 
		    get { return this.salesdatadetail.LineNumber; }
			set
			{
			    if (value == this.salesdatadetail.LineNumber) return;
				this.salesdatadetail.LineNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("LineNumber");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "ItemNumber is required")]
       
                
                [MaxLength(50, ErrorMessage = "ItemNumber has a max length of 50 letters ")]
public string ItemNumber
		{ 
		    get { return this.salesdatadetail.ItemNumber; }
			set
			{
			    if (value == this.salesdatadetail.ItemNumber) return;
				this.salesdatadetail.ItemNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemNumber");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "Quantity is required")]
       [NumberValidationAttribute]
public double Quantity
		{ 
		    get { return this.salesdatadetail.Quantity; }
			set
			{
			    if (value == this.salesdatadetail.Quantity) return;
				this.salesdatadetail.Quantity = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Quantity");
			}
		}
     

       
       
                
                [MaxLength(15, ErrorMessage = "Units has a max length of 15 letters ")]
public string Units
		{ 
		    get { return this.salesdatadetail.Units; }
			set
			{
			    if (value == this.salesdatadetail.Units) return;
				this.salesdatadetail.Units = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Units");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "ItemDescription is required")]
       
                
                
public string ItemDescription
		{ 
		    get { return this.salesdatadetail.ItemDescription; }
			set
			{
			    if (value == this.salesdatadetail.ItemDescription) return;
				this.salesdatadetail.ItemDescription = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemDescription");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "Cost is required")]
       [NumberValidationAttribute]
public double Cost
		{ 
		    get { return this.salesdatadetail.Cost; }
			set
			{
			    if (value == this.salesdatadetail.Cost) return;
				this.salesdatadetail.Cost = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Cost");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "QtyAllocated is required")]
       [NumberValidationAttribute]
public double QtyAllocated
		{ 
		    get { return this.salesdatadetail.QtyAllocated; }
			set
			{
			    if (value == this.salesdatadetail.QtyAllocated) return;
				this.salesdatadetail.QtyAllocated = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("QtyAllocated");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "UnitWeight is required")]
       [NumberValidationAttribute]
public double UnitWeight
		{ 
		    get { return this.salesdatadetail.UnitWeight; }
			set
			{
			    if (value == this.salesdatadetail.UnitWeight) return;
				this.salesdatadetail.UnitWeight = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("UnitWeight");
			}
		}
     

       
       
public Nullable<bool> DoNotAllocate
		{ 
		    get { return this.salesdatadetail.DoNotAllocate; }
			set
			{
			    if (value == this.salesdatadetail.DoNotAllocate) return;
				this.salesdatadetail.DoNotAllocate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DoNotAllocate");
			}
		}
     

       
       
                
                [MaxLength(8, ErrorMessage = "TariffCode has a max length of 8 letters ")]
public string TariffCode
		{ 
		    get { return this.salesdatadetail.TariffCode; }
			set
			{
			    if (value == this.salesdatadetail.TariffCode) return;
				this.salesdatadetail.TariffCode = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TariffCode");
			}
		}
     

       
       
                
                
public string CNumber
		{ 
		    get { return this.salesdatadetail.CNumber; }
			set
			{
			    if (value == this.salesdatadetail.CNumber) return;
				this.salesdatadetail.CNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("CNumber");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> CLineNumber
		{ 
		    get { return this.salesdatadetail.CLineNumber; }
			set
			{
			    if (value == this.salesdatadetail.CLineNumber) return;
				this.salesdatadetail.CLineNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("CLineNumber");
			}
		}
     

       
       
public Nullable<bool> Downloaded
		{ 
		    get { return this.salesdatadetail.Downloaded; }
			set
			{
			    if (value == this.salesdatadetail.Downloaded) return;
				this.salesdatadetail.Downloaded = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Downloaded");
			}
		}
     

       
       
public Nullable<int> ASYCUDA_Id
		{ 
		    get { return this.salesdatadetail.ASYCUDA_Id; }
			set
			{
			    if (value == this.salesdatadetail.ASYCUDA_Id) return;
				this.salesdatadetail.ASYCUDA_Id = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ASYCUDA_Id");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "SalesValue is required")]
       [NumberValidationAttribute]
public double SalesValue
		{ 
		    get { return this.salesdatadetail.SalesValue; }
			set
			{
			    if (value == this.salesdatadetail.SalesValue) return;
				this.salesdatadetail.SalesValue = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("SalesValue");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "EntryDataDate is required")]
       
public System.DateTime EntryDataDate
		{ 
		    get { return this.salesdatadetail.EntryDataDate; }
			set
			{
			    if (value == this.salesdatadetail.EntryDataDate) return;
				this.salesdatadetail.EntryDataDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("EntryDataDate");
			}
		}
     

       private SalesData _SalesData;
        public  SalesData SalesData
		{
		    get
               { 
                  if (this.salesdatadetail != null)
                   {
                       if (_SalesData != null)
                       {
                           if (this.salesdatadetail.SalesData !=
                               _SalesData.DTO)
                           {
                                if (this.salesdatadetail.SalesData  != null)
                               _SalesData = new SalesData(this.salesdatadetail.SalesData);
                           }
                       }
                       else
                       {
                             if (this.salesdatadetail.SalesData  != null)
                           _SalesData = new SalesData(this.salesdatadetail.SalesData);
                       }
                   }


             //       if (_SalesData != null) return _SalesData;
                       
             //       var i = new SalesData(){TrackingState = TrackingState.Added};
			//		//if (this.salesdatadetail.SalesData == null) Debugger.Break();
			//		if (this.salesdatadetail.SalesData != null)
            //        {
            //           i. = this.salesdatadetail.SalesData;
            //        }
            //        else
            //        {
            //            this.salesdatadetail.SalesData = i.;
             //       }
                           
            //        _SalesData = i;
                     
                    return _SalesData;
               }
			set
			{
			    if (value == _SalesData) return;
                _SalesData = value;
                if(value != null)
                     this.salesdatadetail.SalesData = value.DTO;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                NotifyPropertyChanged("SalesData");
			}
		}
        

        ObservableCollection<AsycudaDocumentSetEntryDataDetails> _AsycudaDocumentSetEntryDataDetails = null;
        public  ObservableCollection<AsycudaDocumentSetEntryDataDetails> AsycudaDocumentSetEntryDataDetails
		{
            
		    get 
				{ 
					if(_AsycudaDocumentSetEntryDataDetails != null) return _AsycudaDocumentSetEntryDataDetails;
					//if (this.salesdatadetail.AsycudaDocumentSetEntryDataDetails == null) Debugger.Break();
					if(this.salesdatadetail.AsycudaDocumentSetEntryDataDetails != null)
					{
						_AsycudaDocumentSetEntryDataDetails = new ObservableCollection<AsycudaDocumentSetEntryDataDetails>(this.salesdatadetail.AsycudaDocumentSetEntryDataDetails.Select(x => new AsycudaDocumentSetEntryDataDetails(x)));
					}
					
						_AsycudaDocumentSetEntryDataDetails.CollectionChanged += AsycudaDocumentSetEntryDataDetails_CollectionChanged; 
					
					return _AsycudaDocumentSetEntryDataDetails; 
				}
			set
			{
			    if (Equals(value, _AsycudaDocumentSetEntryDataDetails)) return;
				if (value != null)
					this.salesdatadetail.AsycudaDocumentSetEntryDataDetails = new ChangeTrackingCollection<DTO.AsycudaDocumentSetEntryDataDetails>(value.Select(x => x.DTO).ToList());
                _AsycudaDocumentSetEntryDataDetails = value;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				if (_AsycudaDocumentSetEntryDataDetails != null)
				_AsycudaDocumentSetEntryDataDetails.CollectionChanged += AsycudaDocumentSetEntryDataDetails_CollectionChanged;               
				NotifyPropertyChanged("AsycudaDocumentSetEntryDataDetails");
			}
		}
        
        void AsycudaDocumentSetEntryDataDetails_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (AsycudaDocumentSetEntryDataDetails itm in e.NewItems)
                    {
                        if (itm != null)
                        salesdatadetail.AsycudaDocumentSetEntryDataDetails.Add(itm.DTO);
                    }
                    if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (AsycudaDocumentSetEntryDataDetails itm in e.OldItems)
                    {
                        if (itm != null)
                        salesdatadetail.AsycudaDocumentSetEntryDataDetails.Remove(itm.DTO);
                    }
					if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                
            }
        }


        ChangeTrackingCollection<DTO.SalesDataDetail> _changeTracker;    
        public ChangeTrackingCollection<DTO.SalesDataDetail> ChangeTracker
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


