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
    
	public partial class SalesDataDetailViewModel_AutoGen : ViewModelBase<SalesDataDetailViewModel_AutoGen>
	{

       private static readonly SalesDataDetailViewModel_AutoGen instance;
       static SalesDataDetailViewModel_AutoGen()
        {
            instance = new SalesDataDetailViewModel_AutoGen();
        }

       public static SalesDataDetailViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public SalesDataDetailViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<SalesDataDetail>(MessageToken.CurrentSalesDataDetailChanged, OnCurrentSalesDataDetailChanged);
            RegisterToReceiveMessages(MessageToken.SalesDataDetailsChanged, OnSalesDataDetailsChanged);
			RegisterToReceiveMessages(MessageToken.SalesDataDetailsFilterExpressionChanged, OnSalesDataDetailsFilterExpressionChanged);

 
			RegisterToReceiveMessages<SalesData>(MessageToken.CurrentSalesDataChanged, OnCurrentSalesDataChanged);

 			// Recieve messages for Core Current Entities Changed
 

			SalesDataDetails = new VirtualList<SalesDataDetail>(vloader);
			SalesDataDetails.LoadingStateChanged += SalesDataDetails_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(SalesDataDetails, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<SalesDataDetail> _SalesDataDetails = null;
        public VirtualList<SalesDataDetail> SalesDataDetails
        {
            get
            {
                return _SalesDataDetails;
            }
            set
            {
                _SalesDataDetails = value;
            }
        }

		 private void OnSalesDataDetailsFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			SalesDataDetails.Refresh();
            SelectedSalesDataDetails.Clear();
            NotifyPropertyChanged(x => SelectedSalesDataDetails);
            BeginSendMessage(MessageToken.SelectedSalesDataDetailsChanged, new NotificationEventArgs(MessageToken.SelectedSalesDataDetailsChanged));
        }

		void SalesDataDetails_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (SalesDataDetails.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => SalesDataDetails);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("SalesDataDetails | Error occured..." + SalesDataDetails.LastLoadingError.Message);
                    NotifyPropertyChanged(x => SalesDataDetails);
                    break;
            }
           
        }

		
		public readonly SalesDataDetailVirturalListLoader vloader = new SalesDataDetailVirturalListLoader();

		private ObservableCollection<SalesDataDetail> _selectedSalesDataDetails = new ObservableCollection<SalesDataDetail>();
        public ObservableCollection<SalesDataDetail> SelectedSalesDataDetails
        {
            get
            {
                return _selectedSalesDataDetails;
            }
            set
            {
                _selectedSalesDataDetails = value;
				BeginSendMessage(MessageToken.SelectedSalesDataDetailsChanged,
                                    new NotificationEventArgs(MessageToken.SelectedSalesDataDetailsChanged));
				 NotifyPropertyChanged(x => SelectedSalesDataDetails);
            }
        }

        internal void OnCurrentSalesDataDetailChanged(object sender, NotificationEventArgs<SalesDataDetail> e)
        {
            if(BaseViewModel.Instance.CurrentSalesDataDetail != null) BaseViewModel.Instance.CurrentSalesDataDetail.PropertyChanged += CurrentSalesDataDetail__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentSalesDataDetail);
        }   

            void CurrentSalesDataDetail__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                    //if (e.PropertyName == "AddSalesData")
                   // {
                   //    if(SalesDatas.Contains(CurrentSalesDataDetail.SalesData) == false) SalesDatas.Add(CurrentSalesDataDetail.SalesData);
                    //}
                 } 
        internal void OnSalesDataDetailsChanged(object sender, NotificationEventArgs e)
        {
            _SalesDataDetails.Refresh();
			NotifyPropertyChanged(x => this.SalesDataDetails);
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

				SalesDataDetails.Refresh();
				NotifyPropertyChanged(x => this.SalesDataDetails);
                // SendMessage(MessageToken.SalesDataDetailsChanged, new NotificationEventArgs(MessageToken.SalesDataDetailsChanged));
                			}

  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
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
			_SalesDataDetails.Refresh();
			NotifyPropertyChanged(x => this.SalesDataDetails);
		}

		public async Task SelectAll()
        {
            IEnumerable<SalesDataDetail> lst = null;
            using (var ctx = new SalesDataDetailRepository())
            {
                lst = await ctx.GetSalesDataDetailsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedSalesDataDetails = new ObservableCollection<SalesDataDetail>(lst);
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

 

		private Int32? _lineNumberFilter;
        public Int32? LineNumberFilter
        {
            get
            {
                return _lineNumberFilter;
            }
            set
            {
                _lineNumberFilter = value;
				NotifyPropertyChanged(x => LineNumberFilter);
                FilterData();
                
            }
        }	

 

		private string _itemNumberFilter;
        public string ItemNumberFilter
        {
            get
            {
                return _itemNumberFilter;
            }
            set
            {
                _itemNumberFilter = value;
				NotifyPropertyChanged(x => ItemNumberFilter);
                FilterData();
                
            }
        }	

 

		private Double? _quantityFilter;
        public Double? QuantityFilter
        {
            get
            {
                return _quantityFilter;
            }
            set
            {
                _quantityFilter = value;
				NotifyPropertyChanged(x => QuantityFilter);
                FilterData();
                
            }
        }	

 

		private string _unitsFilter;
        public string UnitsFilter
        {
            get
            {
                return _unitsFilter;
            }
            set
            {
                _unitsFilter = value;
				NotifyPropertyChanged(x => UnitsFilter);
                FilterData();
                
            }
        }	

 

		private string _itemDescriptionFilter;
        public string ItemDescriptionFilter
        {
            get
            {
                return _itemDescriptionFilter;
            }
            set
            {
                _itemDescriptionFilter = value;
				NotifyPropertyChanged(x => ItemDescriptionFilter);
                FilterData();
                
            }
        }	

 

		private Double? _costFilter;
        public Double? CostFilter
        {
            get
            {
                return _costFilter;
            }
            set
            {
                _costFilter = value;
				NotifyPropertyChanged(x => CostFilter);
                FilterData();
                
            }
        }	

 

		private Double? _qtyAllocatedFilter;
        public Double? QtyAllocatedFilter
        {
            get
            {
                return _qtyAllocatedFilter;
            }
            set
            {
                _qtyAllocatedFilter = value;
				NotifyPropertyChanged(x => QtyAllocatedFilter);
                FilterData();
                
            }
        }	

 

		private Double? _unitWeightFilter;
        public Double? UnitWeightFilter
        {
            get
            {
                return _unitWeightFilter;
            }
            set
            {
                _unitWeightFilter = value;
				NotifyPropertyChanged(x => UnitWeightFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _doNotAllocateFilter;
        public Boolean? DoNotAllocateFilter
        {
            get
            {
                return _doNotAllocateFilter;
            }
            set
            {
                _doNotAllocateFilter = value;
				NotifyPropertyChanged(x => DoNotAllocateFilter);
                FilterData();
                
            }
        }	

 

		private string _tariffCodeFilter;
        public string TariffCodeFilter
        {
            get
            {
                return _tariffCodeFilter;
            }
            set
            {
                _tariffCodeFilter = value;
				NotifyPropertyChanged(x => TariffCodeFilter);
                FilterData();
                
            }
        }	

 

		private string _cNumberFilter;
        public string CNumberFilter
        {
            get
            {
                return _cNumberFilter;
            }
            set
            {
                _cNumberFilter = value;
				NotifyPropertyChanged(x => CNumberFilter);
                FilterData();
                
            }
        }	

 

		private Int32? _cLineNumberFilter;
        public Int32? CLineNumberFilter
        {
            get
            {
                return _cLineNumberFilter;
            }
            set
            {
                _cLineNumberFilter = value;
				NotifyPropertyChanged(x => CLineNumberFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _downloadedFilter;
        public Boolean? DownloadedFilter
        {
            get
            {
                return _downloadedFilter;
            }
            set
            {
                _downloadedFilter = value;
				NotifyPropertyChanged(x => DownloadedFilter);
                FilterData();
                
            }
        }	

 

		private Double? _salesValueFilter;
        public Double? SalesValueFilter
        {
            get
            {
                return _salesValueFilter;
            }
            set
            {
                _salesValueFilter = value;
				NotifyPropertyChanged(x => SalesValueFilter);
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

			SalesDataDetails.Refresh();
			NotifyPropertyChanged(x => this.SalesDataDetails);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(EntryDataIdFilter) == false)
						res.Append(" && " + string.Format("EntryDataId.Contains(\"{0}\")",  EntryDataIdFilter));						
 

					if(LineNumberFilter.HasValue)
						res.Append(" && " + string.Format("LineNumber == {0}",  LineNumberFilter.ToString()));				 

									if(string.IsNullOrEmpty(ItemNumberFilter) == false)
						res.Append(" && " + string.Format("ItemNumber.Contains(\"{0}\")",  ItemNumberFilter));						
 

					if(QuantityFilter.HasValue)
						res.Append(" && " + string.Format("Quantity == {0}",  QuantityFilter.ToString()));				 

									if(string.IsNullOrEmpty(UnitsFilter) == false)
						res.Append(" && " + string.Format("Units.Contains(\"{0}\")",  UnitsFilter));						
 

									if(string.IsNullOrEmpty(ItemDescriptionFilter) == false)
						res.Append(" && " + string.Format("ItemDescription.Contains(\"{0}\")",  ItemDescriptionFilter));						
 

					if(CostFilter.HasValue)
						res.Append(" && " + string.Format("Cost == {0}",  CostFilter.ToString()));				 

					if(QtyAllocatedFilter.HasValue)
						res.Append(" && " + string.Format("QtyAllocated == {0}",  QtyAllocatedFilter.ToString()));				 

					if(UnitWeightFilter.HasValue)
						res.Append(" && " + string.Format("UnitWeight == {0}",  UnitWeightFilter.ToString()));				 

									if(DoNotAllocateFilter.HasValue)
						res.Append(" && " + string.Format("DoNotAllocate == {0}",  DoNotAllocateFilter));						
 

									if(string.IsNullOrEmpty(TariffCodeFilter) == false)
						res.Append(" && " + string.Format("TariffCode.Contains(\"{0}\")",  TariffCodeFilter));						
 

									if(string.IsNullOrEmpty(CNumberFilter) == false)
						res.Append(" && " + string.Format("CNumber.Contains(\"{0}\")",  CNumberFilter));						
 

					if(CLineNumberFilter.HasValue)
						res.Append(" && " + string.Format("CLineNumber == {0}",  CLineNumberFilter.ToString()));				 

									if(DownloadedFilter.HasValue)
						res.Append(" && " + string.Format("Downloaded == {0}",  DownloadedFilter));						
 

					if(SalesValueFilter.HasValue)
						res.Append(" && " + string.Format("SalesValue == {0}",  SalesValueFilter.ToString()));							return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<SalesDataDetail> lst = null;
            using (var ctx = new SalesDataDetailRepository())
            {
                lst = await ctx.GetSalesDataDetailsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression, new List<string>() { "SalesData" }).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<SalesDataDetailExcelLine, List<SalesDataDetailExcelLine>>
            {
                dataToPrint = lst.Select(x => new SalesDataDetailExcelLine
                {
 
                    EntryDataId = x.EntryDataId ,

                    InvoiceDate = x.SalesData.EntryDataDate,
                    

                    LineNumber = x.LineNumber ,
                    
 
                    ItemNumber = x.ItemNumber ,
                    
 
                    Quantity = x.Quantity ,
                    
 
                    Units = x.Units ,
                    
 
                    ItemDescription = x.ItemDescription ,
                    
 
                    Cost = x.Cost ,
                    
 
                    QtyAllocated = x.QtyAllocated ,
                    
 
                    UnitWeight = x.UnitWeight ,
                    
 
                    DoNotAllocate = x.DoNotAllocate ,
                    
 
                    TariffCode = x.TariffCode ,
                    
 
                    CNumber = x.CNumber ,
                    
 
                    CLineNumber = x.CLineNumber ,
                    
 
                    Downloaded = x.Downloaded ,
                    
 
                    SalesValue = x.SalesValue 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class SalesDataDetailExcelLine
        {
		 
                    public string EntryDataId { get; set; } 
                    
 
                    public Nullable<int> LineNumber { get; set; } 
                    
 
                    public string ItemNumber { get; set; } 
                    
 
                    public double Quantity { get; set; } 
                    
 
                    public string Units { get; set; } 
                    
 
                    public string ItemDescription { get; set; } 
                    
 
                    public double Cost { get; set; } 
                    
 
                    public double QtyAllocated { get; set; } 
                    
 
                    public double UnitWeight { get; set; } 
                    
 
                    public Nullable<bool> DoNotAllocate { get; set; } 
                    
 
                    public string TariffCode { get; set; } 
                    
 
                    public string CNumber { get; set; } 
                    
 
                    public Nullable<int> CLineNumber { get; set; } 
                    
 
                    public Nullable<bool> Downloaded { get; set; } 
                    
 
                    public double SalesValue { get; set; }
            public DateTime InvoiceDate { get; set; }
        }

		
    }
}
		