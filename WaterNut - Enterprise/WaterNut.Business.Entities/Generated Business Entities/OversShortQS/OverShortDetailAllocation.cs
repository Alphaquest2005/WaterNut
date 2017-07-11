﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
//using Newtonsoft.Json;
using TrackableEntities;
using Core.Common.Business.Entities;


namespace OversShortQS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class OverShortDetailAllocation : BaseEntity<OverShortDetailAllocation> , ITrackable
    {
        [DataMember]
        public int OverShortDetailId 
        {
            get
            {
                return _overshortdetailid;
            }
            set
            {
                _overshortdetailid = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _overshortdetailid;
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
        public string Status 
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _status;
        [DataMember]
        public int OverShortAllocationId 
        {
            get
            {
                return _overshortallocationid;
            }
            set
            {
                _overshortallocationid = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _overshortallocationid;
        [DataMember]
        public OverShortAllocationsEX EX { get; set; }
        [DataMember]
        public OverShortDetail OverShortDetail { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}

