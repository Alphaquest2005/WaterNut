﻿// <autogenerated>
//   This file was generated by T4 code generator Business.Entities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
//using Newtonsoft.Json;
using TrackableEntities;
using Core.Common.Business.Entities;


namespace AllocationDS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class EntryDataDetails : BaseEntity<EntryDataDetails> , ITrackable
    {
        partial void AutoGenStartUp() //EntryDataDetails()
        {
            this.AsycudaSalesAllocations = new List<AsycudaSalesAllocations>();
        }

        [DataMember]
        public int EntryDataDetailsId 
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
        int _entrydatadetailsid;
        [DataMember]
        public string EntryDataId 
        {
            get
            {
                return _entrydataid;
            }
            set
            {
                _entrydataid = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _entrydataid;
        [DataMember]
        public Nullable<int> LineNumber 
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
        Nullable<int> _linenumber;
        [DataMember]
        public string ItemNumber 
        {
            get
            {
                return _itemnumber;
            }
            set
            {
                _itemnumber = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _itemnumber;
        [DataMember]
        public double Quantity 
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _quantity;
        [DataMember]
        public string Units 
        {
            get
            {
                return _units;
            }
            set
            {
                _units = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _units;
        [DataMember]
        public string ItemDescription 
        {
            get
            {
                return _itemdescription;
            }
            set
            {
                _itemdescription = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _itemdescription;
        [DataMember]
        public double Cost 
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _cost;
        [DataMember]
        public double QtyAllocated 
        {
            get
            {
                return _qtyallocated;
            }
            set
            {
                _qtyallocated = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _qtyallocated;
        [DataMember]
        public double UnitWeight 
        {
            get
            {
                return _unitweight;
            }
            set
            {
                _unitweight = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _unitweight;
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
        public Nullable<double> Freight 
        {
            get
            {
                return _freight;
            }
            set
            {
                _freight = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<double> _freight;
        [DataMember]
        public Nullable<double> Weight 
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<double> _weight;
        [DataMember]
        public Nullable<double> InternalFreight 
        {
            get
            {
                return _internalfreight;
            }
            set
            {
                _internalfreight = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<double> _internalfreight;
        [DataMember]
        public List<AsycudaSalesAllocations> AsycudaSalesAllocations { get; set; }
        [DataMember]
        public EntryDataDetailsEx EntryDataDetailsEx { get; set; }
        [DataMember]
        public Sales Sales { get; set; }
        [DataMember]
        public InventoryItems InventoryItem { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


