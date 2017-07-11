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
    public partial class xcuda_Taxation : BaseEntity<xcuda_Taxation> , ITrackable
    {
        partial void AutoGenStartUp() //xcuda_Taxation()
        {
            this.xcuda_Taxation_line = new List<xcuda_Taxation_line>();
        }

        [DataMember]
        public double Item_taxes_amount 
        {
            get
            {
                return _item_taxes_amount;
            }
            set
            {
                _item_taxes_amount = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _item_taxes_amount;
        [DataMember]
        public Nullable<double> Item_taxes_guaranted_amount 
        {
            get
            {
                return _item_taxes_guaranted_amount;
            }
            set
            {
                _item_taxes_guaranted_amount = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<double> _item_taxes_guaranted_amount;
        [DataMember]
        public string Counter_of_normal_mode_of_payment 
        {
            get
            {
                return _counter_of_normal_mode_of_payment;
            }
            set
            {
                _counter_of_normal_mode_of_payment = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _counter_of_normal_mode_of_payment;
        [DataMember]
        public string Displayed_item_taxes_amount 
        {
            get
            {
                return _displayed_item_taxes_amount;
            }
            set
            {
                _displayed_item_taxes_amount = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _displayed_item_taxes_amount;
        [DataMember]
        public int Taxation_Id 
        {
            get
            {
                return _taxation_id;
            }
            set
            {
                _taxation_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _taxation_id;
        [DataMember]
        public Nullable<int> Item_Id 
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
        Nullable<int> _item_id;
        [DataMember]
        public string Item_taxes_mode_of_payment 
        {
            get
            {
                return _item_taxes_mode_of_payment;
            }
            set
            {
                _item_taxes_mode_of_payment = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _item_taxes_mode_of_payment;
        [DataMember]
        public xcuda_Item xcuda_Item { get; set; }
        [DataMember]
        public List<xcuda_Taxation_line> xcuda_Taxation_line { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


