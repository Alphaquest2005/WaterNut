﻿// <autogenerated>
//   This file was generated by T4 code generator AllBusinessModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using TrackableEntities.Client;

		namespace DocumentItemDS.Business.Entities
{
    public partial class xcuda_PreviousItem
    {
       
         partial void TrackableStartUp()
         {
           // _changeTracker = new ChangeTrackingCollection<xcuda_PreviousItem>(this);
         }

        ChangeTrackingCollection<xcuda_PreviousItem> _changeTracker;

        [NotMapped]
        [IgnoreDataMember]
        public new ChangeTrackingCollection<xcuda_PreviousItem> ChangeTracker
        {
            get
            {
                return _changeTracker;
            }
        }

         public void StartTracking()
        {
            _changeTracker = new ChangeTrackingCollection<xcuda_PreviousItem>(this);
        }
   
    }
}
		