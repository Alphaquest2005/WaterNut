﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using CoreEntities.Business.Entities;
using Core.Common.Data.Contracts;
using System;

namespace OversShortQS.Business.Entities
{
    public partial class OverShortSuggestedDocument: IIdentifiableEntity
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.OversShortsId.ToString();  // this.OversShortsId == null?"0":
            }
            set
            {
                this.OversShortsId = Convert.ToInt32(value);
            }
        }



         #endregion
    }
   
}
		