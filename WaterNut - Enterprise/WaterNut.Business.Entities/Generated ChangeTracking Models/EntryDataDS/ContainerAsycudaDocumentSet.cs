﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using TrackableEntities.Client;

		namespace EntryDataDS.Business.Entities
{
    public partial class ContainerAsycudaDocumentSet
    {
       
         partial void TrackableStartUp()
         {
           // _changeTracker = new ChangeTrackingCollection<ContainerAsycudaDocumentSet>(this);
         }

        ChangeTrackingCollection<ContainerAsycudaDocumentSet> _changeTracker;

        [NotMapped]
        [IgnoreDataMember]
        public new ChangeTrackingCollection<ContainerAsycudaDocumentSet> ChangeTracker
        {
            get
            {
                return _changeTracker;
            }
        }

         public void StartTracking()
        {
            _changeTracker = new ChangeTrackingCollection<ContainerAsycudaDocumentSet>(this);
        }
   
    }
}
		