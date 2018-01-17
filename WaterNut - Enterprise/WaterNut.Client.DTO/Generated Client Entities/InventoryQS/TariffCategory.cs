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

namespace InventoryQS.Client.DTO
{

   // [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace="http://www.insight-software.com/WaterNut")]
    public partial class TariffCategory : BaseEntity<TariffCategory>, ITrackable, IEquatable<TariffCategory>
    {
        [DataMember]
        public string TariffCategoryCode
		{ 
		    get { return _TariffCategoryCode; }
			set
			{
			    if (value == _TariffCategoryCode) return;
				_TariffCategoryCode = value;
				NotifyPropertyChanged();//m => this.TariffCategoryCode
			}
		}
        private string _TariffCategoryCode;

        [DataMember]
        public string Description
		{ 
		    get { return _Description; }
			set
			{
			    if (value == _Description) return;
				_Description = value;
				NotifyPropertyChanged();//m => this.Description
			}
		}
        private string _Description;

        [DataMember]
        public string ParentTariffCategoryCode
		{ 
		    get { return _ParentTariffCategoryCode; }
			set
			{
			    if (value == _ParentTariffCategoryCode) return;
				_ParentTariffCategoryCode = value;
				NotifyPropertyChanged();//m => this.ParentTariffCategoryCode
			}
		}
        private string _ParentTariffCategoryCode;

        [DataMember]
        public Nullable<bool> LicenseRequired
		{ 
		    get { return _LicenseRequired; }
			set
			{
			    if (value == _LicenseRequired) return;
				_LicenseRequired = value;
				NotifyPropertyChanged();//m => this.LicenseRequired
			}
		}
        private Nullable<bool> _LicenseRequired;

       
        [DataMember]
        public ChangeTrackingCollection<TariffCodes> TariffCodes
		{
		    get { return _TariffCodes; }
			set
			{
			    if (Equals(value, _TariffCodes)) return;
				_TariffCodes = value;
				NotifyPropertyChanged();//m => this.TariffCodes
			}
		}
        private ChangeTrackingCollection<TariffCodes> _TariffCodes = new ChangeTrackingCollection<TariffCodes>();

        [DataMember]
        public ChangeTrackingCollection<TariffCategoryCodeSuppUnit> TariffCategoryCodeSuppUnit
		{
		    get { return _TariffCategoryCodeSuppUnit; }
			set
			{
			    if (Equals(value, _TariffCategoryCodeSuppUnit)) return;
				_TariffCategoryCodeSuppUnit = value;
				NotifyPropertyChanged();//m => this.TariffCategoryCodeSuppUnit
			}
		}
        private ChangeTrackingCollection<TariffCategoryCodeSuppUnit> _TariffCategoryCodeSuppUnit = new ChangeTrackingCollection<TariffCategoryCodeSuppUnit>();

   //     [DataMember]
   //     public TrackingState TrackingState { get; set; }

   //     [DataMember]
   //     public ICollection<string> ModifiedProperties { get; set; }
        
    //  [DataMember]//JsonProperty, 
    //	private Guid EntityIdentifier { get; set; }
    
    //	[DataMember]//JsonProperty, 
    //	private Guid _entityIdentity = default(Guid);
    
    	bool IEquatable<TariffCategory>.Equals(TariffCategory other)
    	{
    		if (EntityIdentifier != default(Guid))
    			return EntityIdentifier == other.EntityIdentifier;
    		return false;
    	}
    }
}



