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

namespace CoreEntities.Client.DTO
{

   // [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class SubItems : BaseEntity<SubItems> , ITrackable, IEquatable<SubItems>
    {
        [DataMember]
        public int SubItem_Id
		{ 
		    get { return _SubItem_Id; }
			set
			{
			    if (value == _SubItem_Id) return;
				_SubItem_Id = value;
				NotifyPropertyChanged();//m => this.SubItem_Id
			}
		}
        private int _SubItem_Id;

        [DataMember]
        public int Item_Id
		{ 
		    get { return _Item_Id; }
			set
			{
			    if (value == _Item_Id) return;
				_Item_Id = value;
				NotifyPropertyChanged();//m => this.Item_Id
			}
		}
        private int _Item_Id;

        [DataMember]
        public string ItemNumber
		{ 
		    get { return _ItemNumber; }
			set
			{
			    if (value == _ItemNumber) return;
				_ItemNumber = value;
				NotifyPropertyChanged();//m => this.ItemNumber
			}
		}
        private string _ItemNumber;

        [DataMember]
        public string ItemDescription
		{ 
		    get { return _ItemDescription; }
			set
			{
			    if (value == _ItemDescription) return;
				_ItemDescription = value;
				NotifyPropertyChanged();//m => this.ItemDescription
			}
		}
        private string _ItemDescription;

        [DataMember]
        public double Quantity
		{ 
		    get { return _Quantity; }
			set
			{
			    if (value == _Quantity) return;
				_Quantity = value;
				NotifyPropertyChanged();//m => this.Quantity
			}
		}
        private double _Quantity;

        [DataMember]
        public double QtyAllocated
		{ 
		    get { return _QtyAllocated; }
			set
			{
			    if (value == _QtyAllocated) return;
				_QtyAllocated = value;
				NotifyPropertyChanged();//m => this.QtyAllocated
			}
		}
        private double _QtyAllocated;

       
        [DataMember]
        public AsycudaDocumentItem AsycudaDocumentItem
		{
		    get { return _AsycudaDocumentItem; }
			set
			{
			    if (value == _AsycudaDocumentItem) return;
				_AsycudaDocumentItem = value;
                AsycudaDocumentItemChangeTracker = _AsycudaDocumentItem == null ? null
                    : new ChangeTrackingCollection<AsycudaDocumentItem> { _AsycudaDocumentItem };
				NotifyPropertyChanged();//m => this.AsycudaDocumentItem
			}
		}
        private AsycudaDocumentItem _AsycudaDocumentItem;
        private ChangeTrackingCollection<AsycudaDocumentItem> AsycudaDocumentItemChangeTracker { get; set; }

   //     [DataMember]
   //     public TrackingState TrackingState { get; set; }

   //     [DataMember]
   //     public ICollection<string> ModifiedProperties { get; set; }
        
    //  [DataMember]//JsonProperty, 
    //	private Guid EntityIdentifier { get; set; }
    
    //	[DataMember]//JsonProperty, 
    //	private Guid _entityIdentity = default(Guid);
    
    	bool IEquatable<SubItems>.Equals(SubItems other)
    	{
    		if (EntityIdentifier != default(Guid))
    			return EntityIdentifier == other.EntityIdentifier;
    		return false;
    	}
    }
}



