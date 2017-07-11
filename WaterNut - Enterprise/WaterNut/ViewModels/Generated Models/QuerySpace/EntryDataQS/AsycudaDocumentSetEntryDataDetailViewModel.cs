﻿// <autogenerated>
//   This file was generated by T4 code generator AllQuerySpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Schedulers;
using SimpleMvvmToolkit;
using System;
using System.Windows;
using System.Windows.Data;
using System.Text;
using Core.Common.UI.DataVirtualization;
using System.Collections.Generic;
using Core.Common.UI;
using Core.Common.Converters;

using EntryDataQS.Client.Entities;
using EntryDataQS.Client.Repositories;
//using WaterNut.Client.Repositories;
        
using CoreEntities.Client.Entities;


namespace WaterNut.QuerySpace.EntryDataQS.ViewModels
{
    
	public partial class AsycudaDocumentSetEntryDataDetailViewModel_AutoGen : ViewModelBase<AsycudaDocumentSetEntryDataDetailViewModel_AutoGen>
	{

       private static readonly AsycudaDocumentSetEntryDataDetailViewModel_AutoGen instance;
       static AsycudaDocumentSetEntryDataDetailViewModel_AutoGen()
        {
            instance = new AsycudaDocumentSetEntryDataDetailViewModel_AutoGen();
        }

       public static AsycudaDocumentSetEntryDataDetailViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public AsycudaDocumentSetEntryDataDetailViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<AsycudaDocumentSetEntryDataDetail>(MessageToken.CurrentAsycudaDocumentSetEntryDataDetailChanged, OnCurrentAsycudaDocumentSetEntryDataDetailChanged);
            RegisterToReceiveMessages(MessageToken.AsycudaDocumentSetEntryDataDetailsChanged, OnAsycudaDocumentSetEntryDataDetailsChanged);
			RegisterToReceiveMessages(MessageToken.AsycudaDocumentSetEntryDataDetailsFilterExpressionChanged, OnAsycudaDocumentSetEntryDataDetailsFilterExpressionChanged);

 
			RegisterToReceiveMessages<EntryDataDetailsEx>(MessageToken.CurrentEntryDataDetailsExChanged, OnCurrentEntryDataDetailsExChanged);

 			// Recieve messages for Core Current Entities Changed
 

			AsycudaDocumentSetEntryDataDetails = new VirtualList<AsycudaDocumentSetEntryDataDetail>(vloader);
			AsycudaDocumentSetEntryDataDetails.LoadingStateChanged += AsycudaDocumentSetEntryDataDetails_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(AsycudaDocumentSetEntryDataDetails, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<AsycudaDocumentSetEntryDataDetail> _AsycudaDocumentSetEntryDataDetails = null;
        public VirtualList<AsycudaDocumentSetEntryDataDetail> AsycudaDocumentSetEntryDataDetails
        {
            get
            {
                return _AsycudaDocumentSetEntryDataDetails;
            }
            set
            {
                _AsycudaDocumentSetEntryDataDetails = value;
            }
        }

		 private void OnAsycudaDocumentSetEntryDataDetailsFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			AsycudaDocumentSetEntryDataDetails.Refresh();
            SelectedAsycudaDocumentSetEntryDataDetails.Clear();
            NotifyPropertyChanged(x => SelectedAsycudaDocumentSetEntryDataDetails);
            BeginSendMessage(MessageToken.SelectedAsycudaDocumentSetEntryDataDetailsChanged, new NotificationEventArgs(MessageToken.SelectedAsycudaDocumentSetEntryDataDetailsChanged));
        }

		void AsycudaDocumentSetEntryDataDetails_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (AsycudaDocumentSetEntryDataDetails.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => AsycudaDocumentSetEntryDataDetails);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("AsycudaDocumentSetEntryDataDetails | Error occured..." + AsycudaDocumentSetEntryDataDetails.LastLoadingError.Message);
                    NotifyPropertyChanged(x => AsycudaDocumentSetEntryDataDetails);
                    break;
            }
           
        }

		
		public readonly AsycudaDocumentSetEntryDataDetailVirturalListLoader vloader = new AsycudaDocumentSetEntryDataDetailVirturalListLoader();

		private ObservableCollection<AsycudaDocumentSetEntryDataDetail> _selectedAsycudaDocumentSetEntryDataDetails = new ObservableCollection<AsycudaDocumentSetEntryDataDetail>();
        public ObservableCollection<AsycudaDocumentSetEntryDataDetail> SelectedAsycudaDocumentSetEntryDataDetails
        {
            get
            {
                return _selectedAsycudaDocumentSetEntryDataDetails;
            }
            set
            {
                _selectedAsycudaDocumentSetEntryDataDetails = value;
				BeginSendMessage(MessageToken.SelectedAsycudaDocumentSetEntryDataDetailsChanged,
                                    new NotificationEventArgs(MessageToken.SelectedAsycudaDocumentSetEntryDataDetailsChanged));
				 NotifyPropertyChanged(x => SelectedAsycudaDocumentSetEntryDataDetails);
            }
        }

        internal void OnCurrentAsycudaDocumentSetEntryDataDetailChanged(object sender, NotificationEventArgs<AsycudaDocumentSetEntryDataDetail> e)
        {
            if(BaseViewModel.Instance.CurrentAsycudaDocumentSetEntryDataDetail != null) BaseViewModel.Instance.CurrentAsycudaDocumentSetEntryDataDetail.PropertyChanged += CurrentAsycudaDocumentSetEntryDataDetail__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentAsycudaDocumentSetEntryDataDetail);
        }   

            void CurrentAsycudaDocumentSetEntryDataDetail__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                    //if (e.PropertyName == "AddEntryDataDetailsEx")
                   // {
                   //    if(EntryDataDetailsExes.Contains(CurrentAsycudaDocumentSetEntryDataDetail.EntryDataDetailsEx) == false) EntryDataDetailsExes.Add(CurrentAsycudaDocumentSetEntryDataDetail.EntryDataDetailsEx);
                    //}
                 } 
        internal void OnAsycudaDocumentSetEntryDataDetailsChanged(object sender, NotificationEventArgs e)
        {
            _AsycudaDocumentSetEntryDataDetails.Refresh();
			NotifyPropertyChanged(x => this.AsycudaDocumentSetEntryDataDetails);
        }   


 	
		 internal void OnCurrentEntryDataDetailsExChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<EntryDataDetailsEx> e)
			{
			if(ViewCurrentEntryDataDetailsEx == false) return;
			if (e.Data == null || e.Data.EntryDataDetailsId == null)
                {
                    vloader.FilterExpression = "None";
                }
                else
                {
				vloader.FilterExpression = string.Format("EntryDataDetailsId == {0}", e.Data.EntryDataDetailsId.ToString());
                 }

				AsycudaDocumentSetEntryDataDetails.Refresh();
				NotifyPropertyChanged(x => this.AsycudaDocumentSetEntryDataDetails);
                // SendMessage(MessageToken.AsycudaDocumentSetEntryDataDetailsChanged, new NotificationEventArgs(MessageToken.AsycudaDocumentSetEntryDataDetailsChanged));
                			}

  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
 	
		 bool _viewCurrentEntryDataDetailsEx = true;
         public bool ViewCurrentEntryDataDetailsEx
         {
             get
             {
                 return _viewCurrentEntryDataDetailsEx;
             }
             set
             {
                 _viewCurrentEntryDataDetailsEx = value;
                 NotifyPropertyChanged(x => x.ViewCurrentEntryDataDetailsEx);
             }
         }
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_AsycudaDocumentSetEntryDataDetails.Refresh();
			NotifyPropertyChanged(x => this.AsycudaDocumentSetEntryDataDetails);
		}

		public async Task SelectAll()
        {
            IEnumerable<AsycudaDocumentSetEntryDataDetail> lst = null;
            using (var ctx = new AsycudaDocumentSetEntryDataDetailRepository())
            {
                lst = await ctx.GetAsycudaDocumentSetEntryDataDetailsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedAsycudaDocumentSetEntryDataDetails = new ObservableCollection<AsycudaDocumentSetEntryDataDetail>(lst);
        }

 
		internal bool DisableBaseFilterData = false;
        public virtual void FilterData()
	    {
	        FilterData(null);
	    }
		public void FilterData(StringBuilder res = null)
		{
		    if (DisableBaseFilterData) return;
			if(res == null) res = GetAutoPropertyFilterString();
			if (res.Length == 0 && vloader.NavigationExpression.Count != 0) res.Append("&& All");					
			if (res.Length > 0)
            {
                vloader.FilterExpression = res.ToString().Trim().Substring(2).Trim();
            }
            else
            {
                 if (vloader.FilterExpression != "All") vloader.FilterExpression = null;
            }

			AsycudaDocumentSetEntryDataDetails.Refresh();
			NotifyPropertyChanged(x => this.AsycudaDocumentSetEntryDataDetails);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<AsycudaDocumentSetEntryDataDetail> lst = null;
            using (var ctx = new AsycudaDocumentSetEntryDataDetailRepository())
            {
                lst = await ctx.GetAsycudaDocumentSetEntryDataDetailsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<AsycudaDocumentSetEntryDataDetailExcelLine, List<AsycudaDocumentSetEntryDataDetailExcelLine>>
            {
                dataToPrint = lst.Select(x => new AsycudaDocumentSetEntryDataDetailExcelLine
                {
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class AsycudaDocumentSetEntryDataDetailExcelLine
        {
		        }

		
    }
}
		