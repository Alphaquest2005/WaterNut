﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
//using Newtonsoft.Json;
using TrackableEntities;
using WaterNut.Business.Entities;


namespace InventoryDS.Business.Entities
{
   // [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class TariffSupUnitLkpsDTO : BaseEntity<TariffSupUnitLkpsDTO> , ITrackable
    {
        [DataMember]
        public string TariffCategoryCode { get; set; }
        [DataMember]
        public string SuppUnitCode2 { get; set; }
        [DataMember]
        public string SuppUnitName2 { get; set; }
        [DataMember]
        public Nullable<double> SuppQty { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public TariffCategoryDTO TariffCategory { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [DataMember]//JsonProperty,
        private Guid EntityIdentifier { get; set; }
    }
}


