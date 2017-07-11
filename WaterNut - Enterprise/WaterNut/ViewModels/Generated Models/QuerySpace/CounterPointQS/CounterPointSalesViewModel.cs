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
    
	public partial class CounterPointSalesViewModel_AutoGen : ViewModelBase<CounterPointSalesViewModel_AutoGen>
	{

       private static readonly CounterPointSalesViewModel_AutoGen instance;
       static CounterPointSalesViewModel_AutoGen()
        {
            instance = new CounterPointSalesViewModel_AutoGen();
        }

       public static CounterPointSalesViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public CounterPointSalesViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<CounterPointSales>(MessageToken.CurrentCounterPointSalesChanged, OnCurrentCounterPointSalesChanged);
            RegisterToReceiveMessages(MessageToken.CounterPointSalesChanged, OnCounterPointSalesChanged);
			RegisterToReceiveMessages(MessageToken.CounterPointSalesFilterExpressionChanged, OnCounterPointSalesFilterExpressionChanged);


 			// Recieve messages for Core Current Entities Changed
 

			CounterPointSales = new VirtualList<CounterPointSales>(vloader);
			CounterPointSales.LoadingStateChanged += CounterPointSales_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(CounterPointSales, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<CounterPointSales> _CounterPointSales = null;
        public VirtualList<CounterPointSales> CounterPointSales
        {
            get
            {
                return _CounterPointSales;
            }
            set
            {
                _CounterPointSales = value;
            }
        }

		 private void OnCounterPointSalesFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			CounterPointSales.Refresh();
            SelectedCounterPointSales.Clear();
            NotifyPropertyChanged(x => SelectedCounterPointSales);
            BeginSendMessage(MessageToken.SelectedCounterPointSalesChanged, new NotificationEventArgs(MessageToken.SelectedCounterPointSalesChanged));
        }

		void CounterPointSales_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (CounterPointSales.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => CounterPointSales);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("CounterPointSales | Error occured..." + CounterPointSales.LastLoadingError.Message);
                    NotifyPropertyChanged(x => CounterPointSales);
                    break;
            }
           
        }

		
		public readonly CounterPointSalesVirturalListLoader vloader = new CounterPointSalesVirturalListLoader();

		private ObservableCollection<CounterPointSales> _selectedCounterPointSales = new ObservableCollection<CounterPointSales>();
        public ObservableCollection<CounterPointSales> SelectedCounterPointSales
        {
            get
            {
                return _selectedCounterPointSales;
            }
            set
            {
                _selectedCounterPointSales = value;
				BeginSendMessage(MessageToken.SelectedCounterPointSalesChanged,
                                    new NotificationEventArgs(MessageToken.SelectedCounterPointSalesChanged));
				 NotifyPropertyChanged(x => SelectedCounterPointSales);
            }
        }

        internal void OnCurrentCounterPointSalesChanged(object sender, NotificationEventArgs<CounterPointSales> e)
        {
            if(BaseViewModel.Instance.CurrentCounterPointSales != null) BaseViewModel.Instance.CurrentCounterPointSales.PropertyChanged += CurrentCounterPointSales__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentCounterPointSales);
        }   

            void CurrentCounterPointSales__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                 } 
        internal void OnCounterPointSalesChanged(object sender, NotificationEventArgs e)
        {
            _CounterPointSales.Refresh();
			NotifyPropertyChanged(x => this.CounterPointSales);
        }   


 
  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_CounterPointSales.Refresh();
			NotifyPropertyChanged(x => this.CounterPointSales);
		}

		public async Task SelectAll()
        {
            IEnumerable<CounterPointSales> lst = null;
            using (var ctx = new CounterPointSalesRepository())
            {
                lst = await ctx.GetCounterPointSalesByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedCounterPointSales = new ObservableCollection<CounterPointSales>(lst);
        }

 

		private string _invoiceNoFilter;
        public string InvoiceNoFilter
        {
            get
            {
                return _invoiceNoFilter;
            }
            set
            {
                _invoiceNoFilter = value;
				NotifyPropertyChanged(x => InvoiceNoFilter);
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

 

		private Decimal? _tAX_AMTFilter;
        public Decimal? TAX_AMTFilter
        {
            get
            {
                return _tAX_AMTFilter;
            }
            set
            {
                _tAX_AMTFilter = value;
				NotifyPropertyChanged(x => TAX_AMTFilter);
                FilterData();
                
            }
        }	

 

		private string _customerNameFilter;
        public string CustomerNameFilter
        {
            get
            {
                return _customerNameFilter;
            }
            set
            {
                _customerNameFilter = value;
				NotifyPropertyChanged(x => CustomerNameFilter);
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

			CounterPointSales.Refresh();
			NotifyPropertyChanged(x => this.CounterPointSales);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(InvoiceNoFilter) == false)
						res.Append(" && " + string.Format("InvoiceNo.Contains(\"{0}\")",  InvoiceNoFilter));						
 

 

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
								res.Append(" && " + string.Format("Date <= \"{0}\"",  Convert.ToDateTime(EndDateFilter).Date.AddHours(23).ToString("MM/dd/yyyy")));
						}

				if (Convert.ToDateTime(StartDateFilter).Date != DateTime.MinValue &&
		        Convert.ToDateTime(EndDateFilter).Date != DateTime.MinValue) res.Append(" )");

					if (Convert.ToDateTime(_dateFilter).Date != DateTime.MinValue)
						{
							if(DateFilter.HasValue)
								res.Append(" && " + string.Format("Date == \"{0}\"",  Convert.ToDateTime(DateFilter).Date.ToString("MM/dd/yyyy")));
						}
				 

					if(TAX_AMTFilter.HasValue)
						res.Append(" && " + string.Format("TAX_AMT == {0}",  TAX_AMTFilter.ToString()));				 

									if(string.IsNullOrEmpty(CustomerNameFilter) == false)
						res.Append(" && " + string.Format("CustomerName.Contains(\"{0}\")",  CustomerNameFilter));						
 

					if(LineNumberFilter.HasValue)
						res.Append(" && " + string.Format("LineNumber == {0}",  LineNumberFilter.ToString()));				 

									if(DownloadedFilter.HasValue)
						res.Append(" && " + string.Format("Downloaded == {0}",  DownloadedFilter));						
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<CounterPointSales> lst = null;
            using (var ctx = new CounterPointSalesRepository())
            {
                lst = await ctx.GetCounterPointSalesByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<CounterPointSalesExcelLine, List<CounterPointSalesExcelLine>>
            {
                dataToPrint = lst.Select(x => new CounterPointSalesExcelLine
                {
 
                    InvoiceNo = x.InvoiceNo ,
                    
 
                    Date = x.Date ,
                    
 
                    TAX_AMT = x.TAX_AMT ,
                    
 
                    CustomerName = x.CustomerName ,
                    
 
                    LineNumber = x.LineNumber ,
                    
 
                    Downloaded = x.Downloaded 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class CounterPointSalesExcelLine
        {
		 
                    public string InvoiceNo { get; set; } 
                    
 
                    public Nullable<System.DateTime> Date { get; set; } 
                    
 
                    public decimal TAX_AMT { get; set; } 
                    
 
                    public string CustomerName { get; set; } 
                    
 
                    public Nullable<int> LineNumber { get; set; } 
                    
 
                    public Nullable<bool> Downloaded { get; set; } 
                    
        }

		
    }
}
		
