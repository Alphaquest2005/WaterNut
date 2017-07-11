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

using SalesDataQS.Client.Entities;
using SalesDataQS.Client.Repositories;
//using WaterNut.Client.Repositories;
        
using CoreEntities.Client.Entities;


namespace WaterNut.QuerySpace.SalesDataQS.ViewModels
{
    
	public partial class AsycudaDocumentEntryDataViewModel_AutoGen : ViewModelBase<AsycudaDocumentEntryDataViewModel_AutoGen>
	{

       private static readonly AsycudaDocumentEntryDataViewModel_AutoGen instance;
       static AsycudaDocumentEntryDataViewModel_AutoGen()
        {
            instance = new AsycudaDocumentEntryDataViewModel_AutoGen();
        }

       public static AsycudaDocumentEntryDataViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public AsycudaDocumentEntryDataViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<AsycudaDocumentEntryData>(MessageToken.CurrentAsycudaDocumentEntryDataChanged, OnCurrentAsycudaDocumentEntryDataChanged);
            RegisterToReceiveMessages(MessageToken.AsycudaDocumentEntryDataChanged, OnAsycudaDocumentEntryDataChanged);
			RegisterToReceiveMessages(MessageToken.AsycudaDocumentEntryDataFilterExpressionChanged, OnAsycudaDocumentEntryDataFilterExpressionChanged);

 
			RegisterToReceiveMessages<SalesData>(MessageToken.CurrentSalesDataChanged, OnCurrentSalesDataChanged);

 			// Recieve messages for Core Current Entities Changed
                        RegisterToReceiveMessages<AsycudaDocument>(CoreEntities.MessageToken.CurrentAsycudaDocumentChanged, OnCurrentAsycudaDocumentChanged);
 

			AsycudaDocumentEntryData = new VirtualList<AsycudaDocumentEntryData>(vloader);
			AsycudaDocumentEntryData.LoadingStateChanged += AsycudaDocumentEntryData_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(AsycudaDocumentEntryData, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<AsycudaDocumentEntryData> _AsycudaDocumentEntryData = null;
        public VirtualList<AsycudaDocumentEntryData> AsycudaDocumentEntryData
        {
            get
            {
                return _AsycudaDocumentEntryData;
            }
            set
            {
                _AsycudaDocumentEntryData = value;
            }
        }

		 private void OnAsycudaDocumentEntryDataFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			AsycudaDocumentEntryData.Refresh();
            SelectedAsycudaDocumentEntryData.Clear();
            NotifyPropertyChanged(x => SelectedAsycudaDocumentEntryData);
            BeginSendMessage(MessageToken.SelectedAsycudaDocumentEntryDataChanged, new NotificationEventArgs(MessageToken.SelectedAsycudaDocumentEntryDataChanged));
        }

		void AsycudaDocumentEntryData_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (AsycudaDocumentEntryData.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => AsycudaDocumentEntryData);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("AsycudaDocumentEntryData | Error occured..." + AsycudaDocumentEntryData.LastLoadingError.Message);
                    NotifyPropertyChanged(x => AsycudaDocumentEntryData);
                    break;
            }
           
        }

		
		public readonly AsycudaDocumentEntryDataVirturalListLoader vloader = new AsycudaDocumentEntryDataVirturalListLoader();

		private ObservableCollection<AsycudaDocumentEntryData> _selectedAsycudaDocumentEntryData = new ObservableCollection<AsycudaDocumentEntryData>();
        public ObservableCollection<AsycudaDocumentEntryData> SelectedAsycudaDocumentEntryData
        {
            get
            {
                return _selectedAsycudaDocumentEntryData;
            }
            set
            {
                _selectedAsycudaDocumentEntryData = value;
				BeginSendMessage(MessageToken.SelectedAsycudaDocumentEntryDataChanged,
                                    new NotificationEventArgs(MessageToken.SelectedAsycudaDocumentEntryDataChanged));
				 NotifyPropertyChanged(x => SelectedAsycudaDocumentEntryData);
            }
        }

        internal void OnCurrentAsycudaDocumentEntryDataChanged(object sender, NotificationEventArgs<AsycudaDocumentEntryData> e)
        {
            if(BaseViewModel.Instance.CurrentAsycudaDocumentEntryData != null) BaseViewModel.Instance.CurrentAsycudaDocumentEntryData.PropertyChanged += CurrentAsycudaDocumentEntryData__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentAsycudaDocumentEntryData);
        }   

            void CurrentAsycudaDocumentEntryData__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                    //if (e.PropertyName == "AddSalesData")
                   // {
                   //    if(SalesDatas.Contains(CurrentAsycudaDocumentEntryData.SalesData) == false) SalesDatas.Add(CurrentAsycudaDocumentEntryData.SalesData);
                    //}
                    //if (e.PropertyName == "AddAsycudaDocument")
                   // {
                   //    if(AsycudaDocuments.Contains(CurrentAsycudaDocumentEntryData.AsycudaDocument) == false) AsycudaDocuments.Add(CurrentAsycudaDocumentEntryData.AsycudaDocument);
                    //}
                 } 
        internal void OnAsycudaDocumentEntryDataChanged(object sender, NotificationEventArgs e)
        {
            _AsycudaDocumentEntryData.Refresh();
			NotifyPropertyChanged(x => this.AsycudaDocumentEntryData);
        }   


 	
		 internal void OnCurrentSalesDataChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<SalesData> e)
			{
			if(ViewCurrentSalesData == false) return;
			if (e.Data == null || e.Data.EntryDataId == null)
                {
                    vloader.FilterExpression = "None";
                }
                else
                {
				
				vloader.FilterExpression = string.Format("EntryDataId == \"{0}\"", e.Data.EntryDataId.ToString());
                }

				AsycudaDocumentEntryData.Refresh();
				NotifyPropertyChanged(x => this.AsycudaDocumentEntryData);
                // SendMessage(MessageToken.AsycudaDocumentEntryDataChanged, new NotificationEventArgs(MessageToken.AsycudaDocumentEntryDataChanged));
                			}

  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
                internal void OnCurrentAsycudaDocumentChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<AsycudaDocument> e)
				{
				if (e.Data == null || e.Data.ASYCUDA_Id == null)
                {
                    vloader.FilterExpression = null;
                }
                else
                {
                    vloader.FilterExpression = string.Format("AsycudaDocumentId == {0}", e.Data.ASYCUDA_Id.ToString());
                }
					
                    AsycudaDocumentEntryData.Refresh();
					NotifyPropertyChanged(x => this.AsycudaDocumentEntryData);
				}
  
// Filtering Each Field except IDs
 	
		 bool _viewCurrentSalesData = true;
         public bool ViewCurrentSalesData
         {
             get
             {
                 return _viewCurrentSalesData;
             }
             set
             {
                 _viewCurrentSalesData = value;
                 NotifyPropertyChanged(x => x.ViewCurrentSalesData);
             }
         }
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_AsycudaDocumentEntryData.Refresh();
			NotifyPropertyChanged(x => this.AsycudaDocumentEntryData);
		}

		public async Task SelectAll()
        {
            IEnumerable<AsycudaDocumentEntryData> lst = null;
            using (var ctx = new AsycudaDocumentEntryDataRepository())
            {
                lst = await ctx.GetAsycudaDocumentEntryDataByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedAsycudaDocumentEntryData = new ObservableCollection<AsycudaDocumentEntryData>(lst);
        }

 

		private string _entryDataIdFilter;
        public string EntryDataIdFilter
        {
            get
            {
                return _entryDataIdFilter;
            }
            set
            {
                _entryDataIdFilter = value;
				NotifyPropertyChanged(x => EntryDataIdFilter);
                FilterData();
                
            }
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

			AsycudaDocumentEntryData.Refresh();
			NotifyPropertyChanged(x => this.AsycudaDocumentEntryData);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(EntryDataIdFilter) == false)
						res.Append(" && " + string.Format("EntryDataId.Contains(\"{0}\")",  EntryDataIdFilter));						
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<AsycudaDocumentEntryData> lst = null;
            using (var ctx = new AsycudaDocumentEntryDataRepository())
            {
                lst = await ctx.GetAsycudaDocumentEntryDataByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<AsycudaDocumentEntryDataExcelLine, List<AsycudaDocumentEntryDataExcelLine>>
            {
                dataToPrint = lst.Select(x => new AsycudaDocumentEntryDataExcelLine
                {
 
                    EntryDataId = x.EntryDataId 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class AsycudaDocumentEntryDataExcelLine
        {
		 
                    public string EntryDataId { get; set; } 
                    
        }

		
    }
}
		
