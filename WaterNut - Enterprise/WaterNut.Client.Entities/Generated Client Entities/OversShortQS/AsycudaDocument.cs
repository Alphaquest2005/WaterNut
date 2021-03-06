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
using OversShortQS.Client.DTO;


using Core.Common.Validation;

namespace OversShortQS.Client.Entities
{
       public partial class AsycudaDocument: BaseEntity<AsycudaDocument>
    {
        DTO.AsycudaDocument asycudadocument;
        public AsycudaDocument(DTO.AsycudaDocument dto )
        {
              asycudadocument = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.AsycudaDocument>(asycudadocument);

        }

        public DTO.AsycudaDocument DTO
        {
            get
            {
             return asycudadocument;
            }
            set
            {
                asycudadocument = value;
            }
        }
        


       [RequiredValidationAttribute(ErrorMessage= "ASYCUDA_ is required")]
       
public int ASYCUDA_Id
		{ 
		    get { return this.asycudadocument.ASYCUDA_Id; }
			set
			{
			    if (value == this.asycudadocument.ASYCUDA_Id) return;
				this.asycudadocument.ASYCUDA_Id = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ASYCUDA_Id");
			}
		}
     

       
       
                
                
public string id
		{ 
		    get { return this.asycudadocument.id; }
			set
			{
			    if (value == this.asycudadocument.id) return;
				this.asycudadocument.id = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("id");
			}
		}
     

       
       
                
                
public string CNumber
		{ 
		    get { return this.asycudadocument.CNumber; }
			set
			{
			    if (value == this.asycudadocument.CNumber) return;
				this.asycudadocument.CNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("CNumber");
			}
		}
     

       
       
public Nullable<System.DateTime> RegistrationDate
		{ 
		    get { return this.asycudadocument.RegistrationDate; }
			set
			{
			    if (value == this.asycudadocument.RegistrationDate) return;
				this.asycudadocument.RegistrationDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("RegistrationDate");
			}
		}
     

       
       
public Nullable<bool> IsManuallyAssessed
		{ 
		    get { return this.asycudadocument.IsManuallyAssessed; }
			set
			{
			    if (value == this.asycudadocument.IsManuallyAssessed) return;
				this.asycudadocument.IsManuallyAssessed = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("IsManuallyAssessed");
			}
		}
     

       
       
                
                
public string ReferenceNumber
		{ 
		    get { return this.asycudadocument.ReferenceNumber; }
			set
			{
			    if (value == this.asycudadocument.ReferenceNumber) return;
				this.asycudadocument.ReferenceNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ReferenceNumber");
			}
		}
     

       
       
public Nullable<System.DateTime> EffectiveRegistrationDate
		{ 
		    get { return this.asycudadocument.EffectiveRegistrationDate; }
			set
			{
			    if (value == this.asycudadocument.EffectiveRegistrationDate) return;
				this.asycudadocument.EffectiveRegistrationDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("EffectiveRegistrationDate");
			}
		}
     

       
       
public Nullable<int> AsycudaDocumentSetId
		{ 
		    get { return this.asycudadocument.AsycudaDocumentSetId; }
			set
			{
			    if (value == this.asycudadocument.AsycudaDocumentSetId) return;
				this.asycudadocument.AsycudaDocumentSetId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("AsycudaDocumentSetId");
			}
		}
     

       
       
public Nullable<bool> DoNotAllocate
		{ 
		    get { return this.asycudadocument.DoNotAllocate; }
			set
			{
			    if (value == this.asycudadocument.DoNotAllocate) return;
				this.asycudadocument.DoNotAllocate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DoNotAllocate");
			}
		}
     

       
       
public Nullable<bool> AutoUpdate
		{ 
		    get { return this.asycudadocument.AutoUpdate; }
			set
			{
			    if (value == this.asycudadocument.AutoUpdate) return;
				this.asycudadocument.AutoUpdate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("AutoUpdate");
			}
		}
     

       
       
                
                [MaxLength(50, ErrorMessage = "BLNumber has a max length of 50 letters ")]
public string BLNumber
		{ 
		    get { return this.asycudadocument.BLNumber; }
			set
			{
			    if (value == this.asycudadocument.BLNumber) return;
				this.asycudadocument.BLNumber = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("BLNumber");
			}
		}
     

       
       
                
                
public string Description
		{ 
		    get { return this.asycudadocument.Description; }
			set
			{
			    if (value == this.asycudadocument.Description) return;
				this.asycudadocument.Description = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Description");
			}
		}
     

       
       
                
                
public string Type_of_declaration
		{ 
		    get { return this.asycudadocument.Type_of_declaration; }
			set
			{
			    if (value == this.asycudadocument.Type_of_declaration) return;
				this.asycudadocument.Type_of_declaration = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Type_of_declaration");
			}
		}
     

       
       
                
                
public string Declaration_gen_procedure_code
		{ 
		    get { return this.asycudadocument.Declaration_gen_procedure_code; }
			set
			{
			    if (value == this.asycudadocument.Declaration_gen_procedure_code) return;
				this.asycudadocument.Declaration_gen_procedure_code = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Declaration_gen_procedure_code");
			}
		}
     

       
       
                
                
public string Extended_customs_procedure
		{ 
		    get { return this.asycudadocument.Extended_customs_procedure; }
			set
			{
			    if (value == this.asycudadocument.Extended_customs_procedure) return;
				this.asycudadocument.Extended_customs_procedure = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Extended_customs_procedure");
			}
		}
     

       
       
                
                
public string DocumentType
		{ 
		    get { return this.asycudadocument.DocumentType; }
			set
			{
			    if (value == this.asycudadocument.DocumentType) return;
				this.asycudadocument.DocumentType = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("DocumentType");
			}
		}
     

       
       
public Nullable<int> Document_TypeId
		{ 
		    get { return this.asycudadocument.Document_TypeId; }
			set
			{
			    if (value == this.asycudadocument.Document_TypeId) return;
				this.asycudadocument.Document_TypeId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Document_TypeId");
			}
		}
     

       
       
public Nullable<int> Customs_ProcedureId
		{ 
		    get { return this.asycudadocument.Customs_ProcedureId; }
			set
			{
			    if (value == this.asycudadocument.Customs_ProcedureId) return;
				this.asycudadocument.Customs_ProcedureId = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Customs_ProcedureId");
			}
		}
     

       
       
                
                
public string Country_first_destination
		{ 
		    get { return this.asycudadocument.Country_first_destination; }
			set
			{
			    if (value == this.asycudadocument.Country_first_destination) return;
				this.asycudadocument.Country_first_destination = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Country_first_destination");
			}
		}
     

       
       
                
                [MaxLength(50, ErrorMessage = "Currency_code has a max length of 50 letters ")]
public string Currency_code
		{ 
		    get { return this.asycudadocument.Currency_code; }
			set
			{
			    if (value == this.asycudadocument.Currency_code) return;
				this.asycudadocument.Currency_code = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Currency_code");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> Currency_rate
		{ 
		    get { return this.asycudadocument.Currency_rate; }
			set
			{
			    if (value == this.asycudadocument.Currency_rate) return;
				this.asycudadocument.Currency_rate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Currency_rate");
			}
		}
     

       
       
                
                [MaxLength(50, ErrorMessage = "Manifest_reference_number has a max length of 50 letters ")]
public string Manifest_reference_number
		{ 
		    get { return this.asycudadocument.Manifest_reference_number; }
			set
			{
			    if (value == this.asycudadocument.Manifest_reference_number) return;
				this.asycudadocument.Manifest_reference_number = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Manifest_reference_number");
			}
		}
     

       
       
                
                
public string Customs_clearance_office_code
		{ 
		    get { return this.asycudadocument.Customs_clearance_office_code; }
			set
			{
			    if (value == this.asycudadocument.Customs_clearance_office_code) return;
				this.asycudadocument.Customs_clearance_office_code = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Customs_clearance_office_code");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<int> Lines
		{ 
		    get { return this.asycudadocument.Lines; }
			set
			{
			    if (value == this.asycudadocument.Lines) return;
				this.asycudadocument.Lines = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Lines");
			}
		}
     

       
       
public Nullable<bool> ImportComplete
		{ 
		    get { return this.asycudadocument.ImportComplete; }
			set
			{
			    if (value == this.asycudadocument.ImportComplete) return;
				this.asycudadocument.ImportComplete = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ImportComplete");
			}
		}
     

       
       
public Nullable<bool> Cancelled
		{ 
		    get { return this.asycudadocument.Cancelled; }
			set
			{
			    if (value == this.asycudadocument.Cancelled) return;
				this.asycudadocument.Cancelled = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Cancelled");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> TotalCIF
		{ 
		    get { return this.asycudadocument.TotalCIF; }
			set
			{
			    if (value == this.asycudadocument.TotalCIF) return;
				this.asycudadocument.TotalCIF = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TotalCIF");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> TotalGrossWeight
		{ 
		    get { return this.asycudadocument.TotalGrossWeight; }
			set
			{
			    if (value == this.asycudadocument.TotalGrossWeight) return;
				this.asycudadocument.TotalGrossWeight = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TotalGrossWeight");
			}
		}
     

       
       
public Nullable<System.DateTime> AssessmentDate
		{ 
		    get { return this.asycudadocument.AssessmentDate; }
			set
			{
			    if (value == this.asycudadocument.AssessmentDate) return;
				this.asycudadocument.AssessmentDate = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("AssessmentDate");
			}
		}
     

       
       [NumberValidationAttribute]
public Nullable<double> TotalFreight
		{ 
		    get { return this.asycudadocument.TotalFreight; }
			set
			{
			    if (value == this.asycudadocument.TotalFreight) return;
				this.asycudadocument.TotalFreight = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("TotalFreight");
			}
		}
     

        ObservableCollection<AsycudaDocumentItem> _AsycudaDocumentItems = null;
        public  ObservableCollection<AsycudaDocumentItem> AsycudaDocumentItems
		{
            
		    get 
				{ 
					if(_AsycudaDocumentItems != null) return _AsycudaDocumentItems;
					//if (this.asycudadocument.AsycudaDocumentItems == null) Debugger.Break();
					if(this.asycudadocument.AsycudaDocumentItems != null)
					{
						_AsycudaDocumentItems = new ObservableCollection<AsycudaDocumentItem>(this.asycudadocument.AsycudaDocumentItems.Select(x => new AsycudaDocumentItem(x)));
					}
					
						_AsycudaDocumentItems.CollectionChanged += AsycudaDocumentItems_CollectionChanged; 
					
					return _AsycudaDocumentItems; 
				}
			set
			{
			    if (Equals(value, _AsycudaDocumentItems)) return;
				if (value != null)
					this.asycudadocument.AsycudaDocumentItems = new ChangeTrackingCollection<DTO.AsycudaDocumentItem>(value.Select(x => x.DTO).ToList());
                _AsycudaDocumentItems = value;
				if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				if (_AsycudaDocumentItems != null)
				_AsycudaDocumentItems.CollectionChanged += AsycudaDocumentItems_CollectionChanged;               
				NotifyPropertyChanged("AsycudaDocumentItems");
			}
		}
        
        void AsycudaDocumentItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (AsycudaDocumentItem itm in e.NewItems)
                    {
                        if (itm != null)
                        asycudadocument.AsycudaDocumentItems.Add(itm.DTO);
                    }
                    if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (AsycudaDocumentItem itm in e.OldItems)
                    {
                        if (itm != null)
                        asycudadocument.AsycudaDocumentItems.Remove(itm.DTO);
                    }
					if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
                    break;
                
            }
        }


        ChangeTrackingCollection<DTO.AsycudaDocument> _changeTracker;    
        public ChangeTrackingCollection<DTO.AsycudaDocument> ChangeTracker
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
                return this.DTO.TrackingState;
            }
            set
            {
                this.DTO.TrackingState = value;
                NotifyPropertyChanged("TrackingState");
            }
        }

    }
}


