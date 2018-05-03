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

using PreviousDocumentQS.Client.Entities;
using PreviousDocumentQS.Client.Repositories;
//using WaterNut.Client.Repositories;
        
using CoreEntities.Client.Entities;


namespace WaterNut.QuerySpace.PreviousDocumentQS.ViewModels
{
    
	public partial class PreviousItemsExViewModel_AutoGen : ViewModelBase<PreviousItemsExViewModel_AutoGen>
	{

       private static readonly PreviousItemsExViewModel_AutoGen instance;
       static PreviousItemsExViewModel_AutoGen()
        {
            instance = new PreviousItemsExViewModel_AutoGen();
        }

       public static PreviousItemsExViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public PreviousItemsExViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<PreviousItemsEx>(MessageToken.CurrentPreviousItemsExChanged, OnCurrentPreviousItemsExChanged);
            RegisterToReceiveMessages(MessageToken.PreviousItemsExesChanged, OnPreviousItemsExesChanged);
			RegisterToReceiveMessages(MessageToken.PreviousItemsExesFilterExpressionChanged, OnPreviousItemsExesFilterExpressionChanged);

 
			RegisterToReceiveMessages<PreviousDocumentItem>(MessageToken.CurrentPreviousDocumentItemChanged, OnCurrentPreviousDocumentItemChanged);
 
			RegisterToReceiveMessages<PreviousDocumentItem>(MessageToken.CurrentPreviousDocumentItemChanged, OnCurrentAsycudaDocumentItemChanged);

 			// Recieve messages for Core Current Entities Changed
 

			PreviousItemsExes = new VirtualList<PreviousItemsEx>(vloader);
			PreviousItemsExes.LoadingStateChanged += PreviousItemsExes_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(PreviousItemsExes, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<PreviousItemsEx> _PreviousItemsExes = null;
        public VirtualList<PreviousItemsEx> PreviousItemsExes
        {
            get
            {
                return _PreviousItemsExes;
            }
            set
            {
                _PreviousItemsExes = value;
            }
        }

		 private void OnPreviousItemsExesFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			PreviousItemsExes.Refresh();
            SelectedPreviousItemsExes.Clear();
            NotifyPropertyChanged(x => SelectedPreviousItemsExes);
            BeginSendMessage(MessageToken.SelectedPreviousItemsExesChanged, new NotificationEventArgs(MessageToken.SelectedPreviousItemsExesChanged));
        }

		void PreviousItemsExes_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (PreviousItemsExes.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => PreviousItemsExes);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("PreviousItemsExes | Error occured..." + PreviousItemsExes.LastLoadingError.Message);
                    NotifyPropertyChanged(x => PreviousItemsExes);
                    break;
            }
           
        }

		
		public readonly PreviousItemsExVirturalListLoader vloader = new PreviousItemsExVirturalListLoader();

		private ObservableCollection<PreviousItemsEx> _selectedPreviousItemsExes = new ObservableCollection<PreviousItemsEx>();
        public ObservableCollection<PreviousItemsEx> SelectedPreviousItemsExes
        {
            get
            {
                return _selectedPreviousItemsExes;
            }
            set
            {
                _selectedPreviousItemsExes = value;
				BeginSendMessage(MessageToken.SelectedPreviousItemsExesChanged,
                                    new NotificationEventArgs(MessageToken.SelectedPreviousItemsExesChanged));
				 NotifyPropertyChanged(x => SelectedPreviousItemsExes);
            }
        }

        internal void OnCurrentPreviousItemsExChanged(object sender, NotificationEventArgs<PreviousItemsEx> e)
        {
            if(BaseViewModel.Instance.CurrentPreviousItemsEx != null) BaseViewModel.Instance.CurrentPreviousItemsEx.PropertyChanged += CurrentPreviousItemsEx__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentPreviousItemsEx);
        }   

            void CurrentPreviousItemsEx__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                    //if (e.PropertyName == "AddPreviousDocumentItem")
                   // {
                   //    if(PreviousDocumentItems.Contains(CurrentPreviousItemsEx.PreviousDocumentItem) == false) PreviousDocumentItems.Add(CurrentPreviousItemsEx.PreviousDocumentItem);
                    //}
                    //if (e.PropertyName == "AddAsycudaDocumentItem")
                   // {
                   //    if(PreviousDocumentItems.Contains(CurrentPreviousItemsEx.AsycudaDocumentItem) == false) PreviousDocumentItems.Add(CurrentPreviousItemsEx.AsycudaDocumentItem);
                    //}
                 } 
        internal void OnPreviousItemsExesChanged(object sender, NotificationEventArgs e)
        {
            _PreviousItemsExes.Refresh();
			NotifyPropertyChanged(x => this.PreviousItemsExes);
        }   


 	
		 internal void OnCurrentPreviousDocumentItemChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<PreviousDocumentItem> e)
			{
			if(ViewCurrentPreviousDocumentItem == false) return;
			if (e.Data == null || e.Data.Item_Id == null)
                {
                    vloader.FilterExpression = "None";
                }
                else
                {
				vloader.FilterExpression = string.Format("PreviousDocumentItemId == {0}", e.Data.Item_Id.ToString());
                 }

				PreviousItemsExes.Refresh();
				NotifyPropertyChanged(x => this.PreviousItemsExes);
                // SendMessage(MessageToken.PreviousItemsExesChanged, new NotificationEventArgs(MessageToken.PreviousItemsExesChanged));
                			}
	
		 internal void OnCurrentAsycudaDocumentItemChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<PreviousDocumentItem> e)
			{
			if(ViewCurrentAsycudaDocumentItem == false) return;
			if (e.Data == null || e.Data.Item_Id == null)
                {
                    vloader.FilterExpression = "None";
                }
                else
                {
				vloader.FilterExpression = string.Format("AsycudaDocumentItemId == {0}", e.Data.Item_Id.ToString());
                 }

				PreviousItemsExes.Refresh();
				NotifyPropertyChanged(x => this.PreviousItemsExes);
                // SendMessage(MessageToken.PreviousItemsExesChanged, new NotificationEventArgs(MessageToken.PreviousItemsExesChanged));
                			}

  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
 	
		 bool _viewCurrentPreviousDocumentItem = true;
         public bool ViewCurrentPreviousDocumentItem
         {
             get
             {
                 return _viewCurrentPreviousDocumentItem;
             }
             set
             {
                 _viewCurrentPreviousDocumentItem = value;
                 NotifyPropertyChanged(x => x.ViewCurrentPreviousDocumentItem);
             }
         }
 	
		 bool _viewCurrentAsycudaDocumentItem = true;
         public bool ViewCurrentAsycudaDocumentItem
         {
             get
             {
                 return _viewCurrentAsycudaDocumentItem;
             }
             set
             {
                 _viewCurrentAsycudaDocumentItem = value;
                 NotifyPropertyChanged(x => x.ViewCurrentAsycudaDocumentItem);
             }
         }
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_PreviousItemsExes.Refresh();
			NotifyPropertyChanged(x => this.PreviousItemsExes);
		}

		public async Task SelectAll()
        {
            IEnumerable<PreviousItemsEx> lst = null;
            using (var ctx = new PreviousItemsExRepository())
            {
                lst = await ctx.GetPreviousItemsExesByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedPreviousItemsExes = new ObservableCollection<PreviousItemsEx>(lst);
        }

 

		private string _packages_numberFilter;
        public string Packages_numberFilter
        {
            get
            {
                return _packages_numberFilter;
            }
            set
            {
                _packages_numberFilter = value;
				NotifyPropertyChanged(x => Packages_numberFilter);
                FilterData();
                
            }
        }	

 

		private string _previous_Packages_numberFilter;
        public string Previous_Packages_numberFilter
        {
            get
            {
                return _previous_Packages_numberFilter;
            }
            set
            {
                _previous_Packages_numberFilter = value;
				NotifyPropertyChanged(x => Previous_Packages_numberFilter);
                FilterData();
                
            }
        }	

 

		private string _hs_codeFilter;
        public string Hs_codeFilter
        {
            get
            {
                return _hs_codeFilter;
            }
            set
            {
                _hs_codeFilter = value;
				NotifyPropertyChanged(x => Hs_codeFilter);
                FilterData();
                
            }
        }	

 

		private string _commodity_codeFilter;
        public string Commodity_codeFilter
        {
            get
            {
                return _commodity_codeFilter;
            }
            set
            {
                _commodity_codeFilter = value;
				NotifyPropertyChanged(x => Commodity_codeFilter);
                FilterData();
                
            }
        }	

 

		private string _previous_item_numberFilter;
        public string Previous_item_numberFilter
        {
            get
            {
                return _previous_item_numberFilter;
            }
            set
            {
                _previous_item_numberFilter = value;
				NotifyPropertyChanged(x => Previous_item_numberFilter);
                FilterData();
                
            }
        }	

 

		private string _goods_originFilter;
        public string Goods_originFilter
        {
            get
            {
                return _goods_originFilter;
            }
            set
            {
                _goods_originFilter = value;
				NotifyPropertyChanged(x => Goods_originFilter);
                FilterData();
                
            }
        }	

 

		private Double? _net_weightFilter;
        public Double? Net_weightFilter
        {
            get
            {
                return _net_weightFilter;
            }
            set
            {
                _net_weightFilter = value;
				NotifyPropertyChanged(x => Net_weightFilter);
                FilterData();
                
            }
        }	

 

		private Double? _prev_net_weightFilter;
        public Double? Prev_net_weightFilter
        {
            get
            {
                return _prev_net_weightFilter;
            }
            set
            {
                _prev_net_weightFilter = value;
				NotifyPropertyChanged(x => Prev_net_weightFilter);
                FilterData();
                
            }
        }	

 

		private string _prev_reg_serFilter;
        public string Prev_reg_serFilter
        {
            get
            {
                return _prev_reg_serFilter;
            }
            set
            {
                _prev_reg_serFilter = value;
				NotifyPropertyChanged(x => Prev_reg_serFilter);
                FilterData();
                
            }
        }	

 

		private string _prev_reg_nbrFilter;
        public string Prev_reg_nbrFilter
        {
            get
            {
                return _prev_reg_nbrFilter;
            }
            set
            {
                _prev_reg_nbrFilter = value;
				NotifyPropertyChanged(x => Prev_reg_nbrFilter);
                FilterData();
                
            }
        }	

 

		private string _prev_reg_datFilter;
        public string Prev_reg_datFilter
        {
            get
            {
                return _prev_reg_datFilter;
            }
            set
            {
                _prev_reg_datFilter = value;
				NotifyPropertyChanged(x => Prev_reg_datFilter);
                FilterData();
                
            }
        }	

 

		private string _prev_reg_cuoFilter;
        public string Prev_reg_cuoFilter
        {
            get
            {
                return _prev_reg_cuoFilter;
            }
            set
            {
                _prev_reg_cuoFilter = value;
				NotifyPropertyChanged(x => Prev_reg_cuoFilter);
                FilterData();
                
            }
        }	

 

		private Double? _suplementary_QuantityFilter;
        public Double? Suplementary_QuantityFilter
        {
            get
            {
                return _suplementary_QuantityFilter;
            }
            set
            {
                _suplementary_QuantityFilter = value;
				NotifyPropertyChanged(x => Suplementary_QuantityFilter);
                FilterData();
                
            }
        }	

 

		private Double? _preveious_suplementary_quantityFilter;
        public Double? Preveious_suplementary_quantityFilter
        {
            get
            {
                return _preveious_suplementary_quantityFilter;
            }
            set
            {
                _preveious_suplementary_quantityFilter = value;
				NotifyPropertyChanged(x => Preveious_suplementary_quantityFilter);
                FilterData();
                
            }
        }	

 

		private Double? _current_valueFilter;
        public Double? Current_valueFilter
        {
            get
            {
                return _current_valueFilter;
            }
            set
            {
                _current_valueFilter = value;
				NotifyPropertyChanged(x => Current_valueFilter);
                FilterData();
                
            }
        }	

 

		private Double? _previous_valueFilter;
        public Double? Previous_valueFilter
        {
            get
            {
                return _previous_valueFilter;
            }
            set
            {
                _previous_valueFilter = value;
				NotifyPropertyChanged(x => Previous_valueFilter);
                FilterData();
                
            }
        }	

 

		private string _current_item_numberFilter;
        public string Current_item_numberFilter
        {
            get
            {
                return _current_item_numberFilter;
            }
            set
            {
                _current_item_numberFilter = value;
				NotifyPropertyChanged(x => Current_item_numberFilter);
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

 

		private Double? _rndCurrent_ValueFilter;
        public Double? RndCurrent_ValueFilter
        {
            get
            {
                return _rndCurrent_ValueFilter;
            }
            set
            {
                _rndCurrent_ValueFilter = value;
				NotifyPropertyChanged(x => RndCurrent_ValueFilter);
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

 
		private DateTime? _startRegistrationDateFilter = DateTime.Parse(string.Format("{0}/1/{1}", DateTime.Now.Month ,DateTime.Now.Year));
        public DateTime? StartRegistrationDateFilter
        {
            get
            {
                return _startRegistrationDateFilter;
            }
            set
            {
                _startRegistrationDateFilter = value;
				NotifyPropertyChanged(x => StartRegistrationDateFilter);
                FilterData();
                
            }
        }	

		private DateTime? _endRegistrationDateFilter = DateTime.Parse(string.Format("{1}/{0}/{2}", DateTime.DaysInMonth( DateTime.Now.Year,DateTime.Now.Month), DateTime.Now.Month, DateTime.Now.Year));
        public DateTime? EndRegistrationDateFilter
        {
            get
            {
                return _endRegistrationDateFilter;
            }
            set
            {
                _endRegistrationDateFilter = value;
				NotifyPropertyChanged(x => EndRegistrationDateFilter);
                FilterData();
                
            }
        }
 

		private DateTime? _registrationDateFilter;
        public DateTime? RegistrationDateFilter
        {
            get
            {
                return _registrationDateFilter;
            }
            set
            {
                _registrationDateFilter = value;
				NotifyPropertyChanged(x => RegistrationDateFilter);
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

			PreviousItemsExes.Refresh();
			NotifyPropertyChanged(x => this.PreviousItemsExes);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(Packages_numberFilter) == false)
						res.Append(" && " + string.Format("Packages_number.Contains(\"{0}\")",  Packages_numberFilter));						
 

									if(string.IsNullOrEmpty(Previous_Packages_numberFilter) == false)
						res.Append(" && " + string.Format("Previous_Packages_number.Contains(\"{0}\")",  Previous_Packages_numberFilter));						
 

									if(string.IsNullOrEmpty(Hs_codeFilter) == false)
						res.Append(" && " + string.Format("Hs_code.Contains(\"{0}\")",  Hs_codeFilter));						
 

									if(string.IsNullOrEmpty(Commodity_codeFilter) == false)
						res.Append(" && " + string.Format("Commodity_code.Contains(\"{0}\")",  Commodity_codeFilter));						
 

									if(string.IsNullOrEmpty(Previous_item_numberFilter) == false)
						res.Append(" && " + string.Format("Previous_item_number.Contains(\"{0}\")",  Previous_item_numberFilter));						
 

									if(string.IsNullOrEmpty(Goods_originFilter) == false)
						res.Append(" && " + string.Format("Goods_origin.Contains(\"{0}\")",  Goods_originFilter));						
 

					if(Net_weightFilter.HasValue)
						res.Append(" && " + string.Format("Net_weight == {0}",  Net_weightFilter.ToString()));				 

					if(Prev_net_weightFilter.HasValue)
						res.Append(" && " + string.Format("Prev_net_weight == {0}",  Prev_net_weightFilter.ToString()));				 

									if(string.IsNullOrEmpty(Prev_reg_serFilter) == false)
						res.Append(" && " + string.Format("Prev_reg_ser.Contains(\"{0}\")",  Prev_reg_serFilter));						
 

									if(string.IsNullOrEmpty(Prev_reg_nbrFilter) == false)
						res.Append(" && " + string.Format("Prev_reg_nbr.Contains(\"{0}\")",  Prev_reg_nbrFilter));						
 

									if(string.IsNullOrEmpty(Prev_reg_datFilter) == false)
						res.Append(" && " + string.Format("Prev_reg_dat.Contains(\"{0}\")",  Prev_reg_datFilter));						
 

									if(string.IsNullOrEmpty(Prev_reg_cuoFilter) == false)
						res.Append(" && " + string.Format("Prev_reg_cuo.Contains(\"{0}\")",  Prev_reg_cuoFilter));						
 

					if(Suplementary_QuantityFilter.HasValue)
						res.Append(" && " + string.Format("Suplementary_Quantity == {0}",  Suplementary_QuantityFilter.ToString()));				 

					if(Preveious_suplementary_quantityFilter.HasValue)
						res.Append(" && " + string.Format("Preveious_suplementary_quantity == {0}",  Preveious_suplementary_quantityFilter.ToString()));				 

					if(Current_valueFilter.HasValue)
						res.Append(" && " + string.Format("Current_value == {0}",  Current_valueFilter.ToString()));				 

					if(Previous_valueFilter.HasValue)
						res.Append(" && " + string.Format("Previous_value == {0}",  Previous_valueFilter.ToString()));				 

									if(string.IsNullOrEmpty(Current_item_numberFilter) == false)
						res.Append(" && " + string.Format("Current_item_number.Contains(\"{0}\")",  Current_item_numberFilter));						
 

					if(QtyAllocatedFilter.HasValue)
						res.Append(" && " + string.Format("QtyAllocated == {0}",  QtyAllocatedFilter.ToString()));				 

					if(RndCurrent_ValueFilter.HasValue)
						res.Append(" && " + string.Format("RndCurrent_Value == {0}",  RndCurrent_ValueFilter.ToString()));				 

									if(string.IsNullOrEmpty(CNumberFilter) == false)
						res.Append(" && " + string.Format("CNumber.Contains(\"{0}\")",  CNumberFilter));						
 

 

				if (Convert.ToDateTime(StartRegistrationDateFilter).Date != DateTime.MinValue &&
		        Convert.ToDateTime(EndRegistrationDateFilter).Date != DateTime.MinValue) res.Append(" && (");

					if (Convert.ToDateTime(StartRegistrationDateFilter).Date != DateTime.MinValue)
						{
							if(StartRegistrationDateFilter.HasValue)
								res.Append(
                                            (Convert.ToDateTime(EndRegistrationDateFilter).Date != DateTime.MinValue?"":" && ") +
                                            string.Format("RegistrationDate >= \"{0}\"",  Convert.ToDateTime(StartRegistrationDateFilter).Date.ToString("MM/dd/yyyy")));
						}

					if (Convert.ToDateTime(EndRegistrationDateFilter).Date != DateTime.MinValue)
						{
							if(EndRegistrationDateFilter.HasValue)
								res.Append(" && " + string.Format("RegistrationDate <= \"{0}\"",  Convert.ToDateTime(EndRegistrationDateFilter).Date.AddHours(23).ToString("MM/dd/yyyy")));
						}

				if (Convert.ToDateTime(StartRegistrationDateFilter).Date != DateTime.MinValue &&
		        Convert.ToDateTime(EndRegistrationDateFilter).Date != DateTime.MinValue) res.Append(" )");

					if (Convert.ToDateTime(_registrationDateFilter).Date != DateTime.MinValue)
						{
							if(RegistrationDateFilter.HasValue)
								res.Append(" && " + string.Format("RegistrationDate == \"{0}\"",  Convert.ToDateTime(RegistrationDateFilter).Date.ToString("MM/dd/yyyy")));
						}
							return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<PreviousItemsEx> lst = null;
            using (var ctx = new PreviousItemsExRepository())
            {
                lst = await ctx.GetPreviousItemsExesByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<PreviousItemsExExcelLine, List<PreviousItemsExExcelLine>>
            {
                dataToPrint = lst.Select(x => new PreviousItemsExExcelLine
                {
 
                    Packages_number = x.Packages_number ,
                    
 
                    Previous_Packages_number = x.Previous_Packages_number ,
                    
 
                    Hs_code = x.Hs_code ,
                    
 
                    Commodity_code = x.Commodity_code ,
                    
 
                    Previous_item_number = x.Previous_item_number ,
                    
 
                    Goods_origin = x.Goods_origin ,
                    
 
                    Net_weight = x.Net_weight ,
                    
 
                    Prev_net_weight = x.Prev_net_weight ,
                    
 
                    Prev_reg_ser = x.Prev_reg_ser ,
                    
 
                    Prev_reg_nbr = x.Prev_reg_nbr ,
                    
 
                    Prev_reg_dat = x.Prev_reg_dat ,
                    
 
                    Prev_reg_cuo = x.Prev_reg_cuo ,
                    
 
                    Suplementary_Quantity = x.Suplementary_Quantity ,
                    
 
                    Preveious_suplementary_quantity = x.Preveious_suplementary_quantity ,
                    
 
                    Current_value = x.Current_value ,
                    
 
                    Previous_value = x.Previous_value ,
                    
 
                    Current_item_number = x.Current_item_number ,
                    
 
                    QtyAllocated = x.QtyAllocated ,
                    
 
                    RndCurrent_Value = x.RndCurrent_Value ,
                    
 
                    CNumber = x.CNumber ,
                    
 
                    RegistrationDate = x.RegistrationDate,
                    
                    ReferenceNumber = x.ReferenceNumber
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class PreviousItemsExExcelLine
        {
		 
                    public string Packages_number { get; set; } 
                    
 
                    public string Previous_Packages_number { get; set; } 
                    
 
                    public string Hs_code { get; set; } 
                    
 
                    public string Commodity_code { get; set; } 
                    
 
                    public string Previous_item_number { get; set; } 
                    
 
                    public string Goods_origin { get; set; } 
                    
 
                    public double Net_weight { get; set; } 
                    
 
                    public double Prev_net_weight { get; set; } 
                    
 
                    public string Prev_reg_ser { get; set; } 
                    
 
                    public string Prev_reg_nbr { get; set; } 
                    
 
                    public string Prev_reg_dat { get; set; } 
                    
 
                    public string Prev_reg_cuo { get; set; } 
                    
 
                    public double Suplementary_Quantity { get; set; } 
                    
 
                    public double Preveious_suplementary_quantity { get; set; } 
                    
 
                    public double Current_value { get; set; } 
                    
 
                    public double Previous_value { get; set; } 
                    
 
                    public string Current_item_number { get; set; } 
                    
 
                    public double QtyAllocated { get; set; } 
                    
 
                    public double RndCurrent_Value { get; set; } 
                    
 
                    public string CNumber { get; set; } 
                    
 
                    public Nullable<System.DateTime> RegistrationDate { get; set; }
            public string ReferenceNumber { get; set; }
        }

		
    }
}
		
