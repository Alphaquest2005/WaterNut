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


namespace DocumentItemDS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class xcuda_Weight_itm : BaseEntity<xcuda_Weight_itm> , ITrackable
    {
        [DataMember]
        public double Gross_weight_itm 
        {
            get
            {
                return _gross_weight_itm;
            }
            set
            {
                _gross_weight_itm = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _gross_weight_itm;
        [DataMember]
        public double Net_weight_itm 
        {
            get
            {
                return _net_weight_itm;
            }
            set
            {
                _net_weight_itm = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _net_weight_itm;
        [DataMember]
        public int Valuation_item_Id 
        {
            get
            {
                return _valuation_item_id;
            }
            set
            {
                _valuation_item_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _valuation_item_id;
        [DataMember]
        public xcuda_Valuation_item xcuda_Valuation_item { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}

