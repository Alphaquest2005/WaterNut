﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using TrackableEntities.Client;

		namespace AllocationQS.Business.Entities
{
    public partial class AsycudaSalesAllocationsEx
    {
       
         partial void TrackableStartUp()
         {
           // _changeTracker = new ChangeTrackingCollection<AsycudaSalesAllocationsEx>(this);
         }

        ChangeTrackingCollection<AsycudaSalesAllocationsEx> _changeTracker;

        [NotMapped]
        [IgnoreDataMember]
        public new ChangeTrackingCollection<AsycudaSalesAllocationsEx> ChangeTracker
        {
            get
            {
                return _changeTracker;
            }
        }

         public void StartTracking()
        {
            _changeTracker = new ChangeTrackingCollection<AsycudaSalesAllocationsEx>(this);
        }
   
    }
}
		