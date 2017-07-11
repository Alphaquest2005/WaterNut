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


namespace EntryDataDS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class ContainerType : BaseEntity<ContainerType> , ITrackable
    {
        partial void AutoGenStartUp() //ContainerType()
        {
            this.Container = new List<Container>();
        }

        [DataMember]
        public string ContainerTypeDescription 
        {
            get
            {
                return _containertypedescription;
            }
            set
            {
                _containertypedescription = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _containertypedescription;
        [DataMember]
        public string ContainerCode 
        {
            get
            {
                return _containercode;
            }
            set
            {
                _containercode = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _containercode;
        [DataMember]
        public List<Container> Container { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


