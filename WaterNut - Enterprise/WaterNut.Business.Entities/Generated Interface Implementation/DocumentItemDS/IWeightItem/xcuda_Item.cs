﻿// <autogenerated>
//   This file was generated by T4 code generator AllDomainInterface.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WaterNut.Interfaces;



namespace DocumentItemDS.Business.Entities
{
		public partial class xcuda_Item: IWeightItem //DocumentItemDS
		{  // please don't expect properties here, they are implict, only multilayer will appear here
                 [IgnoreDataMember]
                 [NotMapped]
                 public Double Gross_weight 
                {
                    get{ return this.xcuda_Valuation_item.xcuda_Weight_itm.Gross_weight_itm; }                
                    set { this.xcuda_Valuation_item.xcuda_Weight_itm.Gross_weight_itm = value;}
                }
                                 [IgnoreDataMember]
                 [NotMapped]
                 public Double Net_weight 
                {
                    get{ return this.xcuda_Valuation_item.xcuda_Weight_itm.Net_weight_itm; }                
                    set { this.xcuda_Valuation_item.xcuda_Weight_itm.Net_weight_itm = value;}
                }
                          
        }
}

