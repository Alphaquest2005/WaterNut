﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
//using Newtonsoft.Json;


using Core.Common.Client.DTO;
using TrackableEntities;
using TrackableEntities.Client;

namespace CoreEntities.Client.DTO
{

   // [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class AsycudaDocumentItem : BaseEntity<AsycudaDocumentItem>, ITrackable, IEquatable<AsycudaDocumentItem>
    {
        [DataMember]
        public int Item_Id
		{ 
		    get { return _Item_Id; }
			set
			{
			    if (value == _Item_Id) return;
				_Item_Id = value;
				NotifyPropertyChanged();//m => this.Item_Id
			}
		}
        private int _Item_Id;

        [DataMember]
        public Nullable<int> AsycudaDocumentId
		{ 
		    get { return _AsycudaDocumentId; }
			set
			{
			    if (value == _AsycudaDocumentId) return;
				_AsycudaDocumentId = value;
				NotifyPropertyChanged();//m => this.AsycudaDocumentId
			}
		}
        private Nullable<int> _AsycudaDocumentId;

        [DataMember]
        public Nullable<int> EntryDataDetailsId
		{ 
		    get { return _EntryDataDetailsId; }
			set
			{
			    if (value == _EntryDataDetailsId) return;
				_EntryDataDetailsId = value;
				NotifyPropertyChanged();//m => this.EntryDataDetailsId
			}
		}
        private Nullable<int> _EntryDataDetailsId;

        [DataMember]
        public Nullable<int> LineNumber
		{ 
		    get { return _LineNumber; }
			set
			{
			    if (value == _LineNumber) return;
				_LineNumber = value;
				NotifyPropertyChanged();//m => this.LineNumber
			}
		}
        private Nullable<int> _LineNumber;

        [DataMember]
        public Nullable<bool> IsAssessed
		{ 
		    get { return _IsAssessed; }
			set
			{
			    if (value == _IsAssessed) return;
				_IsAssessed = value;
				NotifyPropertyChanged();//m => this.IsAssessed
			}
		}
        private Nullable<bool> _IsAssessed;

        [DataMember]
        public Nullable<bool> DoNotAllocate
		{ 
		    get { return _DoNotAllocate; }
			set
			{
			    if (value == _DoNotAllocate) return;
				_DoNotAllocate = value;
				NotifyPropertyChanged();//m => this.DoNotAllocate
			}
		}
        private Nullable<bool> _DoNotAllocate;

        [DataMember]
        public Nullable<bool> DoNotEX
		{ 
		    get { return _DoNotEX; }
			set
			{
			    if (value == _DoNotEX) return;
				_DoNotEX = value;
				NotifyPropertyChanged();//m => this.DoNotEX
			}
		}
        private Nullable<bool> _DoNotEX;

        [DataMember]
        public Nullable<bool> AttributeOnlyAllocation
		{ 
		    get { return _AttributeOnlyAllocation; }
			set
			{
			    if (value == _AttributeOnlyAllocation) return;
				_AttributeOnlyAllocation = value;
				NotifyPropertyChanged();//m => this.AttributeOnlyAllocation
			}
		}
        private Nullable<bool> _AttributeOnlyAllocation;

        [DataMember]
        public string Description_of_goods
		{ 
		    get { return _Description_of_goods; }
			set
			{
			    if (value == _Description_of_goods) return;
				_Description_of_goods = value;
				NotifyPropertyChanged();//m => this.Description_of_goods
			}
		}
        private string _Description_of_goods;

        [DataMember]
        public string Commercial_Description
		{ 
		    get { return _Commercial_Description; }
			set
			{
			    if (value == _Commercial_Description) return;
				_Commercial_Description = value;
				NotifyPropertyChanged();//m => this.Commercial_Description
			}
		}
        private string _Commercial_Description;

        [DataMember]
        public double Gross_weight_itm
		{ 
		    get { return _Gross_weight_itm; }
			set
			{
			    if (value == _Gross_weight_itm) return;
				_Gross_weight_itm = value;
				NotifyPropertyChanged();//m => this.Gross_weight_itm
			}
		}
        private double _Gross_weight_itm;

        [DataMember]
        public double Net_weight_itm
		{ 
		    get { return _Net_weight_itm; }
			set
			{
			    if (value == _Net_weight_itm) return;
				_Net_weight_itm = value;
				NotifyPropertyChanged();//m => this.Net_weight_itm
			}
		}
        private double _Net_weight_itm;

        [DataMember]
        public Nullable<double> Item_price
		{ 
		    get { return _Item_price; }
			set
			{
			    if (value == _Item_price) return;
				_Item_price = value;
				NotifyPropertyChanged();//m => this.Item_price
			}
		}
        private Nullable<double> _Item_price;

        [DataMember]
        public Nullable<double> ItemQuantity
		{ 
		    get { return _ItemQuantity; }
			set
			{
			    if (value == _ItemQuantity) return;
				_ItemQuantity = value;
				NotifyPropertyChanged();//m => this.ItemQuantity
			}
		}
        private Nullable<double> _ItemQuantity;

        [DataMember]
        public string Suppplementary_unit_code
		{ 
		    get { return _Suppplementary_unit_code; }
			set
			{
			    if (value == _Suppplementary_unit_code) return;
				_Suppplementary_unit_code = value;
				NotifyPropertyChanged();//m => this.Suppplementary_unit_code
			}
		}
        private string _Suppplementary_unit_code;

        [DataMember]
        public string ItemNumber
		{ 
		    get { return _ItemNumber; }
			set
			{
			    if (value == _ItemNumber) return;
				_ItemNumber = value;
				NotifyPropertyChanged();//m => this.ItemNumber
			}
		}
        private string _ItemNumber;

        [DataMember]
        public string TariffCode
		{ 
		    get { return _TariffCode; }
			set
			{
			    if (value == _TariffCode) return;
				_TariffCode = value;
				NotifyPropertyChanged();//m => this.TariffCode
			}
		}
        private string _TariffCode;

        [DataMember]
        public Nullable<bool> TariffCodeLicenseRequired
		{ 
		    get { return _TariffCodeLicenseRequired; }
			set
			{
			    if (value == _TariffCodeLicenseRequired) return;
				_TariffCodeLicenseRequired = value;
				NotifyPropertyChanged();//m => this.TariffCodeLicenseRequired
			}
		}
        private Nullable<bool> _TariffCodeLicenseRequired;

        [DataMember]
        public Nullable<bool> TariffCategoryLicenseRequired
		{ 
		    get { return _TariffCategoryLicenseRequired; }
			set
			{
			    if (value == _TariffCategoryLicenseRequired) return;
				_TariffCategoryLicenseRequired = value;
				NotifyPropertyChanged();//m => this.TariffCategoryLicenseRequired
			}
		}
        private Nullable<bool> _TariffCategoryLicenseRequired;

        [DataMember]
        public string TariffCodeDescription
		{ 
		    get { return _TariffCodeDescription; }
			set
			{
			    if (value == _TariffCodeDescription) return;
				_TariffCodeDescription = value;
				NotifyPropertyChanged();//m => this.TariffCodeDescription
			}
		}
        private string _TariffCodeDescription;

        [DataMember]
        public Nullable<double> DutyLiability
		{ 
		    get { return _DutyLiability; }
			set
			{
			    if (value == _DutyLiability) return;
				_DutyLiability = value;
				NotifyPropertyChanged();//m => this.DutyLiability
			}
		}
        private Nullable<double> _DutyLiability;

        [DataMember]
        public Nullable<double> Total_CIF_itm
		{ 
		    get { return _Total_CIF_itm; }
			set
			{
			    if (value == _Total_CIF_itm) return;
				_Total_CIF_itm = value;
				NotifyPropertyChanged();//m => this.Total_CIF_itm
			}
		}
        private Nullable<double> _Total_CIF_itm;

        [DataMember]
        public Nullable<double> Freight
		{ 
		    get { return _Freight; }
			set
			{
			    if (value == _Freight) return;
				_Freight = value;
				NotifyPropertyChanged();//m => this.Freight
			}
		}
        private Nullable<double> _Freight;

        [DataMember]
        public Nullable<double> Statistical_value
		{ 
		    get { return _Statistical_value; }
			set
			{
			    if (value == _Statistical_value) return;
				_Statistical_value = value;
				NotifyPropertyChanged();//m => this.Statistical_value
			}
		}
        private Nullable<double> _Statistical_value;

        [DataMember]
        public Nullable<double> DPQtyAllocated
		{ 
		    get { return _DPQtyAllocated; }
			set
			{
			    if (value == _DPQtyAllocated) return;
				_DPQtyAllocated = value;
				NotifyPropertyChanged();//m => this.DPQtyAllocated
			}
		}
        private Nullable<double> _DPQtyAllocated;

        [DataMember]
        public Nullable<double> DFQtyAllocated
		{ 
		    get { return _DFQtyAllocated; }
			set
			{
			    if (value == _DFQtyAllocated) return;
				_DFQtyAllocated = value;
				NotifyPropertyChanged();//m => this.DFQtyAllocated
			}
		}
        private Nullable<double> _DFQtyAllocated;

        [DataMember]
        public Nullable<double> PiQuantity
		{ 
		    get { return _PiQuantity; }
			set
			{
			    if (value == _PiQuantity) return;
				_PiQuantity = value;
				NotifyPropertyChanged();//m => this.PiQuantity
			}
		}
        private Nullable<double> _PiQuantity;

        [DataMember]
        public Nullable<bool> ImportComplete
		{ 
		    get { return _ImportComplete; }
			set
			{
			    if (value == _ImportComplete) return;
				_ImportComplete = value;
				NotifyPropertyChanged();//m => this.ImportComplete
			}
		}
        private Nullable<bool> _ImportComplete;

        [DataMember]
        public string CNumber
		{ 
		    get { return _CNumber; }
			set
			{
			    if (value == _CNumber) return;
				_CNumber = value;
				NotifyPropertyChanged();//m => this.CNumber
			}
		}
        private string _CNumber;

        [DataMember]
        public Nullable<System.DateTime> RegistrationDate
		{ 
		    get { return _RegistrationDate; }
			set
			{
			    if (value == _RegistrationDate) return;
				_RegistrationDate = value;
				NotifyPropertyChanged();//m => this.RegistrationDate
			}
		}
        private Nullable<System.DateTime> _RegistrationDate;

        [DataMember]
        public Nullable<double> Number_of_packages
		{ 
		    get { return _Number_of_packages; }
			set
			{
			    if (value == _Number_of_packages) return;
				_Number_of_packages = value;
				NotifyPropertyChanged();//m => this.Number_of_packages
			}
		}
        private Nullable<double> _Number_of_packages;

        [DataMember]
        public string Country_of_origin_code
		{ 
		    get { return _Country_of_origin_code; }
			set
			{
			    if (value == _Country_of_origin_code) return;
				_Country_of_origin_code = value;
				NotifyPropertyChanged();//m => this.Country_of_origin_code
			}
		}
        private string _Country_of_origin_code;

        [DataMember]
        public Nullable<double> PiWeight
		{ 
		    get { return _PiWeight; }
			set
			{
			    if (value == _PiWeight) return;
				_PiWeight = value;
				NotifyPropertyChanged();//m => this.PiWeight
			}
		}
        private Nullable<double> _PiWeight;

        [DataMember]
        public Nullable<double> Currency_rate
		{ 
		    get { return _Currency_rate; }
			set
			{
			    if (value == _Currency_rate) return;
				_Currency_rate = value;
				NotifyPropertyChanged();//m => this.Currency_rate
			}
		}
        private Nullable<double> _Currency_rate;

        [DataMember]
        public string Currency_code
		{ 
		    get { return _Currency_code; }
			set
			{
			    if (value == _Currency_code) return;
				_Currency_code = value;
				NotifyPropertyChanged();//m => this.Currency_code
			}
		}
        private string _Currency_code;

        [DataMember]
        public Nullable<bool> InvalidHSCode
		{ 
		    get { return _InvalidHSCode; }
			set
			{
			    if (value == _InvalidHSCode) return;
				_InvalidHSCode = value;
				NotifyPropertyChanged();//m => this.InvalidHSCode
			}
		}
        private Nullable<bool> _InvalidHSCode;

        [DataMember]
        public string WarehouseError
		{ 
		    get { return _WarehouseError; }
			set
			{
			    if (value == _WarehouseError) return;
				_WarehouseError = value;
				NotifyPropertyChanged();//m => this.WarehouseError
			}
		}
        private string _WarehouseError;

        [DataMember]
        public Nullable<bool> Cancelled
		{ 
		    get { return _Cancelled; }
			set
			{
			    if (value == _Cancelled) return;
				_Cancelled = value;
				NotifyPropertyChanged();//m => this.Cancelled
			}
		}
        private Nullable<bool> _Cancelled;

        [DataMember]
        public Nullable<double> SalesFactor
		{ 
		    get { return _SalesFactor; }
			set
			{
			    if (value == _SalesFactor) return;
				_SalesFactor = value;
				NotifyPropertyChanged();//m => this.SalesFactor
			}
		}
        private Nullable<double> _SalesFactor;

       
        [DataMember]
        public AsycudaDocument AsycudaDocument
		{
		    get { return _AsycudaDocument; }
			set
			{
			    if (value == _AsycudaDocument) return;
				_AsycudaDocument = value;
                AsycudaDocumentChangeTracker = _AsycudaDocument == null ? null
                    : new ChangeTrackingCollection<AsycudaDocument> { _AsycudaDocument };
				NotifyPropertyChanged();//m => this.AsycudaDocument
			}
		}
        private AsycudaDocument _AsycudaDocument;
        private ChangeTrackingCollection<AsycudaDocument> AsycudaDocumentChangeTracker { get; set; }

        [DataMember]
        public ChangeTrackingCollection<SubItems> SubItems
		{
		    get { return _SubItems; }
			set
			{
			    if (Equals(value, _SubItems)) return;
				_SubItems = value;
				NotifyPropertyChanged();//m => this.SubItems
			}
		}
        private ChangeTrackingCollection<SubItems> _SubItems = new ChangeTrackingCollection<SubItems>();

        [DataMember]
        public ChangeTrackingCollection<EntryPreviousItems> PreviousItems
		{
		    get { return _PreviousItems; }
			set
			{
			    if (Equals(value, _PreviousItems)) return;
				_PreviousItems = value;
				NotifyPropertyChanged();//m => this.PreviousItems
			}
		}
        private ChangeTrackingCollection<EntryPreviousItems> _PreviousItems = new ChangeTrackingCollection<EntryPreviousItems>();

        [DataMember]
        public ChangeTrackingCollection<xcuda_Supplementary_unit> xcuda_Supplementary_unit
		{
		    get { return _xcuda_Supplementary_unit; }
			set
			{
			    if (Equals(value, _xcuda_Supplementary_unit)) return;
				_xcuda_Supplementary_unit = value;
				NotifyPropertyChanged();//m => this.xcuda_Supplementary_unit
			}
		}
        private ChangeTrackingCollection<xcuda_Supplementary_unit> _xcuda_Supplementary_unit = new ChangeTrackingCollection<xcuda_Supplementary_unit>();

   //     [DataMember]
   //     public TrackingState TrackingState { get; set; }

   //     [DataMember]
   //     public ICollection<string> ModifiedProperties { get; set; }
        
    //  [DataMember]//JsonProperty, 
    //	private Guid EntityIdentifier { get; set; }
    
    //	[DataMember]//JsonProperty, 
    //	private Guid _entityIdentity = default(Guid);
    
    	bool IEquatable<AsycudaDocumentItem>.Equals(AsycudaDocumentItem other)
    	{
    		if (EntityIdentifier != default(Guid))
    			return EntityIdentifier == other.EntityIdentifier;
    		return false;
    	}
    }
}



