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
    public partial class PreviousItemsEx : BaseEntity<PreviousItemsEx> , ITrackable
    {
        [DataMember]
        public string Packages_number 
        {
            get
            {
                return _packages_number;
            }
            set
            {
                _packages_number = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _packages_number;
        [DataMember]
        public string Previous_Packages_number 
        {
            get
            {
                return _previous_packages_number;
            }
            set
            {
                _previous_packages_number = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _previous_packages_number;
        [DataMember]
        public string Hs_code 
        {
            get
            {
                return _hs_code;
            }
            set
            {
                _hs_code = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _hs_code;
        [DataMember]
        public string Commodity_code 
        {
            get
            {
                return _commodity_code;
            }
            set
            {
                _commodity_code = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _commodity_code;
        [DataMember]
        public string Previous_item_number 
        {
            get
            {
                return _previous_item_number;
            }
            set
            {
                _previous_item_number = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _previous_item_number;
        [DataMember]
        public string Goods_origin 
        {
            get
            {
                return _goods_origin;
            }
            set
            {
                _goods_origin = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _goods_origin;
        [DataMember]
        public double Net_weight 
        {
            get
            {
                return _net_weight;
            }
            set
            {
                _net_weight = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _net_weight;
        [DataMember]
        public double Prev_net_weight 
        {
            get
            {
                return _prev_net_weight;
            }
            set
            {
                _prev_net_weight = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _prev_net_weight;
        [DataMember]
        public string Prev_reg_ser 
        {
            get
            {
                return _prev_reg_ser;
            }
            set
            {
                _prev_reg_ser = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _prev_reg_ser;
        [DataMember]
        public string Prev_reg_nbr 
        {
            get
            {
                return _prev_reg_nbr;
            }
            set
            {
                _prev_reg_nbr = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _prev_reg_nbr;
        [DataMember]
        public string Prev_reg_dat 
        {
            get
            {
                return _prev_reg_dat;
            }
            set
            {
                _prev_reg_dat = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _prev_reg_dat;
        [DataMember]
        public string Prev_reg_cuo 
        {
            get
            {
                return _prev_reg_cuo;
            }
            set
            {
                _prev_reg_cuo = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _prev_reg_cuo;
        [DataMember]
        public double Suplementary_Quantity 
        {
            get
            {
                return _suplementary_quantity;
            }
            set
            {
                _suplementary_quantity = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _suplementary_quantity;
        [DataMember]
        public double Preveious_suplementary_quantity 
        {
            get
            {
                return _preveious_suplementary_quantity;
            }
            set
            {
                _preveious_suplementary_quantity = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _preveious_suplementary_quantity;
        [DataMember]
        public double Current_value 
        {
            get
            {
                return _current_value;
            }
            set
            {
                _current_value = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _current_value;
        [DataMember]
        public double Previous_value 
        {
            get
            {
                return _previous_value;
            }
            set
            {
                _previous_value = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _previous_value;
        [DataMember]
        public string Current_item_number 
        {
            get
            {
                return _current_item_number;
            }
            set
            {
                _current_item_number = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _current_item_number;
        [DataMember]
        public int PreviousItem_Id 
        {
            get
            {
                return _previousitem_id;
            }
            set
            {
                _previousitem_id = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        int _previousitem_id;
        [DataMember]
        public Nullable<int> ASYCUDA_Id 
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
        Nullable<int> _asycuda_id;
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
        public double RndCurrent_Value 
        {
            get
            {
                return _rndcurrent_value;
            }
            set
            {
                _rndcurrent_value = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        double _rndcurrent_value;
        [DataMember]
        public string CNumber 
        {
            get
            {
                return _cnumber;
            }
            set
            {
                _cnumber = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _cnumber;
        [DataMember]
        public string RegistrationDate 
        {
            get
            {
                return _registrationdate;
            }
            set
            {
                _registrationdate = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _registrationdate;
        [DataMember]
        public xcuda_PreviousItem xcuda_PreviousItem { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


