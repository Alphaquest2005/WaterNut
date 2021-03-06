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
       public partial class ContainerType: BaseEntity<ContainerType>
    {
        DTO.ContainerType containertype;
        public ContainerType(DTO.ContainerType dto )
        {
              containertype = dto;
             _changeTracker = new ChangeTrackingCollection<DTO.ContainerType>(containertype);

        }

        public DTO.ContainerType DTO
        {
            get
            {
             return containertype;
            }
            set
            {
                containertype = value;
            }
        }
       [RequiredValidationAttribute(ErrorMessage= "ContainerCode is required")]
       
                
                [MaxLength(10, ErrorMessage = "ContainerCode has a max length of 10 letters ")]
public string ContainerCode
		{ 
		    get { return this.containertype.ContainerCode; }
			set
			{
			    if (value == this.containertype.ContainerCode) return;
				this.containertype.ContainerCode = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ContainerCode");
			}
		}
     

       
       
                
                [MaxLength(50, ErrorMessage = "ContainerTypeDescription has a max length of 50 letters ")]
public string ContainerTypeDescription
		{ 
		    get { return this.containertype.ContainerTypeDescription; }
			set
			{
			    if (value == this.containertype.ContainerTypeDescription) return;
				this.containertype.ContainerTypeDescription = value;
                if(this.TrackingState == TrackableEntities.TrackingState.Unchanged)this.TrackingState = TrackableEntities.TrackingState.Modified;
				NotifyPropertyChanged("ContainerTypeDescription");
			}
		}
     


        ChangeTrackingCollection<DTO.ContainerType> _changeTracker;    
        public ChangeTrackingCollection<DTO.ContainerType> ChangeTracker
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


