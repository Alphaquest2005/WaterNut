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

namespace DocumentDS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class xcuda_Means_of_transport : BaseEntity<xcuda_Means_of_transport>, ITrackable 
    {
        partial void AutoGenStartUp() //xcuda_Means_of_transport()
        {
            this.xcuda_Border_information = new List<xcuda_Border_information>();
            this.xcuda_Departure_arrival_information = new List<xcuda_Departure_arrival_information>();
        }

        [DataMember]
        public int Means_of_transport_Id 
        {
            get
            {
                return _means_of_transport_id;
            }
            set
            {
                _means_of_transport_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _means_of_transport_id;
        [DataMember]
        public Nullable<int> Transport_Id 
        {
            get
            {
                return _transport_id;
            }
            set
            {
                _transport_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<int> _transport_id;
        [DataMember]
        public string Inland_mode_of_transport 
        {
            get
            {
                return _inland_mode_of_transport;
            }
            set
            {
                _inland_mode_of_transport = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _inland_mode_of_transport;
        [DataMember]
        public List<xcuda_Border_information> xcuda_Border_information { get; set; }
        [DataMember]
        public List<xcuda_Departure_arrival_information> xcuda_Departure_arrival_information { get; set; }
        [DataMember]
        public xcuda_Transport xcuda_Transport { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


