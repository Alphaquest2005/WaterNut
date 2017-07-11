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
    public partial class xcuda_Property : BaseEntity<xcuda_Property> , ITrackable
    {
        [DataMember]
        public string Sad_flow 
        {
            get
            {
                return _sad_flow;
            }
            set
            {
                _sad_flow = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _sad_flow;
        [DataMember]
        public string Date_of_declaration 
        {
            get
            {
                return _date_of_declaration;
            }
            set
            {
                _date_of_declaration = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _date_of_declaration;
        [DataMember]
        public string Selected_page 
        {
            get
            {
                return _selected_page;
            }
            set
            {
                _selected_page = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _selected_page;
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
        public string Place_of_declaration 
        {
            get
            {
                return _place_of_declaration;
            }
            set
            {
                _place_of_declaration = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _place_of_declaration;
        [DataMember]
        public xcuda_ASYCUDA xcuda_ASYCUDA { get; set; }
        [DataMember]
        public xcuda_Forms xcuda_Forms { get; set; }
        [DataMember]
        public xcuda_Nbers xcuda_Nbers { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}

