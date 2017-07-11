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
    
	public partial class EntryDataExViewModel_AutoGen : ViewModelBase<EntryDataExViewModel_AutoGen>
	{

       private static readonly EntryDataExViewModel_AutoGen instance;
       static EntryDataExViewModel_AutoGen()
        {
            instance = new EntryDataExViewModel_AutoGen();
        }

       public static EntryDataExViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public EntryDataExViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<EntryDataEx>(MessageToken.CurrentEntryDataExChanged, OnCurrentEntryDataExChanged);
            RegisterToReceiveMessages(MessageToken.EntryDataExChanged, OnEntryDataExChanged);
			RegisterToReceiveMessages(MessageToken.EntryDataExFilterExpressionChanged, OnEntryDataExFilterExpressionChanged);


 			// Recieve messages for Core Current Entities Changed
 

			EntryDataEx = new VirtualList<EntryDataEx>(vloader);
			EntryDataEx.LoadingStateChanged += EntryDataEx_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(EntryDataEx, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<EntryDataEx> _EntryDataEx = null;
        public VirtualList<EntryDataEx> EntryDataEx
        {
            get
            {
                return _EntryDataEx;
            }
            set
            {
                _EntryDataEx = value;
            }
        }

		 private void OnEntryDataExFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			EntryDataEx.Refresh();
            SelectedEntryDataEx.Clear();
            NotifyPropertyChanged(x => SelectedEntryDataEx);
            BeginSendMessage(MessageToken.SelectedEntryDataExChanged, new NotificationEventArgs(MessageToken.SelectedEntryDataExChanged));
        }

		void EntryDataEx_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (EntryDataEx.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => EntryDataEx);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("EntryDataEx | Error occured..." + EntryDataEx.LastLoadingError.Message);
                    NotifyPropertyChanged(x => EntryDataEx);
                    break;
            }
           
        }

		
		public readonly EntryDataExVirturalListLoader vloader = new EntryDataExVirturalListLoader();

		private ObservableCollection<EntryDataEx> _selectedEntryDataEx = new ObservableCollection<EntryDataEx>();
        public ObservableCollection<EntryDataEx> SelectedEntryDataEx
        {
            get
            {
                return _selectedEntryDataEx;
            }
            set
            {
                _selectedEntryDataEx = value;
				BeginSendMessage(MessageToken.SelectedEntryDataExChanged,
                                    new NotificationEventArgs(MessageToken.SelectedEntryDataExChanged));
				 NotifyPropertyChanged(x => SelectedEntryDataEx);
            }
        }

        internal void OnCurrentEntryDataExChanged(object sender, NotificationEventArgs<EntryDataEx> e)
        {
            if(BaseViewModel.Instance.CurrentEntryDataEx != null) BaseViewModel.Instance.CurrentEntryDataEx.PropertyChanged += CurrentEntryDataEx__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentEntryDataEx);
        }   

            void CurrentEntryDataEx__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                 } 
        internal void OnEntryDataExChanged(object sender, NotificationEventArgs e)
        {
            _EntryDataEx.Refresh();
			NotifyPropertyChanged(x => this.EntryDataEx);
        }   


 
  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_EntryDataEx.Refresh();
			NotifyPropertyChanged(x => this.EntryDataEx);
		}

		public async Task SelectAll()
        {
            IEnumerable<EntryDataEx> lst = null;
            using (var ctx = new EntryDataExRepository())
            {
                lst = await ctx.GetEntryDataExByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedEntryDataEx = new ObservableCollection<EntryDataEx>(lst);
        }

 

		private string _typeFilter;
        public string TypeFilter
        {
            get
            {
                return _typeFilter;
            }
            set
            {
                _typeFilter = value;
				NotifyPropertyChanged(x => TypeFilter);
                FilterData();
                
            }
        }	

 

		private string _dutyFreePaidFilter;
        public string DutyFreePaidFilter
        {
            get
            {
                return _dutyFreePaidFilter;
            }
            set
            {
                _dutyFreePaidFilter = value;
				NotifyPropertyChanged(x => DutyFreePaidFilter);
                FilterData();
                
            }
        }	

 

		private Double? _totalFilter;
        public Double? TotalFilter
        {
            get
            {
                return _totalFilter;
            }
            set
            {
                _totalFilter = value;
				NotifyPropertyChanged(x => TotalFilter);
                FilterData();
                
            }
        }	

 
		private DateTime? _startInvoiceDateFilter = DateTime.Parse(string.Format("{0}/1/{1}", DateTime.Now.Month ,DateTime.Now.Year));
        public DateTime? StartInvoiceDateFilter
        {
            get
            {
                return _startInvoiceDateFilter;
            }
            set
            {
                _startInvoiceDateFilter = value;
				NotifyPropertyChanged(x => StartInvoiceDateFilter);
                FilterData();
                
            }
        }	

		private DateTime? _endInvoiceDateFilter = DateTime.Parse(string.Format("{1}/{0}/{2}", DateTime.DaysInMonth( DateTime.Now.Year,DateTime.Now.Month), DateTime.Now.Month, DateTime.Now.Year));
        public DateTime? EndInvoiceDateFilter
        {
            get
            {
                return _endInvoiceDateFilter;
            }
            set
            {
                _endInvoiceDateFilter = value;
				NotifyPropertyChanged(x => EndInvoiceDateFilter);
                FilterData();
                
            }
        }
 

		private DateTime? _invoiceDateFilter;
        public DateTime? InvoiceDateFilter
        {
            get
            {
                return _invoiceDateFilter;
            }
            set
            {
                _invoiceDateFilter = value;
				NotifyPropertyChanged(x => InvoiceDateFilter);
                FilterData();
                
            }
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

 

		private Double? _importedTotalFilter;
        public Double? ImportedTotalFilter
        {
            get
            {
                return _importedTotalFilter;
            }
            set
            {
                _importedTotalFilter = value;
				NotifyPropertyChanged(x => ImportedTotalFilter);
                FilterData();
                
            }
        }	

 

		private Int32? _importedLinesFilter;
        public Int32? ImportedLinesFilter
        {
            get
            {
                return _importedLinesFilter;
            }
            set
            {
                _importedLinesFilter = value;
				NotifyPropertyChanged(x => ImportedLinesFilter);
                FilterData();
                
            }
        }	

 

		private Int32? _totalLinesFilter;
        public Int32? TotalLinesFilter
        {
            get
            {
                return _totalLinesFilter;
            }
            set
            {
                _totalLinesFilter = value;
				NotifyPropertyChanged(x => TotalLinesFilter);
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

			EntryDataEx.Refresh();
			NotifyPropertyChanged(x => this.EntryDataEx);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(TypeFilter) == false)
						res.Append(" && " + string.Format("Type.Contains(\"{0}\")",  TypeFilter));						
 

									if(string.IsNullOrEmpty(DutyFreePaidFilter) == false)
						res.Append(" && " + string.Format("DutyFreePaid.Contains(\"{0}\")",  DutyFreePaidFilter));						
 

					if(TotalFilter.HasValue)
						res.Append(" && " + string.Format("Total == {0}",  TotalFilter.ToString()));				 

 

				if (Convert.ToDateTime(StartInvoiceDateFilter).Date != DateTime.MinValue &&
		        Convert.ToDateTime(EndInvoiceDateFilter).Date != DateTime.MinValue) res.Append(" && (");

					if (Convert.ToDateTime(StartInvoiceDateFilter).Date != DateTime.MinValue)
						{
							if(StartInvoiceDateFilter.HasValue)
								res.Append(
                                            (Convert.ToDateTime(EndInvoiceDateFilter).Date != DateTime.MinValue?"":" && ") +
                                            string.Format("InvoiceDate >= \"{0}\"",  Convert.ToDateTime(StartInvoiceDateFilter).Date.ToString("MM/dd/yyyy")));
						}

					if (Convert.ToDateTime(EndInvoiceDateFilter).Date != DateTime.MinValue)
						{
							if(EndInvoiceDateFilter.HasValue)
								res.Append(" && " + string.Format("InvoiceDate <= \"{0}\"",  Convert.ToDateTime(EndInvoiceDateFilter).Date.AddHours(23).ToString("MM/dd/yyyy")));
						}

				if (Convert.ToDateTime(StartInvoiceDateFilter).Date != DateTime.MinValue &&
		        Convert.ToDateTime(EndInvoiceDateFilter).Date != DateTime.MinValue) res.Append(" )");

					if (Convert.ToDateTime(_invoiceDateFilter).Date != DateTime.MinValue)
						{
							if(InvoiceDateFilter.HasValue)
								res.Append(" && " + string.Format("InvoiceDate == \"{0}\"",  Convert.ToDateTime(InvoiceDateFilter).Date.ToString("MM/dd/yyyy")));
						}
				 

									if(string.IsNullOrEmpty(InvoiceNoFilter) == false)
						res.Append(" && " + string.Format("InvoiceNo.Contains(\"{0}\")",  InvoiceNoFilter));						
 

					if(ImportedTotalFilter.HasValue)
						res.Append(" && " + string.Format("ImportedTotal == {0}",  ImportedTotalFilter.ToString()));				 

					if(ImportedLinesFilter.HasValue)
						res.Append(" && " + string.Format("ImportedLines == {0}",  ImportedLinesFilter.ToString()));				 

					if(TotalLinesFilter.HasValue)
						res.Append(" && " + string.Format("TotalLines == {0}",  TotalLinesFilter.ToString()));							return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<EntryDataEx> lst = null;
            using (var ctx = new EntryDataExRepository())
            {
                lst = await ctx.GetEntryDataExByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<EntryDataExExcelLine, List<EntryDataExExcelLine>>
            {
                dataToPrint = lst.Select(x => new EntryDataExExcelLine
                {
 
                    Type = x.Type ,
                    
 
                    DutyFreePaid = x.DutyFreePaid ,
                    
 
                    Total = x.Total ,
                    
 
                    InvoiceDate = x.InvoiceDate ,
                    
 
                    InvoiceNo = x.InvoiceNo ,
                    
 
                    ImportedTotal = x.ImportedTotal ,
                    
 
                    ImportedLines = x.ImportedLines ,
                    
 
                    TotalLines = x.TotalLines 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class EntryDataExExcelLine
        {
		 
                    public string Type { get; set; } 
                    
 
                    public string DutyFreePaid { get; set; } 
                    
 
                    public Nullable<double> Total { get; set; } 
                    
 
                    public System.DateTime InvoiceDate { get; set; } 
                    
 
                    public string InvoiceNo { get; set; } 
                    
 
                    public Nullable<double> ImportedTotal { get; set; } 
                    
 
                    public Nullable<int> ImportedLines { get; set; } 
                    
 
                    public Nullable<int> TotalLines { get; set; } 
                    
        }

		
    }
}
		
