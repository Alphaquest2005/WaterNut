﻿// <autogenerated>
//   This file was generated by T4 code generator Business.Models.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using CoreEntities.Business.Entities;
using Core.Common.Data.Contracts;
using System;

namespace AllocationDS.Business.Entities
{
    public partial class SubItems: IIdentifiableEntity
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.SubItem_Id.ToString();  // this.SubItem_Id == null?"0":
            }
            set
            {
                this.SubItem_Id = Convert.ToInt32(value);
            }
        }



         #endregion
    }
   
}
		