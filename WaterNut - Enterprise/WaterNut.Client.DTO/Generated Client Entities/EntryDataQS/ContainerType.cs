﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
//using Newtonsoft.Json;
using TrackableEntities;
using TrackableEntities.Client;
using Core.Common.Client.DTO;

namespace EntryDataQS.Client.DTO
{

   // [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class ContainerType : BaseEntity<ContainerType> , ITrackable, IEquatable<ContainerType>
    {
        [DataMember]
        public string ContainerCode
		{ 
		    get { return _ContainerCode; }
			set
			{
			    if (value == _ContainerCode) return;
				_ContainerCode = value;
				NotifyPropertyChanged();//m => this.ContainerCode
			}
		}
        private string _ContainerCode;

        [DataMember]
        public string ContainerTypeDescription
		{ 
		    get { return _ContainerTypeDescription; }
			set
			{
			    if (value == _ContainerTypeDescription) return;
				_ContainerTypeDescription = value;
				NotifyPropertyChanged();//m => this.ContainerTypeDescription
			}
		}
        private string _ContainerTypeDescription;

       
   //     [DataMember]
   //     public TrackingState TrackingState { get; set; }

   //     [DataMember]
   //     public ICollection<string> ModifiedProperties { get; set; }
        
    //  [DataMember]//JsonProperty, 
    //	private Guid EntityIdentifier { get; set; }
    
    //	[DataMember]//JsonProperty, 
    //	private Guid _entityIdentity = default(Guid);
    
    	bool IEquatable<ContainerType>.Equals(ContainerType other)
    	{
    		if (EntityIdentifier != default(Guid))
    			return EntityIdentifier == other.EntityIdentifier;
    		return false;
    	}
    }
}



