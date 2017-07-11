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
using WaterNut.Interfaces;
using Core.Common.Client.Entities;
using CoreEntities.Client.DTO;
using TrackableEntities.Client;
using TrackableEntities;
using Core.Common.Validation;

namespace CoreEntities.Client.Entities
{
       public partial class Customs_Procedure: BaseEntity<Customs_Procedure>
    {
        DTO.Customs_Procedure customs_procedure;
        public Customs_Procedure(DTO.Customs_Procedure dto )
        {
              customs_procedure = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.Customs_Procedure>(customs_procedure);

        }

        public DTO.Customs_Procedure DTO
        {
            get
            {
             return customs_procedure;
            }
            set
            {
                customs_procedure = value;
            }
        }
       [RequiredValidationAttribute(ErrorMessage= "Document_Type is required")]
       
public int Document_TypeId
		{ 
		    get { return this.customs_procedure.Document_TypeId; }
			set
			{
			    if (value == this.customs_procedure.Document_TypeId) return;
				this.customs_procedure.Document_TypeId = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Document_TypeId");
			}
		}
     

       [RequiredValidationAttribute(ErrorMessage= "Customs_Procedure is required")]
       
public int Customs_ProcedureId
		{ 
		    get { return this.customs_procedure.Customs_ProcedureId; }
			set
			{
			    if (value == this.customs_procedure.Customs_ProcedureId) return;
				this.customs_procedure.Customs_ProcedureId = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Customs_ProcedureId");
			}
		}
     

       
       
                
                
public string Extended_customs_procedure
		{ 
		    get { return this.customs_procedure.Extended_customs_procedure; }
			set
			{
			    if (value == this.customs_procedure.Extended_customs_procedure) return;
				this.customs_procedure.Extended_customs_procedure = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("Extended_customs_procedure");
			}
		}
     

       
       
                
                
public string National_customs_procedure
		{ 
		    get { return this.customs_procedure.National_customs_procedure; }
			set
			{
			    if (value == this.customs_procedure.National_customs_procedure) return;
				this.customs_procedure.National_customs_procedure = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("National_customs_procedure");
			}
		}
     

       
       
public Nullable<bool> IsDefault
		{ 
		    get { return this.customs_procedure.IsDefault; }
			set
			{
			    if (value == this.customs_procedure.IsDefault) return;
				this.customs_procedure.IsDefault = value;
                if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("IsDefault");
			}
		}
     

       private Document_Type _Document_Type;
        public  Document_Type Document_Type
		{
		    get
               { 
                  if (this.customs_procedure != null)
                   {
                       if (_Document_Type != null)
                       {
                           if (this.customs_procedure.Document_Type !=
                               _Document_Type.DTO)
                           {
                                if (this.customs_procedure.Document_Type  != null)
                               _Document_Type = new Document_Type(this.customs_procedure.Document_Type);
                           }
                       }
                       else
                       {
                             if (this.customs_procedure.Document_Type  != null)
                           _Document_Type = new Document_Type(this.customs_procedure.Document_Type);
                       }
                   }


             //       if (_Document_Type != null) return _Document_Type;
                       
             //       var i = new Document_Type(){TrackingState = TrackingState.Added};
			//		//if (this.customs_procedure.Document_Type == null) Debugger.Break();
			//		if (this.customs_procedure.Document_Type != null)
            //        {
            //           i. = this.customs_procedure.Document_Type;
            //        }
            //        else
            //        {
            //            this.customs_procedure.Document_Type = i.;
             //       }
                           
            //        _Document_Type = i;
                     
                    return _Document_Type;
               }
			set
			{
			    if (value == _Document_Type) return;
                _Document_Type = value;
                if(value != null)
                     this.customs_procedure.Document_Type = value.DTO;
				if(this.DTO.TrackingState == TrackableEntities.TrackingState.Unchanged)this.DTO.TrackingState = TrackableEntities.TrackingState.Modified;
                NotifyPropertyChanged("Document_Type");
			}
		}
        


        ChangeTrackingCollection<DTO.Customs_Procedure> _changeTracker;    
        public ChangeTrackingCollection<DTO.Customs_Procedure> ChangeTracker
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

