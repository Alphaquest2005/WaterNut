﻿// <autogenerated>
//   This file was generated by T4 code generator AllClientModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using EntryDataQS.Client.DTO;
using TrackableEntities.Client;

namespace EntryDataQS.Client.Entities
{

    public partial class AsycudaDocumentSetEntryData 
    {
       public AsycudaDocumentSetEntryData()
        {
            this.DTO = new DTO.AsycudaDocumentSetEntryData();//{TrackingState = TrackableEntities.TrackingState.Added}
            _changeTracker = new ChangeTrackingCollection<DTO.AsycudaDocumentSetEntryData>(this.DTO);

            CustomClassStartUp();
            MyNavPropStartUp();
            IIdentifiableEntityStartUp();
            AutoGenStartUp();
        }
    partial void CustomClassStartUp();
    partial void AutoGenStartUp();
    partial void MyNavPropStartUp();
    partial void IIdentifiableEntityStartUp();
   
    }
}
		