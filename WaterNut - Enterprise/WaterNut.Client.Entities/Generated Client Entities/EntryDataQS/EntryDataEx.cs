﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientEntities.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using TrackableEntities.Client;
using Core.Common.Client.Entities;
using EntryDataQS.Client.DTO;


using Core.Common.Validation;

namespace EntryDataQS.Client.Entities
{
       public partial class EntryDataEx: BaseEntity<EntryDataEx>
    {
        DTO.EntryDataEx entrydataex;
        public EntryDataEx(DTO.EntryDataEx dto )
        {
              entrydataex = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.EntryDataEx>(entrydataex);

        }

        public DTO.EntryDataEx DTO
        {
            get
            {
             return entrydataex;
            }
            set
            {
                entrydataex = value;
            }
        }
        


       
       
                
                [MaxLength(5, ErrorMessage = "Type has a max length of 5 letters ")]
public string Type
		{ 
		    get { return this.entrydataex.Type; }
			set
			{
			    if (value == this.entrydataex.Type) return;
				this.entrydataex.Type = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Type");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "DutyFreePaid is required")]
       
                
                [MaxLength(9, ErrorMessage = "DutyFreePaid has a max length of 9 letters ")]
public string DutyFreePaid
		{ 
		    get { return this.entrydataex.DutyFreePaid; }
			set
			{
			    if (value == this.entrydataex.DutyFreePaid) return;
				this.entrydataex.DutyFreePaid = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DutyFreePaid");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Total
		{ 
		    get { return this.entrydataex.Total; }
			set
			{
			    if (value == this.entrydataex.Total) return;
				this.entrydataex.Total = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Total");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "InvoiceDate is required")]
       
public System.DateTime InvoiceDate
		{ 
		    get { return this.entrydataex.InvoiceDate; }
			set
			{
			    if (value == this.entrydataex.InvoiceDate) return;
				this.entrydataex.InvoiceDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("InvoiceDate");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "InvoiceNo is required")]
       
                
                [MaxLength(50, ErrorMessage = "InvoiceNo has a max length of 50 letters ")]
public string InvoiceNo
		{ 
		    get { return this.entrydataex.InvoiceNo; }
			set
			{
			    if (value == this.entrydataex.InvoiceNo) return;
				this.entrydataex.InvoiceNo = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("InvoiceNo");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> ImportedTotal
		{ 
		    get { return this.entrydataex.ImportedTotal; }
			set
			{
			    if (value == this.entrydataex.ImportedTotal) return;
				this.entrydataex.ImportedTotal = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ImportedTotal");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> ImportedLines
		{ 
		    get { return this.entrydataex.ImportedLines; }
			set
			{
			    if (value == this.entrydataex.ImportedLines) return;
				this.entrydataex.ImportedLines = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ImportedLines");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> TotalLines
		{ 
		    get { return this.entrydataex.TotalLines; }
			set
			{
			    if (value == this.entrydataex.TotalLines) return;
				this.entrydataex.TotalLines = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TotalLines");
			}
		}
     

        ObservableCollection<AsycudaDocumentSetEntryData> _AsycudaDocumentSets = null;
        public  ObservableCollection<AsycudaDocumentSetEntryData> AsycudaDocumentSets
		{
            
		    get 
				{ 
					if(_AsycudaDocumentSets != null) return _AsycudaDocumentSets;
					//if (this.entrydataex.AsycudaDocumentSets == null) Debugger.Break();
					if(this.entrydataex.AsycudaDocumentSets != null)
					{
						_AsycudaDocumentSets = new ObservableCollection<AsycudaDocumentSetEntryData>(this.entrydataex.AsycudaDocumentSets.Select(x => new AsycudaDocumentSetEntryData(x)));
					}
					
						_AsycudaDocumentSets.CollectionChanged += AsycudaDocumentSets_CollectionChanged; 
					
					return _AsycudaDocumentSets; 
				}
			set
			{
			    if (Equals(value, _AsycudaDocumentSets)) return;
				if (value != null)
					this.entrydataex.AsycudaDocumentSets = new ChangeTrackingCollection<DTO.AsycudaDocumentSetEntryData>(value.Select(x => x.DTO).ToList());
                _AsycudaDocumentSets = value;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				if (_AsycudaDocumentSets != null)
				_AsycudaDocumentSets.CollectionChanged += AsycudaDocumentSets_CollectionChanged;               
				NotifyPropertyChanged("AsycudaDocumentSets");
			}
		}
        
        void AsycudaDocumentSets_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (AsycudaDocumentSetEntryData itm in e.NewItems)
                    {
                        if (itm != null)
                        entrydataex.AsycudaDocumentSets.Add(itm.DTO);
                    }
                    if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (AsycudaDocumentSetEntryData itm in e.OldItems)
                    {
                        if (itm != null)
                        entrydataex.AsycudaDocumentSets.Remove(itm.DTO);
                    }
					if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                
            }
        }

        ObservableCollection<AsycudaDocumentEntryData> _AsycudaDocuments = null;
        public  ObservableCollection<AsycudaDocumentEntryData> AsycudaDocuments
		{
            
		    get 
				{ 
					if(_AsycudaDocuments != null) return _AsycudaDocuments;
					//if (this.entrydataex.AsycudaDocuments == null) Debugger.Break();
					if(this.entrydataex.AsycudaDocuments != null)
					{
						_AsycudaDocuments = new ObservableCollection<AsycudaDocumentEntryData>(this.entrydataex.AsycudaDocuments.Select(x => new AsycudaDocumentEntryData(x)));
					}
					
						_AsycudaDocuments.CollectionChanged += AsycudaDocuments_CollectionChanged; 
					
					return _AsycudaDocuments; 
				}
			set
			{
			    if (Equals(value, _AsycudaDocuments)) return;
				if (value != null)
					this.entrydataex.AsycudaDocuments = new ChangeTrackingCollection<DTO.AsycudaDocumentEntryData>(value.Select(x => x.DTO).ToList());
                _AsycudaDocuments = value;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				if (_AsycudaDocuments != null)
				_AsycudaDocuments.CollectionChanged += AsycudaDocuments_CollectionChanged;               
				NotifyPropertyChanged("AsycudaDocuments");
			}
		}
        
        void AsycudaDocuments_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (AsycudaDocumentEntryData itm in e.NewItems)
                    {
                        if (itm != null)
                        entrydataex.AsycudaDocuments.Add(itm.DTO);
                    }
                    if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (AsycudaDocumentEntryData itm in e.OldItems)
                    {
                        if (itm != null)
                        entrydataex.AsycudaDocuments.Remove(itm.DTO);
                    }
					if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                
            }
        }

        ObservableCollection<EntryDataDetailsEx> _EntryDataDetailsExs = null;
        public  ObservableCollection<EntryDataDetailsEx> EntryDataDetailsExs
		{
            
		    get 
				{ 
					if(_EntryDataDetailsExs != null) return _EntryDataDetailsExs;
					//if (this.entrydataex.EntryDataDetailsExs == null) Debugger.Break();
					if(this.entrydataex.EntryDataDetailsExs != null)
					{
						_EntryDataDetailsExs = new ObservableCollection<EntryDataDetailsEx>(this.entrydataex.EntryDataDetailsExs.Select(x => new EntryDataDetailsEx(x)));
					}
					
						_EntryDataDetailsExs.CollectionChanged += EntryDataDetailsExs_CollectionChanged; 
					
					return _EntryDataDetailsExs; 
				}
			set
			{
			    if (Equals(value, _EntryDataDetailsExs)) return;
				if (value != null)
					this.entrydataex.EntryDataDetailsExs = new ChangeTrackingCollection<DTO.EntryDataDetailsEx>(value.Select(x => x.DTO).ToList());
                _EntryDataDetailsExs = value;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				if (_EntryDataDetailsExs != null)
				_EntryDataDetailsExs.CollectionChanged += EntryDataDetailsExs_CollectionChanged;               
				NotifyPropertyChanged("EntryDataDetailsExs");
			}
		}
        
        void EntryDataDetailsExs_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (EntryDataDetailsEx itm in e.NewItems)
                    {
                        if (itm != null)
                        entrydataex.EntryDataDetailsExs.Add(itm.DTO);
                    }
                    if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (EntryDataDetailsEx itm in e.OldItems)
                    {
                        if (itm != null)
                        entrydataex.EntryDataDetailsExs.Remove(itm.DTO);
                    }
					if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                
            }
        }

        ObservableCollection<ContainerEntryData> _ContainerEntryDatas = null;
        public  ObservableCollection<ContainerEntryData> ContainerEntryDatas
		{
            
		    get 
				{ 
					if(_ContainerEntryDatas != null) return _ContainerEntryDatas;
					//if (this.entrydataex.ContainerEntryDatas == null) Debugger.Break();
					if(this.entrydataex.ContainerEntryDatas != null)
					{
						_ContainerEntryDatas = new ObservableCollection<ContainerEntryData>(this.entrydataex.ContainerEntryDatas.Select(x => new ContainerEntryData(x)));
					}
					
						_ContainerEntryDatas.CollectionChanged += ContainerEntryDatas_CollectionChanged; 
					
					return _ContainerEntryDatas; 
				}
			set
			{
			    if (Equals(value, _ContainerEntryDatas)) return;
				if (value != null)
					this.entrydataex.ContainerEntryDatas = new ChangeTrackingCollection<DTO.ContainerEntryData>(value.Select(x => x.DTO).ToList());
                _ContainerEntryDatas = value;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				if (_ContainerEntryDatas != null)
				_ContainerEntryDatas.CollectionChanged += ContainerEntryDatas_CollectionChanged;               
				NotifyPropertyChanged("ContainerEntryDatas");
			}
		}
        
        void ContainerEntryDatas_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (ContainerEntryData itm in e.NewItems)
                    {
                        if (itm != null)
                        entrydataex.ContainerEntryDatas.Add(itm.DTO);
                    }
                    if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (ContainerEntryData itm in e.OldItems)
                    {
                        if (itm != null)
                        entrydataex.ContainerEntryDatas.Remove(itm.DTO);
                    }
					if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                
            }
        }


        ChangeTrackingCollection<DTO.EntryDataEx> _changeTracker;    
        public ChangeTrackingCollection<DTO.EntryDataEx> ChangeTracker
        {
            get
            {
                return _changeTracker;
            }
        }

        public new TrackableEntities.TrackingState TrackingState
        {
            get
            {
                return this.TrackingState;
            }
            set
            {
                this.TrackingState = value;
                NotifyPropertyChanged("TrackingState");
            }
        }

    }
}


