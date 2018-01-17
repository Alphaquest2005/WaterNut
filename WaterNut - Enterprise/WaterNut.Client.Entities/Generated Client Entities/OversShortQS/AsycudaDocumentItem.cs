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
       public partial class AsycudaDocumentItem: BaseEntity<AsycudaDocumentItem>
    {
        DTO.AsycudaDocumentItem asycudadocumentitem;
        public AsycudaDocumentItem(DTO.AsycudaDocumentItem dto )
        {
              asycudadocumentitem = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.AsycudaDocumentItem>(asycudadocumentitem);

        }

        public DTO.AsycudaDocumentItem DTO
        {
            get
            {
             return asycudadocumentitem;
            }
            set
            {
                asycudadocumentitem = value;
            }
        }
        


       [RequiredValidationAttribute(ErrorMessage= "Item_ is required")]
       
public int Item_Id
		{ 
		    get { return this.asycudadocumentitem.Item_Id; }
			set
			{
			    if (value == this.asycudadocumentitem.Item_Id) return;
				this.asycudadocumentitem.Item_Id = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Item_Id");
			}
		}
     

       
       
public Nullable<int> AsycudaDocumentId
		{ 
		    get { return this.asycudadocumentitem.AsycudaDocumentId; }
			set
			{
			    if (value == this.asycudadocumentitem.AsycudaDocumentId) return;
				this.asycudadocumentitem.AsycudaDocumentId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("AsycudaDocumentId");
			}
		}
     

       
       
public Nullable<int> EntryDataDetailsId
		{ 
		    get { return this.asycudadocumentitem.EntryDataDetailsId; }
			set
			{
			    if (value == this.asycudadocumentitem.EntryDataDetailsId) return;
				this.asycudadocumentitem.EntryDataDetailsId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("EntryDataDetailsId");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> LineNumber
		{ 
		    get { return this.asycudadocumentitem.LineNumber; }
			set
			{
			    if (value == this.asycudadocumentitem.LineNumber) return;
				this.asycudadocumentitem.LineNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("LineNumber");
			}
		}
     

       
       
public Nullable<bool> IsAssessed
		{ 
		    get { return this.asycudadocumentitem.IsAssessed; }
			set
			{
			    if (value == this.asycudadocumentitem.IsAssessed) return;
				this.asycudadocumentitem.IsAssessed = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("IsAssessed");
			}
		}
     

       
       
public Nullable<bool> DoNotAllocate
		{ 
		    get { return this.asycudadocumentitem.DoNotAllocate; }
			set
			{
			    if (value == this.asycudadocumentitem.DoNotAllocate) return;
				this.asycudadocumentitem.DoNotAllocate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DoNotAllocate");
			}
		}
     

       
       
public Nullable<bool> DoNotEX
		{ 
		    get { return this.asycudadocumentitem.DoNotEX; }
			set
			{
			    if (value == this.asycudadocumentitem.DoNotEX) return;
				this.asycudadocumentitem.DoNotEX = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DoNotEX");
			}
		}
     

       
       
public Nullable<bool> AttributeOnlyAllocation
		{ 
		    get { return this.asycudadocumentitem.AttributeOnlyAllocation; }
			set
			{
			    if (value == this.asycudadocumentitem.AttributeOnlyAllocation) return;
				this.asycudadocumentitem.AttributeOnlyAllocation = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("AttributeOnlyAllocation");
			}
		}
     

       
       
                
                
public string Description_of_goods
		{ 
		    get { return this.asycudadocumentitem.Description_of_goods; }
			set
			{
			    if (value == this.asycudadocumentitem.Description_of_goods) return;
				this.asycudadocumentitem.Description_of_goods = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Description_of_goods");
			}
		}
     

       
       
                
                
public string Commercial_Description
		{ 
		    get { return this.asycudadocumentitem.Commercial_Description; }
			set
			{
			    if (value == this.asycudadocumentitem.Commercial_Description) return;
				this.asycudadocumentitem.Commercial_Description = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Commercial_Description");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "Gross_weight_itm is required")]
       [NumberValidationAttribute]
public double Gross_weight_itm
		{ 
		    get { return this.asycudadocumentitem.Gross_weight_itm; }
			set
			{
			    if (value == this.asycudadocumentitem.Gross_weight_itm) return;
				this.asycudadocumentitem.Gross_weight_itm = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Gross_weight_itm");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "Net_weight_itm is required")]
       [NumberValidationAttribute]
public double Net_weight_itm
		{ 
		    get { return this.asycudadocumentitem.Net_weight_itm; }
			set
			{
			    if (value == this.asycudadocumentitem.Net_weight_itm) return;
				this.asycudadocumentitem.Net_weight_itm = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Net_weight_itm");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Item_price
		{ 
		    get { return this.asycudadocumentitem.Item_price; }
			set
			{
			    if (value == this.asycudadocumentitem.Item_price) return;
				this.asycudadocumentitem.Item_price = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Item_price");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> ItemQuantity
		{ 
		    get { return this.asycudadocumentitem.ItemQuantity; }
			set
			{
			    if (value == this.asycudadocumentitem.ItemQuantity) return;
				this.asycudadocumentitem.ItemQuantity = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemQuantity");
			}
		}
     

       
       
                
                
public string Suppplementary_unit_code
		{ 
		    get { return this.asycudadocumentitem.Suppplementary_unit_code; }
			set
			{
			    if (value == this.asycudadocumentitem.Suppplementary_unit_code) return;
				this.asycudadocumentitem.Suppplementary_unit_code = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Suppplementary_unit_code");
			}
		}
     

       
       
                
                [MaxLength(50, ErrorMessage = "ItemNumber has a max length of 50 letters ")]
public string ItemNumber
		{ 
		    get { return this.asycudadocumentitem.ItemNumber; }
			set
			{
			    if (value == this.asycudadocumentitem.ItemNumber) return;
				this.asycudadocumentitem.ItemNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ItemNumber");
			}
		}
     

       
       
                
                [MaxLength(8, ErrorMessage = "TariffCode has a max length of 8 letters ")]
public string TariffCode
		{ 
		    get { return this.asycudadocumentitem.TariffCode; }
			set
			{
			    if (value == this.asycudadocumentitem.TariffCode) return;
				this.asycudadocumentitem.TariffCode = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TariffCode");
			}
		}
     

       
       
public Nullable<bool> TariffCodeLicenseRequired
		{ 
		    get { return this.asycudadocumentitem.TariffCodeLicenseRequired; }
			set
			{
			    if (value == this.asycudadocumentitem.TariffCodeLicenseRequired) return;
				this.asycudadocumentitem.TariffCodeLicenseRequired = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TariffCodeLicenseRequired");
			}
		}
     

       
       
public Nullable<bool> TariffCategoryLicenseRequired
		{ 
		    get { return this.asycudadocumentitem.TariffCategoryLicenseRequired; }
			set
			{
			    if (value == this.asycudadocumentitem.TariffCategoryLicenseRequired) return;
				this.asycudadocumentitem.TariffCategoryLicenseRequired = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TariffCategoryLicenseRequired");
			}
		}
     

       
       
                
                [MaxLength(999, ErrorMessage = "TariffCodeDescription has a max length of 999 letters ")]
public string TariffCodeDescription
		{ 
		    get { return this.asycudadocumentitem.TariffCodeDescription; }
			set
			{
			    if (value == this.asycudadocumentitem.TariffCodeDescription) return;
				this.asycudadocumentitem.TariffCodeDescription = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TariffCodeDescription");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> DutyLiability
		{ 
		    get { return this.asycudadocumentitem.DutyLiability; }
			set
			{
			    if (value == this.asycudadocumentitem.DutyLiability) return;
				this.asycudadocumentitem.DutyLiability = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DutyLiability");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Total_CIF_itm
		{ 
		    get { return this.asycudadocumentitem.Total_CIF_itm; }
			set
			{
			    if (value == this.asycudadocumentitem.Total_CIF_itm) return;
				this.asycudadocumentitem.Total_CIF_itm = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Total_CIF_itm");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Freight
		{ 
		    get { return this.asycudadocumentitem.Freight; }
			set
			{
			    if (value == this.asycudadocumentitem.Freight) return;
				this.asycudadocumentitem.Freight = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Freight");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Statistical_value
		{ 
		    get { return this.asycudadocumentitem.Statistical_value; }
			set
			{
			    if (value == this.asycudadocumentitem.Statistical_value) return;
				this.asycudadocumentitem.Statistical_value = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Statistical_value");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> DPQtyAllocated
		{ 
		    get { return this.asycudadocumentitem.DPQtyAllocated; }
			set
			{
			    if (value == this.asycudadocumentitem.DPQtyAllocated) return;
				this.asycudadocumentitem.DPQtyAllocated = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DPQtyAllocated");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> DFQtyAllocated
		{ 
		    get { return this.asycudadocumentitem.DFQtyAllocated; }
			set
			{
			    if (value == this.asycudadocumentitem.DFQtyAllocated) return;
				this.asycudadocumentitem.DFQtyAllocated = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DFQtyAllocated");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> PiQuantity
		{ 
		    get { return this.asycudadocumentitem.PiQuantity; }
			set
			{
			    if (value == this.asycudadocumentitem.PiQuantity) return;
				this.asycudadocumentitem.PiQuantity = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("PiQuantity");
			}
		}
     

       
       
public Nullable<bool> ImportComplete
		{ 
		    get { return this.asycudadocumentitem.ImportComplete; }
			set
			{
			    if (value == this.asycudadocumentitem.ImportComplete) return;
				this.asycudadocumentitem.ImportComplete = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ImportComplete");
			}
		}
     

       
       
                
                
public string CNumber
		{ 
		    get { return this.asycudadocumentitem.CNumber; }
			set
			{
			    if (value == this.asycudadocumentitem.CNumber) return;
				this.asycudadocumentitem.CNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("CNumber");
			}
		}
     

       
       
public Nullable<System.DateTime> RegistrationDate
		{ 
		    get { return this.asycudadocumentitem.RegistrationDate; }
			set
			{
			    if (value == this.asycudadocumentitem.RegistrationDate) return;
				this.asycudadocumentitem.RegistrationDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("RegistrationDate");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Number_of_packages
		{ 
		    get { return this.asycudadocumentitem.Number_of_packages; }
			set
			{
			    if (value == this.asycudadocumentitem.Number_of_packages) return;
				this.asycudadocumentitem.Number_of_packages = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Number_of_packages");
			}
		}
     

       
       
                
                
public string Country_of_origin_code
		{ 
		    get { return this.asycudadocumentitem.Country_of_origin_code; }
			set
			{
			    if (value == this.asycudadocumentitem.Country_of_origin_code) return;
				this.asycudadocumentitem.Country_of_origin_code = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Country_of_origin_code");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> PiWeight
		{ 
		    get { return this.asycudadocumentitem.PiWeight; }
			set
			{
			    if (value == this.asycudadocumentitem.PiWeight) return;
				this.asycudadocumentitem.PiWeight = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("PiWeight");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Currency_rate
		{ 
		    get { return this.asycudadocumentitem.Currency_rate; }
			set
			{
			    if (value == this.asycudadocumentitem.Currency_rate) return;
				this.asycudadocumentitem.Currency_rate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Currency_rate");
			}
		}
     

       
       
                
                
public string Currency_code
		{ 
		    get { return this.asycudadocumentitem.Currency_code; }
			set
			{
			    if (value == this.asycudadocumentitem.Currency_code) return;
				this.asycudadocumentitem.Currency_code = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Currency_code");
			}
		}
     

       
       
public Nullable<bool> InvalidHSCode
		{ 
		    get { return this.asycudadocumentitem.InvalidHSCode; }
			set
			{
			    if (value == this.asycudadocumentitem.InvalidHSCode) return;
				this.asycudadocumentitem.InvalidHSCode = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("InvalidHSCode");
			}
		}
     

       
       
                
                [MaxLength(50, ErrorMessage = "WarehouseError has a max length of 50 letters ")]
public string WarehouseError
		{ 
		    get { return this.asycudadocumentitem.WarehouseError; }
			set
			{
			    if (value == this.asycudadocumentitem.WarehouseError) return;
				this.asycudadocumentitem.WarehouseError = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("WarehouseError");
			}
		}
     

       
       
public Nullable<bool> Cancelled
		{ 
		    get { return this.asycudadocumentitem.Cancelled; }
			set
			{
			    if (value == this.asycudadocumentitem.Cancelled) return;
				this.asycudadocumentitem.Cancelled = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Cancelled");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> SalesFactor
		{ 
		    get { return this.asycudadocumentitem.SalesFactor; }
			set
			{
			    if (value == this.asycudadocumentitem.SalesFactor) return;
				this.asycudadocumentitem.SalesFactor = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("SalesFactor");
			}
		}
     

       private AsycudaDocument _AsycudaDocument;
        public  AsycudaDocument AsycudaDocument
		{
		    get
               { 
                  if (this.asycudadocumentitem != null)
                   {
                       if (_AsycudaDocument != null)
                       {
                           if (this.asycudadocumentitem.AsycudaDocument !=
                               _AsycudaDocument.DTO)
                           {
                                if (this.asycudadocumentitem.AsycudaDocument  != null)
                               _AsycudaDocument = new AsycudaDocument(this.asycudadocumentitem.AsycudaDocument);
                           }
                       }
                       else
                       {
                             if (this.asycudadocumentitem.AsycudaDocument  != null)
                           _AsycudaDocument = new AsycudaDocument(this.asycudadocumentitem.AsycudaDocument);
                       }
                   }


             //       if (_AsycudaDocument != null) return _AsycudaDocument;
                       
             //       var i = new AsycudaDocument(){TrackingState = TrackingState.Added};
			//		//if (this.asycudadocumentitem.AsycudaDocument == null) Debugger.Break();
			//		if (this.asycudadocumentitem.AsycudaDocument != null)
            //        {
            //           i. = this.asycudadocumentitem.AsycudaDocument;
            //        }
            //        else
            //        {
            //            this.asycudadocumentitem.AsycudaDocument = i.;
             //       }
                           
            //        _AsycudaDocument = i;
                     
                    return _AsycudaDocument;
               }
			set
			{
			    if (value == _AsycudaDocument) return;
                _AsycudaDocument = value;
                if(value != null)
                     this.asycudadocumentitem.AsycudaDocument = value.DTO;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                NotifyPropertyChanged("AsycudaDocument");
			}
		}
        

        ObservableCollection<OverShortAllocationsEX> _OverShortAllocationsEXes = null;
        public  ObservableCollection<OverShortAllocationsEX> OverShortAllocationsEXes
		{
            
		    get 
				{ 
					if(_OverShortAllocationsEXes != null) return _OverShortAllocationsEXes;
					//if (this.asycudadocumentitem.OverShortAllocationsEXes == null) Debugger.Break();
					if(this.asycudadocumentitem.OverShortAllocationsEXes != null)
					{
						_OverShortAllocationsEXes = new ObservableCollection<OverShortAllocationsEX>(this.asycudadocumentitem.OverShortAllocationsEXes.Select(x => new OverShortAllocationsEX(x)));
					}
					
						_OverShortAllocationsEXes.CollectionChanged += OverShortAllocationsEXes_CollectionChanged; 
					
					return _OverShortAllocationsEXes; 
				}
			set
			{
			    if (Equals(value, _OverShortAllocationsEXes)) return;
				if (value != null)
					this.asycudadocumentitem.OverShortAllocationsEXes = new ChangeTrackingCollection<DTO.OverShortAllocationsEX>(value.Select(x => x.DTO).ToList());
                _OverShortAllocationsEXes = value;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				if (_OverShortAllocationsEXes != null)
				_OverShortAllocationsEXes.CollectionChanged += OverShortAllocationsEXes_CollectionChanged;               
				NotifyPropertyChanged("OverShortAllocationsEXes");
			}
		}
        
        void OverShortAllocationsEXes_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (OverShortAllocationsEX itm in e.NewItems)
                    {
                        if (itm != null)
                        asycudadocumentitem.OverShortAllocationsEXes.Add(itm.DTO);
                    }
                    if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (OverShortAllocationsEX itm in e.OldItems)
                    {
                        if (itm != null)
                        asycudadocumentitem.OverShortAllocationsEXes.Remove(itm.DTO);
                    }
					if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                
            }
        }


        ChangeTrackingCollection<DTO.AsycudaDocumentItem> _changeTracker;    
        public ChangeTrackingCollection<DTO.AsycudaDocumentItem> ChangeTracker
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


