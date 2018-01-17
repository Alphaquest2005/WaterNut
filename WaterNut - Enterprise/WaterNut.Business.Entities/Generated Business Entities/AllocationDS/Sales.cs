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
    public partial class Sales : EntryData 
    {
        partial void AutoGenStartUp() //Sales()
        {
            this.EntryDataDetails = new List<EntryDataDetails>();
        }

        [DataMember]
        public string INVNumber 
        {
            get
            {
                return _invnumber;
            }
            set
            {
                _invnumber = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _invnumber;
        [DataMember]
        public Nullable<double> TaxAmount 
        {
            get
            {
                return _taxamount;
            }
            set
            {
                _taxamount = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<double> _taxamount;
        [DataMember]
        public string CustomerName 
        {
            get
            {
                return _customername;
            }
            set
            {
                _customername = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _customername;
        [DataMember]
        public List<EntryDataDetails> EntryDataDetails { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


