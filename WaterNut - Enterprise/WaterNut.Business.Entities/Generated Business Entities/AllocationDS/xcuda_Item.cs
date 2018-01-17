﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
//using Newtonsoft.Json;

using Core.Common.Business.Entities;
using WaterNut.Interfaces;
using TrackableEntities;

namespace AllocationDS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class xcuda_Item : BaseEntity<xcuda_Item>, ITrackable 
    {
        partial void AutoGenStartUp() //xcuda_Item()
        {
            this.AsycudaSalesAllocations = new List<AsycudaSalesAllocations>();
            this.SubItems = new List<SubItems>();
            this.xcuda_Taxation = new List<xcuda_Taxation>();
            this.xBondAllocations = new List<xBondAllocations>();
            this.EX9AsycudaSalesAllocations = new List<EX9AsycudaSalesAllocations>();
            this.EntryPreviousItems = new List<EntryPreviousItems>();
        }

        [DataMember]
        public string Amount_deducted_from_licence 
        {
            get
            {
                return _amount_deducted_from_licence;
            }
            set
            {
                _amount_deducted_from_licence = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _amount_deducted_from_licence;
        [DataMember]
        public string Quantity_deducted_from_licence 
        {
            get
            {
                return _quantity_deducted_from_licence;
            }
            set
            {
                _quantity_deducted_from_licence = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _quantity_deducted_from_licence;
        [DataMember]
        public int Item_Id 
        {
            get
            {
                return _item_id;
            }
            set
            {
                _item_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _item_id;
        [DataMember]
        public int ASYCUDA_Id 
        {
            get
            {
                return _asycuda_id;
            }
            set
            {
                _asycuda_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _asycuda_id;
        [DataMember]
        public string Licence_number 
        {
            get
            {
                return _licence_number;
            }
            set
            {
                _licence_number = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _licence_number;
        [DataMember]
        public Nullable<int> EntryDataDetailsId 
        {
            get
            {
                return _entrydatadetailsid;
            }
            set
            {
                _entrydatadetailsid = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<int> _entrydatadetailsid;
        [DataMember]
        public int LineNumber 
        {
            get
            {
                return _linenumber;
            }
            set
            {
                _linenumber = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _linenumber;
        [DataMember]
        public Nullable<bool> IsAssessed 
        {
            get
            {
                return _isassessed;
            }
            set
            {
                _isassessed = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _isassessed;
        [DataMember]
        public double DPQtyAllocated 
        {
            get
            {
                return _dpqtyallocated;
            }
            set
            {
                _dpqtyallocated = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _dpqtyallocated;
        [DataMember]
        public double DFQtyAllocated 
        {
            get
            {
                return _dfqtyallocated;
            }
            set
            {
                _dfqtyallocated = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _dfqtyallocated;
        [DataMember]
        public Nullable<System.DateTime> EntryTimeStamp 
        {
            get
            {
                return _entrytimestamp;
            }
            set
            {
                _entrytimestamp = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<System.DateTime> _entrytimestamp;
        [DataMember]
        public Nullable<bool> AttributeOnlyAllocation 
        {
            get
            {
                return _attributeonlyallocation;
            }
            set
            {
                _attributeonlyallocation = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _attributeonlyallocation;
        [DataMember]
        public Nullable<bool> DoNotAllocate 
        {
            get
            {
                return _donotallocate;
            }
            set
            {
                _donotallocate = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _donotallocate;
        [DataMember]
        public Nullable<bool> DoNotEX 
        {
            get
            {
                return _donotex;
            }
            set
            {
                _donotex = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _donotex;
        [DataMember]
        public string Free_text_1 
        {
            get
            {
                return _free_text_1;
            }
            set
            {
                _free_text_1 = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _free_text_1;
        [DataMember]
        public string Free_text_2 
        {
            get
            {
                return _free_text_2;
            }
            set
            {
                _free_text_2 = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _free_text_2;
        [DataMember]
        public bool ImportComplete 
        {
            get
            {
                return _importcomplete;
            }
            set
            {
                _importcomplete = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        bool _importcomplete;
        [DataMember]
        public string WarehouseError 
        {
            get
            {
                return _warehouseerror;
            }
            set
            {
                _warehouseerror = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _warehouseerror;
        [DataMember]
        public double SalesFactor 
        {
            get
            {
                return _salesfactor;
            }
            set
            {
                _salesfactor = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _salesfactor;
        [DataMember]
        public List<AsycudaSalesAllocations> AsycudaSalesAllocations { get; set; }
        [DataMember]
        public xcuda_PreviousItem xcuda_PreviousItem { get; set; }
        [DataMember]
        public AsycudaDocument AsycudaDocument { get; set; }
        [DataMember]
        public List<SubItems> SubItems { get; set; }
        [DataMember]
        public xcuda_Goods_description xcuda_Goods_description { get; set; }
        [DataMember]
        public xcuda_Tarification xcuda_Tarification { get; set; }
        [DataMember]
        public List<xcuda_Taxation> xcuda_Taxation { get; set; }
        [DataMember]
        public xcuda_Valuation_item xcuda_Valuation_item { get; set; }
        [DataMember]
        public List<xBondAllocations> xBondAllocations { get; set; }
        [DataMember]
        public List<EX9AsycudaSalesAllocations> EX9AsycudaSalesAllocations { get; set; }
        [DataMember]
        public List<EntryPreviousItems> EntryPreviousItems { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


