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
    public partial class PackageType : BaseEntity<PackageType> , ITrackable, IEquatable<PackageType>
    {
        [DataMember]
        public string PackageCode
		{ 
		    get { return _PackageCode; }
			set
			{
			    if (value == _PackageCode) return;
				_PackageCode = value;
				NotifyPropertyChanged();//m => this.PackageCode
			}
		}
        private string _PackageCode;

        [DataMember]
        public string PackageDescription
		{ 
		    get { return _PackageDescription; }
			set
			{
			    if (value == _PackageDescription) return;
				_PackageDescription = value;
				NotifyPropertyChanged();//m => this.PackageDescription
			}
		}
        private string _PackageDescription;

       
   //     [DataMember]
   //     public TrackingState TrackingState { get; set; }

   //     [DataMember]
   //     public ICollection<string> ModifiedProperties { get; set; }
        
    //  [DataMember]//JsonProperty, 
    //	private Guid EntityIdentifier { get; set; }
    
    //	[DataMember]//JsonProperty, 
    //	private Guid _entityIdentity = default(Guid);
    
    	bool IEquatable<PackageType>.Equals(PackageType other)
    	{
    		if (EntityIdentifier != default(Guid))
    			return EntityIdentifier == other.EntityIdentifier;
    		return false;
    	}
    }
}



