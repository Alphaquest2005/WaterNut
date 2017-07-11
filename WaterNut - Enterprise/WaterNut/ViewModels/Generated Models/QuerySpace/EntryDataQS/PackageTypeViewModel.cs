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
    
	public partial class PackageTypeViewModel_AutoGen : ViewModelBase<PackageTypeViewModel_AutoGen>
	{

       private static readonly PackageTypeViewModel_AutoGen instance;
       static PackageTypeViewModel_AutoGen()
        {
            instance = new PackageTypeViewModel_AutoGen();
        }

       public static PackageTypeViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public PackageTypeViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<PackageType>(MessageToken.CurrentPackageTypeChanged, OnCurrentPackageTypeChanged);
            RegisterToReceiveMessages(MessageToken.PackageTypesChanged, OnPackageTypesChanged);
			RegisterToReceiveMessages(MessageToken.PackageTypesFilterExpressionChanged, OnPackageTypesFilterExpressionChanged);


 			// Recieve messages for Core Current Entities Changed
 

			PackageTypes = new VirtualList<PackageType>(vloader);
			PackageTypes.LoadingStateChanged += PackageTypes_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(PackageTypes, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<PackageType> _PackageTypes = null;
        public VirtualList<PackageType> PackageTypes
        {
            get
            {
                return _PackageTypes;
            }
            set
            {
                _PackageTypes = value;
            }
        }

		 private void OnPackageTypesFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			PackageTypes.Refresh();
            SelectedPackageTypes.Clear();
            NotifyPropertyChanged(x => SelectedPackageTypes);
            BeginSendMessage(MessageToken.SelectedPackageTypesChanged, new NotificationEventArgs(MessageToken.SelectedPackageTypesChanged));
        }

		void PackageTypes_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (PackageTypes.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => PackageTypes);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("PackageTypes | Error occured..." + PackageTypes.LastLoadingError.Message);
                    NotifyPropertyChanged(x => PackageTypes);
                    break;
            }
           
        }

		
		public readonly PackageTypeVirturalListLoader vloader = new PackageTypeVirturalListLoader();

		private ObservableCollection<PackageType> _selectedPackageTypes = new ObservableCollection<PackageType>();
        public ObservableCollection<PackageType> SelectedPackageTypes
        {
            get
            {
                return _selectedPackageTypes;
            }
            set
            {
                _selectedPackageTypes = value;
				BeginSendMessage(MessageToken.SelectedPackageTypesChanged,
                                    new NotificationEventArgs(MessageToken.SelectedPackageTypesChanged));
				 NotifyPropertyChanged(x => SelectedPackageTypes);
            }
        }

        internal void OnCurrentPackageTypeChanged(object sender, NotificationEventArgs<PackageType> e)
        {
            if(BaseViewModel.Instance.CurrentPackageType != null) BaseViewModel.Instance.CurrentPackageType.PropertyChanged += CurrentPackageType__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentPackageType);
        }   

            void CurrentPackageType__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                 } 
        internal void OnPackageTypesChanged(object sender, NotificationEventArgs e)
        {
            _PackageTypes.Refresh();
			NotifyPropertyChanged(x => this.PackageTypes);
        }   


 
  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_PackageTypes.Refresh();
			NotifyPropertyChanged(x => this.PackageTypes);
		}

		public async Task SelectAll()
        {
            IEnumerable<PackageType> lst = null;
            using (var ctx = new PackageTypeRepository())
            {
                lst = await ctx.GetPackageTypesByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedPackageTypes = new ObservableCollection<PackageType>(lst);
        }

 

		private string _packageCodeFilter;
        public string PackageCodeFilter
        {
            get
            {
                return _packageCodeFilter;
            }
            set
            {
                _packageCodeFilter = value;
				NotifyPropertyChanged(x => PackageCodeFilter);
                FilterData();
                
            }
        }	

 

		private string _packageDescriptionFilter;
        public string PackageDescriptionFilter
        {
            get
            {
                return _packageDescriptionFilter;
            }
            set
            {
                _packageDescriptionFilter = value;
				NotifyPropertyChanged(x => PackageDescriptionFilter);
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

			PackageTypes.Refresh();
			NotifyPropertyChanged(x => this.PackageTypes);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(PackageCodeFilter) == false)
						res.Append(" && " + string.Format("PackageCode.Contains(\"{0}\")",  PackageCodeFilter));						
 

									if(string.IsNullOrEmpty(PackageDescriptionFilter) == false)
						res.Append(" && " + string.Format("PackageDescription.Contains(\"{0}\")",  PackageDescriptionFilter));						
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<PackageType> lst = null;
            using (var ctx = new PackageTypeRepository())
            {
                lst = await ctx.GetPackageTypesByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<PackageTypeExcelLine, List<PackageTypeExcelLine>>
            {
                dataToPrint = lst.Select(x => new PackageTypeExcelLine
                {
 
                    PackageCode = x.PackageCode ,
                    
 
                    PackageDescription = x.PackageDescription 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class PackageTypeExcelLine
        {
		 
                    public string PackageCode { get; set; } 
                    
 
                    public string PackageDescription { get; set; } 
                    
        }

		
    }
}
		