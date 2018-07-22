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

using CounterPointQS.Client.Entities;
using CounterPointQS.Client.Repositories;
//using WaterNut.Client.Repositories;
        
using CoreEntities.Client.Entities;


namespace WaterNut.QuerySpace.CounterPointQS.ViewModels
{
    
	public partial class CounterPointPOsViewModel_AutoGen : ViewModelBase<CounterPointPOsViewModel_AutoGen>
	{

       private static readonly CounterPointPOsViewModel_AutoGen instance;
       static CounterPointPOsViewModel_AutoGen()
        {
            instance = new CounterPointPOsViewModel_AutoGen();
        }

       public static CounterPointPOsViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public CounterPointPOsViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<CounterPointPOs>(MessageToken.CurrentCounterPointPOsChanged, OnCurrentCounterPointPOsChanged);
            RegisterToReceiveMessages(MessageToken.CounterPointPOsChanged, OnCounterPointPOsChanged);
			RegisterToReceiveMessages(MessageToken.CounterPointPOsFilterExpressionChanged, OnCounterPointPOsFilterExpressionChanged);


 			// Recieve messages for Core Current Entities Changed
 

			CounterPointPOs = new VirtualList<CounterPointPOs>(vloader);
			CounterPointPOs.LoadingStateChanged += CounterPointPOs_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(CounterPointPOs, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<CounterPointPOs> _CounterPointPOs = null;
        public VirtualList<CounterPointPOs> CounterPointPOs
        {
            get
            {
                return _CounterPointPOs;
            }
            set
            {
                _CounterPointPOs = value;
            }
        }

		 private void OnCounterPointPOsFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			CounterPointPOs.Refresh();
            SelectedCounterPointPOs.Clear();
            NotifyPropertyChanged(x => SelectedCounterPointPOs);
            BeginSendMessage(MessageToken.SelectedCounterPointPOsChanged, new NotificationEventArgs(MessageToken.SelectedCounterPointPOsChanged));
        }

		void CounterPointPOs_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (CounterPointPOs.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => CounterPointPOs);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("CounterPointPOs | Error occured..." + CounterPointPOs.LastLoadingError.Message);
                    NotifyPropertyChanged(x => CounterPointPOs);
                    break;
            }
           
        }

		
		public readonly CounterPointPOsVirturalListLoader vloader = new CounterPointPOsVirturalListLoader();

		private ObservableCollection<CounterPointPOs> _selectedCounterPointPOs = new ObservableCollection<CounterPointPOs>();
        public ObservableCollection<CounterPointPOs> SelectedCounterPointPOs
        {
            get
            {
                return _selectedCounterPointPOs;
            }
            set
            {
                _selectedCounterPointPOs = value;
				BeginSendMessage(MessageToken.SelectedCounterPointPOsChanged,
                                    new NotificationEventArgs(MessageToken.SelectedCounterPointPOsChanged));
				 NotifyPropertyChanged(x => SelectedCounterPointPOs);
            }
        }

        internal void OnCurrentCounterPointPOsChanged(object sender, NotificationEventArgs<CounterPointPOs> e)
        {
            if(BaseViewModel.Instance.CurrentCounterPointPOs != null) BaseViewModel.Instance.CurrentCounterPointPOs.PropertyChanged += CurrentCounterPointPOs__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentCounterPointPOs);
        }   

            void CurrentCounterPointPOs__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                 } 
        internal void OnCounterPointPOsChanged(object sender, NotificationEventArgs e)
        {
            _CounterPointPOs.Refresh();
			NotifyPropertyChanged(x => this.CounterPointPOs);
        }   


 
  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_CounterPointPOs.Refresh();
			NotifyPropertyChanged(x => this.CounterPointPOs);
		}

		public async Task SelectAll()
        {
            IEnumerable<CounterPointPOs> lst = null;
            using (var ctx = new CounterPointPOsRepository())
            {
                lst = await ctx.GetCounterPointPOsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedCounterPointPOs = new ObservableCollection<CounterPointPOs>(lst);
        }

 

		private string _purchaseOrderNoFilter;
        public string PurchaseOrderNoFilter
        {
            get
            {
                return _purchaseOrderNoFilter;
            }
            set
            {
                _purchaseOrderNoFilter = value;
				NotifyPropertyChanged(x => PurchaseOrderNoFilter);
                FilterData();
                
            }
        }	

 
		private DateTime? _startDateFilter = DateTime.Parse(string.Format("{0}/1/{1}", DateTime.Now.Month ,DateTime.Now.Year));
        public DateTime? StartDateFilter
        {
            get
            {
                return _startDateFilter;
            }
            set
            {
                _startDateFilter = value;
				NotifyPropertyChanged(x => StartDateFilter);
                FilterData();
                
            }
        }	

		private DateTime? _endDateFilter = DateTime.Parse(string.Format("{1}/{0}/{2}", DateTime.DaysInMonth( DateTime.Now.Year,DateTime.Now.Month), DateTime.Now.Month, DateTime.Now.Year));
        public DateTime? EndDateFilter
        {
            get
            {
                return _endDateFilter;
            }
            set
            {
                _endDateFilter = value;
				NotifyPropertyChanged(x => EndDateFilter);
                FilterData();
                
            }
        }
 

		private DateTime? _dateFilter;
        public DateTime? DateFilter
        {
            get
            {
                return _dateFilter;
            }
            set
            {
                _dateFilter = value;
				NotifyPropertyChanged(x => DateFilter);
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

			CounterPointPOs.Refresh();
			NotifyPropertyChanged(x => this.CounterPointPOs);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(PurchaseOrderNoFilter) == false)
						res.Append(" && " + string.Format("PurchaseOrderNo.Contains(\"{0}\")",  PurchaseOrderNoFilter));						
 

 

				if (Convert.ToDateTime(StartDateFilter).Date != DateTime.MinValue &&
		        Convert.ToDateTime(EndDateFilter).Date != DateTime.MinValue) res.Append(" && (");

					if (Convert.ToDateTime(StartDateFilter).Date != DateTime.MinValue)
						{
							if(StartDateFilter.HasValue)
								res.Append(
                                            (Convert.ToDateTime(EndDateFilter).Date != DateTime.MinValue?"":" && ") +
                                            string.Format("Date >= \"{0}\"",  Convert.ToDateTime(StartDateFilter).Date.ToString("MM/dd/yyyy")));
						}

					if (Convert.ToDateTime(EndDateFilter).Date != DateTime.MinValue)
						{
							if(EndDateFilter.HasValue)
								res.Append(" && " + string.Format("Date <= \"{0}\"",  Convert.ToDateTime(EndDateFilter).Date.AddHours(23).ToString("MM/dd/yyyy HH:mm:ss")));
						}

				if (Convert.ToDateTime(StartDateFilter).Date != DateTime.MinValue &&
		        Convert.ToDateTime(EndDateFilter).Date != DateTime.MinValue) res.Append(" )");

					if (Convert.ToDateTime(_dateFilter).Date != DateTime.MinValue)
						{
							if(DateFilter.HasValue)
								res.Append(" && " + string.Format("Date == \"{0}\"",  Convert.ToDateTime(DateFilter).Date.ToString("MM/dd/yyyy")));
						}
				 

					if(LineNumberFilter.HasValue)
						res.Append(" && " + string.Format("LineNumber == {0}",  LineNumberFilter.ToString()));				 

									if(DownloadedFilter.HasValue)
						res.Append(" && " + string.Format("Downloaded == {0}",  DownloadedFilter));						
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<CounterPointPOs> lst = null;
            using (var ctx = new CounterPointPOsRepository())
            {
                lst = await ctx.GetCounterPointPOsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<CounterPointPOsExcelLine, List<CounterPointPOsExcelLine>>
            {
                dataToPrint = lst.Select(x => new CounterPointPOsExcelLine
                {
 
                    PurchaseOrderNo = x.PurchaseOrderNo ,
                    
 
                    Date = x.Date ,
                    
 
                    LineNumber = x.LineNumber ,
                    
 
                    Downloaded = x.Downloaded 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class CounterPointPOsExcelLine
        {
		 
                    public string PurchaseOrderNo { get; set; } 
                    
 
                    public System.DateTime Date { get; set; } 
                    
 
                    public int LineNumber { get; set; } 
                    
 
                    public Nullable<bool> Downloaded { get; set; } 
                    
        }

		
    }
}
		
