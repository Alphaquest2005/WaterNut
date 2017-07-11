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
    
	public partial class EmptyFullCodeViewModel_AutoGen : ViewModelBase<EmptyFullCodeViewModel_AutoGen>
	{

       private static readonly EmptyFullCodeViewModel_AutoGen instance;
       static EmptyFullCodeViewModel_AutoGen()
        {
            instance = new EmptyFullCodeViewModel_AutoGen();
        }

       public static EmptyFullCodeViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public EmptyFullCodeViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<EmptyFullCode>(MessageToken.CurrentEmptyFullCodeChanged, OnCurrentEmptyFullCodeChanged);
            RegisterToReceiveMessages(MessageToken.EmptyFullCodesChanged, OnEmptyFullCodesChanged);
			RegisterToReceiveMessages(MessageToken.EmptyFullCodesFilterExpressionChanged, OnEmptyFullCodesFilterExpressionChanged);


 			// Recieve messages for Core Current Entities Changed
 

			EmptyFullCodes = new VirtualList<EmptyFullCode>(vloader);
			EmptyFullCodes.LoadingStateChanged += EmptyFullCodes_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(EmptyFullCodes, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<EmptyFullCode> _EmptyFullCodes = null;
        public VirtualList<EmptyFullCode> EmptyFullCodes
        {
            get
            {
                return _EmptyFullCodes;
            }
            set
            {
                _EmptyFullCodes = value;
            }
        }

		 private void OnEmptyFullCodesFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			EmptyFullCodes.Refresh();
            SelectedEmptyFullCodes.Clear();
            NotifyPropertyChanged(x => SelectedEmptyFullCodes);
            BeginSendMessage(MessageToken.SelectedEmptyFullCodesChanged, new NotificationEventArgs(MessageToken.SelectedEmptyFullCodesChanged));
        }

		void EmptyFullCodes_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (EmptyFullCodes.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => EmptyFullCodes);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("EmptyFullCodes | Error occured..." + EmptyFullCodes.LastLoadingError.Message);
                    NotifyPropertyChanged(x => EmptyFullCodes);
                    break;
            }
           
        }

		
		public readonly EmptyFullCodeVirturalListLoader vloader = new EmptyFullCodeVirturalListLoader();

		private ObservableCollection<EmptyFullCode> _selectedEmptyFullCodes = new ObservableCollection<EmptyFullCode>();
        public ObservableCollection<EmptyFullCode> SelectedEmptyFullCodes
        {
            get
            {
                return _selectedEmptyFullCodes;
            }
            set
            {
                _selectedEmptyFullCodes = value;
				BeginSendMessage(MessageToken.SelectedEmptyFullCodesChanged,
                                    new NotificationEventArgs(MessageToken.SelectedEmptyFullCodesChanged));
				 NotifyPropertyChanged(x => SelectedEmptyFullCodes);
            }
        }

        internal void OnCurrentEmptyFullCodeChanged(object sender, NotificationEventArgs<EmptyFullCode> e)
        {
            if(BaseViewModel.Instance.CurrentEmptyFullCode != null) BaseViewModel.Instance.CurrentEmptyFullCode.PropertyChanged += CurrentEmptyFullCode__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentEmptyFullCode);
        }   

            void CurrentEmptyFullCode__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                 } 
        internal void OnEmptyFullCodesChanged(object sender, NotificationEventArgs e)
        {
            _EmptyFullCodes.Refresh();
			NotifyPropertyChanged(x => this.EmptyFullCodes);
        }   


 
  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_EmptyFullCodes.Refresh();
			NotifyPropertyChanged(x => this.EmptyFullCodes);
		}

		public async Task SelectAll()
        {
            IEnumerable<EmptyFullCode> lst = null;
            using (var ctx = new EmptyFullCodeRepository())
            {
                lst = await ctx.GetEmptyFullCodesByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedEmptyFullCodes = new ObservableCollection<EmptyFullCode>(lst);
        }

 

		private string _emptyFullCodeNameFilter;
        public string EmptyFullCodeNameFilter
        {
            get
            {
                return _emptyFullCodeNameFilter;
            }
            set
            {
                _emptyFullCodeNameFilter = value;
				NotifyPropertyChanged(x => EmptyFullCodeNameFilter);
                FilterData();
                
            }
        }	

 

		private string _emptyFullDescriptionFilter;
        public string EmptyFullDescriptionFilter
        {
            get
            {
                return _emptyFullDescriptionFilter;
            }
            set
            {
                _emptyFullDescriptionFilter = value;
				NotifyPropertyChanged(x => EmptyFullDescriptionFilter);
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

			EmptyFullCodes.Refresh();
			NotifyPropertyChanged(x => this.EmptyFullCodes);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(EmptyFullCodeNameFilter) == false)
						res.Append(" && " + string.Format("EmptyFullCodeName.Contains(\"{0}\")",  EmptyFullCodeNameFilter));						
 

									if(string.IsNullOrEmpty(EmptyFullDescriptionFilter) == false)
						res.Append(" && " + string.Format("EmptyFullDescription.Contains(\"{0}\")",  EmptyFullDescriptionFilter));						
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<EmptyFullCode> lst = null;
            using (var ctx = new EmptyFullCodeRepository())
            {
                lst = await ctx.GetEmptyFullCodesByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<EmptyFullCodeExcelLine, List<EmptyFullCodeExcelLine>>
            {
                dataToPrint = lst.Select(x => new EmptyFullCodeExcelLine
                {
 
                    EmptyFullCodeName = x.EmptyFullCodeName ,
                    
 
                    EmptyFullDescription = x.EmptyFullDescription 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class EmptyFullCodeExcelLine
        {
		 
                    public string EmptyFullCodeName { get; set; } 
                    
 
                    public string EmptyFullDescription { get; set; } 
                    
        }

		
    }
}
		
