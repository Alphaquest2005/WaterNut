﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using OversShortQS.Client.Entities;
using OversShortQS.Client.Services;
//using WaterNut.Client.Services;
using OversShortQS.Client.Services;

using System;

namespace OversShortQS.Client.Entities
{
    public partial class OversShort
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.OversShortsId.ToString();//this.OversShortsId == null?"0":			
            }
            set
            {
                this.OversShortsId = Convert.ToInt32(value);
            }
        }



         #endregion
    }
   
}
		