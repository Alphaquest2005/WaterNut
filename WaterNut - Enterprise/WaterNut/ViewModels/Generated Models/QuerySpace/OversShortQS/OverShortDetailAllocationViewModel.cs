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

using OversShortQS.Client.Entities;
using OversShortQS.Client.Repositories;
//using WaterNut.Client.Repositories;


namespace WaterNut.QuerySpace.OversShortQS.ViewModels
{
    
	public partial class OverShortDetailAllocationViewModel_AutoGen : ViewModelBase<OverShortDetailAllocationViewModel_AutoGen>
	{

       private static readonly OverShortDetailAllocationViewModel_AutoGen instance;
       static OverShortDetailAllocationViewModel_AutoGen()
        {
            instance = new OverShortDetailAllocationViewModel_AutoGen();
        }

       public static OverShortDetailAllocationViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public OverShortDetailAllocationViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<OverShortDetailAllocation>(MessageToken.CurrentOverShortDetailAllocationChanged, OnCurrentOverShortDetailAllocationChanged);
            RegisterToReceiveMessages(MessageToken.OverShortDetailAllocationsChanged, OnOverShortDetailAllocationsChanged);
			RegisterToReceiveMessages(MessageToken.OverShortDetailAllocationsFilterExpressionChanged, OnOverShortDetailAllocationsFilterExpressionChanged);

 
			RegisterToReceiveMessages<OverShortAllocationsEX>(MessageToken.CurrentOverShortAllocationsEXChanged, OnCurrentEXChanged);
 
			RegisterToReceiveMessages<OverShortDetail>(MessageToken.CurrentOverShortDetailChanged, OnCurrentOverShortDetailChanged);

 			// Recieve messages for Core Current Entities Changed
 

			OverShortDetailAllocations = new VirtualList<OverShortDetailAllocation>(vloader);
			OverShortDetailAllocations.LoadingStateChanged += OverShortDetailAllocations_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(OverShortDetailAllocations, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<OverShortDetailAllocation> _OverShortDetailAllocations = null;
        public VirtualList<OverShortDetailAllocation> OverShortDetailAllocations
        {
            get
            {
                return _OverShortDetailAllocations;
            }
            set
            {
                _OverShortDetailAllocations = value;
            }
        }

		 private void OnOverShortDetailAllocationsFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			OverShortDetailAllocations.Refresh();
            SelectedOverShortDetailAllocations.Clear();
            NotifyPropertyChanged(x => SelectedOverShortDetailAllocations);
            BeginSendMessage(MessageToken.SelectedOverShortDetailAllocationsChanged, new NotificationEventArgs(MessageToken.SelectedOverShortDetailAllocationsChanged));
        }

		void OverShortDetailAllocations_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (OverShortDetailAllocations.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => OverShortDetailAllocations);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("OverShortDetailAllocations | Error occured..." + OverShortDetailAllocations.LastLoadingError.Message);
                    NotifyPropertyChanged(x => OverShortDetailAllocations);
                    break;
            }
           
        }

		
		public readonly OverShortDetailAllocationVirturalListLoader vloader = new OverShortDetailAllocationVirturalListLoader();

		private ObservableCollection<OverShortDetailAllocation> _selectedOverShortDetailAllocations = new ObservableCollection<OverShortDetailAllocation>();
        public ObservableCollection<OverShortDetailAllocation> SelectedOverShortDetailAllocations
        {
            get
            {
                return _selectedOverShortDetailAllocations;
            }
            set
            {
                _selectedOverShortDetailAllocations = value;
				BeginSendMessage(MessageToken.SelectedOverShortDetailAllocationsChanged,
                                    new NotificationEventArgs(MessageToken.SelectedOverShortDetailAllocationsChanged));
				 NotifyPropertyChanged(x => SelectedOverShortDetailAllocations);
            }
        }

        internal void OnCurrentOverShortDetailAllocationChanged(object sender, NotificationEventArgs<OverShortDetailAllocation> e)
        {
            if(BaseViewModel.Instance.CurrentOverShortDetailAllocation != null) BaseViewModel.Instance.CurrentOverShortDetailAllocation.PropertyChanged += CurrentOverShortDetailAllocation__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentOverShortDetailAllocation);
        }   

            void CurrentOverShortDetailAllocation__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                    //if (e.PropertyName == "AddEX")
                   // {
                   //    if(OverShortAllocationsEXes.Contains(CurrentOverShortDetailAllocation.EX) == false) OverShortAllocationsEXes.Add(CurrentOverShortDetailAllocation.EX);
                    //}
                    //if (e.PropertyName == "AddOverShortDetail")
                   // {
                   //    if(OverShortDetails.Contains(CurrentOverShortDetailAllocation.OverShortDetail) == false) OverShortDetails.Add(CurrentOverShortDetailAllocation.OverShortDetail);
                    //}
                 } 
        internal void OnOverShortDetailAllocationsChanged(object sender, NotificationEventArgs e)
        {
            _OverShortDetailAllocations.Refresh();
			NotifyPropertyChanged(x => this.OverShortDetailAllocations);
        }   


 	
		 internal void OnCurrentEXChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<OverShortAllocationsEX> e)
			{
			if(ViewCurrentEX == false) return;
			if (e.Data == null || e.Data.OverShortAllocationId == null)
                {
                    vloader.FilterExpression = "None";
                }
                else
                {
                }

				OverShortDetailAllocations.Refresh();
				NotifyPropertyChanged(x => this.OverShortDetailAllocations);
                // SendMessage(MessageToken.OverShortDetailAllocationsChanged, new NotificationEventArgs(MessageToken.OverShortDetailAllocationsChanged));
                                          
                BaseViewModel.Instance.CurrentOverShortDetailAllocation = null;
			}
	
		 internal void OnCurrentOverShortDetailChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<OverShortDetail> e)
			{
			if(ViewCurrentOverShortDetail == false) return;
			if (e.Data == null || e.Data.OverShortDetailId == null)
                {
                    vloader.FilterExpression = "None";
                }
                else
                {
				vloader.FilterExpression = string.Format("OverShortDetailId == {0}", e.Data.OverShortDetailId.ToString());
                 }

				OverShortDetailAllocations.Refresh();
				NotifyPropertyChanged(x => this.OverShortDetailAllocations);
                // SendMessage(MessageToken.OverShortDetailAllocationsChanged, new NotificationEventArgs(MessageToken.OverShortDetailAllocationsChanged));
                                          
                BaseViewModel.Instance.CurrentOverShortDetailAllocation = null;
			}

  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
 	
		 bool _viewCurrentEX = false;
         public bool ViewCurrentEX
         {
             get
             {
                 return _viewCurrentEX;
             }
             set
             {
                 _viewCurrentEX = value;
                 NotifyPropertyChanged(x => x.ViewCurrentEX);
             }
         }
 	
		 bool _viewCurrentOverShortDetail = false;
         public bool ViewCurrentOverShortDetail
         {
             get
             {
                 return _viewCurrentOverShortDetail;
             }
             set
             {
                 _viewCurrentOverShortDetail = value;
                 NotifyPropertyChanged(x => x.ViewCurrentOverShortDetail);
             }
         }
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_OverShortDetailAllocations.Refresh();
			NotifyPropertyChanged(x => this.OverShortDetailAllocations);
		}

		public async Task SelectAll()
        {
            IEnumerable<OverShortDetailAllocation> lst = null;
            using (var ctx = new OverShortDetailAllocationRepository())
            {
                lst = await ctx.GetOverShortDetailAllocationsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedOverShortDetailAllocations = new ObservableCollection<OverShortDetailAllocation>(lst);
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

 

		private string _statusFilter;
        public string StatusFilter
        {
            get
            {
                return _statusFilter;
            }
            set
            {
                _statusFilter = value;
				NotifyPropertyChanged(x => StatusFilter);
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

			OverShortDetailAllocations.Refresh();
			NotifyPropertyChanged(x => this.OverShortDetailAllocations);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

					if(QtyAllocatedFilter.HasValue)
						res.Append(" && " + string.Format("QtyAllocated == {0}",  QtyAllocatedFilter.ToString()));				 

									if(string.IsNullOrEmpty(StatusFilter) == false)
						res.Append(" && " + string.Format("Status.Contains(\"{0}\")",  StatusFilter));						
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<OverShortDetailAllocation> lst = null;
            using (var ctx = new OverShortDetailAllocationRepository())
            {
                lst = await ctx.GetOverShortDetailAllocationsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<OverShortDetailAllocationExcelLine, List<OverShortDetailAllocationExcelLine>>
            {
                dataToPrint = lst.Select(x => new OverShortDetailAllocationExcelLine
                {
 
                    QtyAllocated = x.QtyAllocated ,
                    
 
                    Status = x.Status 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class OverShortDetailAllocationExcelLine
        {
		 
                    public double QtyAllocated { get; set; } 
                    
 
                    public string Status { get; set; } 
                    
        }

		
    }
}
		
