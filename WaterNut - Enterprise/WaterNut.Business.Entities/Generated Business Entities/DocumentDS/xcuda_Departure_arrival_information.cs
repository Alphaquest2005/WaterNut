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


namespace DocumentDS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class xcuda_Departure_arrival_information : BaseEntity<xcuda_Departure_arrival_information> , ITrackable
    {
        [DataMember]
        public int Departure_arrival_information_Id 
        {
            get
            {
                return _departure_arrival_information_id;
            }
            set
            {
                _departure_arrival_information_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _departure_arrival_information_id;
        [DataMember]
        public Nullable<int> Means_of_transport_Id 
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
        Nullable<int> _means_of_transport_id;
        [DataMember]
        public string Identity 
        {
            get
            {
                return _identity;
            }
            set
            {
                _identity = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _identity;
        [DataMember]
        public string Nationality 
        {
            get
            {
                return _nationality;
            }
            set
            {
                _nationality = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _nationality;
        [DataMember]
        public xcuda_Means_of_transport xcuda_Means_of_transport { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


