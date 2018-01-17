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
    public partial class xcuda_Supplementary_unit : BaseEntity<xcuda_Supplementary_unit>, ITrackable 
    {
        [DataMember]
        public Nullable<double> Suppplementary_unit_quantity 
        {
            get
            {
                return _suppplementary_unit_quantity;
            }
            set
            {
                _suppplementary_unit_quantity = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<double> _suppplementary_unit_quantity;
        [DataMember]
        public int Supplementary_unit_Id 
        {
            get
            {
                return _supplementary_unit_id;
            }
            set
            {
                _supplementary_unit_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _supplementary_unit_id;
        [DataMember]
        public int Tarification_Id 
        {
            get
            {
                return _tarification_id;
            }
            set
            {
                _tarification_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _tarification_id;
        [DataMember]
        public string Suppplementary_unit_code 
        {
            get
            {
                return _suppplementary_unit_code;
            }
            set
            {
                _suppplementary_unit_code = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _suppplementary_unit_code;
        [DataMember]
        public string Suppplementary_unit_name 
        {
            get
            {
                return _suppplementary_unit_name;
            }
            set
            {
                _suppplementary_unit_name = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _suppplementary_unit_name;
        [DataMember]
        public Nullable<bool> IsFirstRow 
        {
            get
            {
                return _isfirstrow;
            }
            set
            {
                _isfirstrow = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<bool> _isfirstrow;
        [DataMember]
        public xcuda_Tarification xcuda_Tarification { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


