﻿// <autogenerated>
//   This file was generated by T4 code generator Business.Models.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

		namespace AllocationDS.Business.Entities
{
    public partial class EntryDataDetails
    {
       public EntryDataDetails()
        {
            CustomClassStartUp();
            MyNavPropStartUp();
            SetupProperties();
            IIdentifiableEntityStartUp();
            AutoGenStartUp();  
            TrackableStartUp();
        }

      public EntryDataDetails(bool start) : this()
       {
          if(start) StartTracking();
       }
    partial void SetupProperties();
    partial void AutoGenStartUp();
    partial void CustomClassStartUp();
    partial void MyNavPropStartUp();
    partial void IIdentifiableEntityStartUp();
    partial void TrackableStartUp();
   
    }
}
		