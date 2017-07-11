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

namespace OversShortQS.Client.DTO
{

   // [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class OverShortAllocationsEX : BaseEntity<OverShortAllocationsEX> , ITrackable, IEquatable<OverShortAllocationsEX>
    {
        [DataMember]
        public int OverShortDetailId
		{ 
		    get { return _OverShortDetailId; }
			set
			{
			    if (value == _OverShortDetailId) return;
				_OverShortDetailId = value;
				NotifyPropertyChanged();//m => this.OverShortDetailId
			}
		}
        private int _OverShortDetailId;

        [DataMember]
        public int OversShortsId
		{ 
		    get { return _OversShortsId; }
			set
			{
			    if (value == _OversShortsId) return;
				_OversShortsId = value;
				NotifyPropertyChanged();//m => this.OversShortsId
			}
		}
        private int _OversShortsId;

        [DataMember]
        public Nullable<double> ReceivedQty
		{ 
		    get { return _ReceivedQty; }
			set
			{
			    if (value == _ReceivedQty) return;
				_ReceivedQty = value;
				NotifyPropertyChanged();//m => this.ReceivedQty
			}
		}
        private Nullable<double> _ReceivedQty;

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
        public Nullable<double> Cost
		{ 
		    get { return _Cost; }
			set
			{
			    if (value == _Cost) return;
				_Cost = value;
				NotifyPropertyChanged();//m => this.Cost
			}
		}
        private Nullable<double> _Cost;

        [DataMember]
        public Nullable<double> InvoiceQty
		{ 
		    get { return _InvoiceQty; }
			set
			{
			    if (value == _InvoiceQty) return;
				_InvoiceQty = value;
				NotifyPropertyChanged();//m => this.InvoiceQty
			}
		}
        private Nullable<double> _InvoiceQty;

        [DataMember]
        public string InvoiceNo
		{ 
		    get { return _InvoiceNo; }
			set
			{
			    if (value == _InvoiceNo) return;
				_InvoiceNo = value;
				NotifyPropertyChanged();//m => this.InvoiceNo
			}
		}
        private string _InvoiceNo;

        [DataMember]
        public System.DateTime InvoiceDate
		{ 
		    get { return _InvoiceDate; }
			set
			{
			    if (value == _InvoiceDate) return;
				_InvoiceDate = value;
				NotifyPropertyChanged();//m => this.InvoiceDate
			}
		}
        private System.DateTime _InvoiceDate;

        [DataMember]
        public string CNumber
		{ 
		    get { return _CNumber; }
			set
			{
			    if (value == _CNumber) return;
				_CNumber = value;
				NotifyPropertyChanged();//m => this.CNumber
			}
		}
        private string _CNumber;

        [DataMember]
        public string RegistrationDate
		{ 
		    get { return _RegistrationDate; }
			set
			{
			    if (value == _RegistrationDate) return;
				_RegistrationDate = value;
				NotifyPropertyChanged();//m => this.RegistrationDate
			}
		}
        private string _RegistrationDate;

        [DataMember]
        public int OverShortAllocationId
		{ 
		    get { return _OverShortAllocationId; }
			set
			{
			    if (value == _OverShortAllocationId) return;
				_OverShortAllocationId = value;
				NotifyPropertyChanged();//m => this.OverShortAllocationId
			}
		}
        private int _OverShortAllocationId;

        [DataMember]
        public Nullable<int> Duration
		{ 
		    get { return _Duration; }
			set
			{
			    if (value == _Duration) return;
				_Duration = value;
				NotifyPropertyChanged();//m => this.Duration
			}
		}
        private Nullable<int> _Duration;

        [DataMember]
        public Nullable<int> InvoiceMonth
		{ 
		    get { return _InvoiceMonth; }
			set
			{
			    if (value == _InvoiceMonth) return;
				_InvoiceMonth = value;
				NotifyPropertyChanged();//m => this.InvoiceMonth
			}
		}
        private Nullable<int> _InvoiceMonth;

        [DataMember]
        public Nullable<int> AsycudaMonth
		{ 
		    get { return _AsycudaMonth; }
			set
			{
			    if (value == _AsycudaMonth) return;
				_AsycudaMonth = value;
				NotifyPropertyChanged();//m => this.AsycudaMonth
			}
		}
        private Nullable<int> _AsycudaMonth;

        [DataMember]
        public Nullable<double> AllocatedValue
		{ 
		    get { return _AllocatedValue; }
			set
			{
			    if (value == _AllocatedValue) return;
				_AllocatedValue = value;
				NotifyPropertyChanged();//m => this.AllocatedValue
			}
		}
        private Nullable<double> _AllocatedValue;

        [DataMember]
        public Nullable<double> ReceivedValue
		{ 
		    get { return _ReceivedValue; }
			set
			{
			    if (value == _ReceivedValue) return;
				_ReceivedValue = value;
				NotifyPropertyChanged();//m => this.ReceivedValue
			}
		}
        private Nullable<double> _ReceivedValue;

        [DataMember]
        public Nullable<double> InvoiceValue
		{ 
		    get { return _InvoiceValue; }
			set
			{
			    if (value == _InvoiceValue) return;
				_InvoiceValue = value;
				NotifyPropertyChanged();//m => this.InvoiceValue
			}
		}
        private Nullable<double> _InvoiceValue;

        [DataMember]
        public int LineNumber
		{ 
		    get { return _LineNumber; }
			set
			{
			    if (value == _LineNumber) return;
				_LineNumber = value;
				NotifyPropertyChanged();//m => this.LineNumber
			}
		}
        private int _LineNumber;

        [DataMember]
        public Nullable<double> PiQuantity
		{ 
		    get { return _PiQuantity; }
			set
			{
			    if (value == _PiQuantity) return;
				_PiQuantity = value;
				NotifyPropertyChanged();//m => this.PiQuantity
			}
		}
        private Nullable<double> _PiQuantity;

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
        public string OverShortDetailStatus
		{ 
		    get { return _OverShortDetailStatus; }
			set
			{
			    if (value == _OverShortDetailStatus) return;
				_OverShortDetailStatus = value;
				NotifyPropertyChanged();//m => this.OverShortDetailStatus
			}
		}
        private string _OverShortDetailStatus;

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
        public string AllocationStatus
		{ 
		    get { return _AllocationStatus; }
			set
			{
			    if (value == _AllocationStatus) return;
				_AllocationStatus = value;
				NotifyPropertyChanged();//m => this.AllocationStatus
			}
		}
        private string _AllocationStatus;

       
        [DataMember]
        public OverShortDetailAllocation OverShortDetailAllocation
		{
		    get { return _OverShortDetailAllocation; }
			set
			{
			    if (value == _OverShortDetailAllocation) return;
				_OverShortDetailAllocation = value;
                OverShortDetailAllocationChangeTracker = _OverShortDetailAllocation == null ? null
                    : new ChangeTrackingCollection<OverShortDetailAllocation> { _OverShortDetailAllocation };
				NotifyPropertyChanged();//m => this.OverShortDetailAllocation
			}
		}
        private OverShortDetailAllocation _OverShortDetailAllocation;
        private ChangeTrackingCollection<OverShortDetailAllocation> OverShortDetailAllocationChangeTracker { get; set; }

        [DataMember]
        public OverShortDetailsEX OverShortDetailsEX
		{
		    get { return _OverShortDetailsEX; }
			set
			{
			    if (value == _OverShortDetailsEX) return;
				_OverShortDetailsEX = value;
                OverShortDetailsEXChangeTracker = _OverShortDetailsEX == null ? null
                    : new ChangeTrackingCollection<OverShortDetailsEX> { _OverShortDetailsEX };
				NotifyPropertyChanged();//m => this.OverShortDetailsEX
			}
		}
        private OverShortDetailsEX _OverShortDetailsEX;
        private ChangeTrackingCollection<OverShortDetailsEX> OverShortDetailsEXChangeTracker { get; set; }

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
    
    	bool IEquatable<OverShortAllocationsEX>.Equals(OverShortAllocationsEX other)
    	{
    		if (EntityIdentifier != default(Guid))
    			return EntityIdentifier == other.EntityIdentifier;
    		return false;
    	}
    }
}



