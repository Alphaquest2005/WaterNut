﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Linq;
using CoreEntities.Business.Entities;
using Core.Common.Data.Contracts;
using System;

namespace EntryDataQS.Business.Entities
{
    public partial class ContainerEntryData: IIdentifiableEntity
    {
       
       #region IIdentifiable Entities
        public override string EntityId
        {
            get
            {
                return this.ContainerEntryData1.ToString();  // this.ContainerEntryData1 == null?"0":
            }
            set
            {
                this.ContainerEntryData1 = Convert.ToInt32(value);
            }
        }



         #endregion
    }
   
}
		