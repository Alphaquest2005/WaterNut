﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
//using Newtonsoft.Json;


using Core.Common.Client.DTO;
using TrackableEntities;
using TrackableEntities.Client;

namespace SalesDataQS.Client.DTO
{

   // [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class AsycudaDocumentEntryData : BaseEntity<AsycudaDocumentEntryData>, ITrackable, IEquatable<AsycudaDocumentEntryData>
    {
        [DataMember]
        public string EntryDataId
		{ 
		    get { return _EntryDataId; }
			set
			{
			    if (value == _EntryDataId) return;
				_EntryDataId = value;
				NotifyPropertyChanged();//m => this.EntryDataId
			}
		}
        private string _EntryDataId;

        [DataMember]
        public int Id
		{ 
		    get { return _Id; }
			set
			{
			    if (value == _Id) return;
				_Id = value;
				NotifyPropertyChanged();//m => this.Id
			}
		}
        private int _Id;

        [DataMember]
        public int AsycudaDocumentId
		{ 
		    get { return _AsycudaDocumentId; }
			set
			{
			    if (value == _AsycudaDocumentId) return;
				_AsycudaDocumentId = value;
				NotifyPropertyChanged();//m => this.AsycudaDocumentId
			}
		}
        private int _AsycudaDocumentId;

       
        [DataMember]
        public SalesData SalesData
		{
		    get { return _SalesData; }
			set
			{
			    if (value == _SalesData) return;
				_SalesData = value;
                SalesDataChangeTracker = _SalesData == null ? null
                    : new ChangeTrackingCollection<SalesData> { _SalesData };
				NotifyPropertyChanged();//m => this.SalesData
			}
		}
        private SalesData _SalesData;
        private ChangeTrackingCollection<SalesData> SalesDataChangeTracker { get; set; }

   //     [DataMember]
   //     public TrackingState TrackingState { get; set; }

   //     [DataMember]
   //     public ICollection<string> ModifiedProperties { get; set; }
        
    //  [DataMember]//JsonProperty, 
    //	private Guid EntityIdentifier { get; set; }
    
    //	[DataMember]//JsonProperty, 
    //	private Guid _entityIdentity = default(Guid);
    
    	bool IEquatable<AsycudaDocumentEntryData>.Equals(AsycudaDocumentEntryData other)
    	{
    		if (EntityIdentifier != default(Guid))
    			return EntityIdentifier == other.EntityIdentifier;
    		return false;
    	}
    }
}



