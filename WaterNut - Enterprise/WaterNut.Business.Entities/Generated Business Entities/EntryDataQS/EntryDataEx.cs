﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
//using Newtonsoft.Json;

using Core.Common.Business.Entities;
using WaterNut.Interfaces;
using TrackableEntities;

namespace EntryDataQS.Business.Entities
{
    //[JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class EntryDataEx : BaseEntity<EntryDataEx>, ITrackable 
    {
        partial void AutoGenStartUp() //EntryDataEx()
        {
            this.AsycudaDocumentSets = new List<AsycudaDocumentSetEntryData>();
            this.AsycudaDocuments = new List<AsycudaDocumentEntryData>();
            this.EntryDataDetailsExs = new List<EntryDataDetailsEx>();
            this.ContainerEntryDatas = new List<ContainerEntryData>();
        }

        [DataMember]
        public string Type 
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _type;
        [DataMember]
        public string DutyFreePaid 
        {
            get
            {
                return _dutyfreepaid;
            }
            set
            {
                _dutyfreepaid = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _dutyfreepaid;
        [DataMember]
        public Nullable<double> Total 
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<double> _total;
        [DataMember]
        public System.DateTime InvoiceDate 
        {
            get
            {
                return _invoicedate;
            }
            set
            {
                _invoicedate = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        System.DateTime _invoicedate;
        [DataMember]
        public string InvoiceNo 
        {
            get
            {
                return _invoiceno;
            }
            set
            {
                _invoiceno = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        string _invoiceno;
        [DataMember]
        public Nullable<double> ImportedTotal 
        {
            get
            {
                return _importedtotal;
            }
            set
            {
                _importedtotal = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<double> _importedtotal;
        [DataMember]
        public Nullable<int> ImportedLines 
        {
            get
            {
                return _importedlines;
            }
            set
            {
                _importedlines = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<int> _importedlines;
        [DataMember]
        public Nullable<int> TotalLines 
        {
            get
            {
                return _totallines;
            }
            set
            {
                _totallines = value;
                //if(this.TrackingState == TrackingState.Unchanged) this.TrackingState = TrackingState.Modified;  
                NotifyPropertyChanged();
            }
        }
        Nullable<int> _totallines;
        [DataMember]
        public List<AsycudaDocumentSetEntryData> AsycudaDocumentSets { get; set; }
        [DataMember]
        public List<AsycudaDocumentEntryData> AsycudaDocuments { get; set; }
        [DataMember]
        public List<EntryDataDetailsEx> EntryDataDetailsExs { get; set; }
        [DataMember]
        public List<ContainerEntryData> ContainerEntryDatas { get; set; }

 //       [DataMember]
 //       public TrackingState TrackingState { get; set; }
 //       [DataMember]
 //       public ICollection<string> ModifiedProperties { get; set; }
//        [DataMember]//JsonProperty,
 //       private Guid EntityIdentifier { get; set; }
    }
}


