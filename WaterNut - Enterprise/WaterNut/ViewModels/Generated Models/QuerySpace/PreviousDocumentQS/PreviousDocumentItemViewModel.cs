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
    
	public partial class PreviousDocumentItemViewModel_AutoGen : ViewModelBase<PreviousDocumentItemViewModel_AutoGen>
	{

       private static readonly PreviousDocumentItemViewModel_AutoGen instance;
       static PreviousDocumentItemViewModel_AutoGen()
        {
            instance = new PreviousDocumentItemViewModel_AutoGen();
        }

       public static PreviousDocumentItemViewModel_AutoGen Instance
        {
            get { return instance; }
        }

       private readonly object lockObject = new object();
  
  

        public PreviousDocumentItemViewModel_AutoGen()
        {
          
            RegisterToReceiveMessages<PreviousDocumentItem>(MessageToken.CurrentPreviousDocumentItemChanged, OnCurrentPreviousDocumentItemChanged);
            RegisterToReceiveMessages(MessageToken.PreviousDocumentItemsChanged, OnPreviousDocumentItemsChanged);
			RegisterToReceiveMessages(MessageToken.PreviousDocumentItemsFilterExpressionChanged, OnPreviousDocumentItemsFilterExpressionChanged);

 
			RegisterToReceiveMessages<PreviousDocument>(MessageToken.CurrentPreviousDocumentChanged, OnCurrentPreviousDocumentChanged);

 			// Recieve messages for Core Current Entities Changed
 

			PreviousDocumentItems = new VirtualList<PreviousDocumentItem>(vloader);
			PreviousDocumentItems.LoadingStateChanged += PreviousDocumentItems_LoadingStateChanged;
            BindingOperations.EnableCollectionSynchronization(PreviousDocumentItems, lockObject);
			
            OnCreated();        
            OnTotals();
        }

        partial void OnCreated();
        partial void OnTotals();

		private VirtualList<PreviousDocumentItem> _PreviousDocumentItems = null;
        public VirtualList<PreviousDocumentItem> PreviousDocumentItems
        {
            get
            {
                return _PreviousDocumentItems;
            }
            set
            {
                _PreviousDocumentItems = value;
            }
        }

		 private void OnPreviousDocumentItemsFilterExpressionChanged(object sender, NotificationEventArgs e)
        {
			PreviousDocumentItems.Refresh();
            SelectedPreviousDocumentItems.Clear();
            NotifyPropertyChanged(x => SelectedPreviousDocumentItems);
            BeginSendMessage(MessageToken.SelectedPreviousDocumentItemsChanged, new NotificationEventArgs(MessageToken.SelectedPreviousDocumentItemsChanged));
        }

		void PreviousDocumentItems_LoadingStateChanged(object sender, EventArgs e)
        {
            switch (PreviousDocumentItems.LoadingState)
            {
                case QueuedBackgroundWorkerState.Processing:
                    StatusModel.Timer("Getting Data...");
                    break;
                case QueuedBackgroundWorkerState.Standby: 
                    StatusModel.StopStatusUpdate();
                    NotifyPropertyChanged(x => PreviousDocumentItems);
                    break;
                case QueuedBackgroundWorkerState.StoppedByError:
                    StatusModel.Error("PreviousDocumentItems | Error occured..." + PreviousDocumentItems.LastLoadingError.Message);
                    NotifyPropertyChanged(x => PreviousDocumentItems);
                    break;
            }
           
        }

		
		public readonly PreviousDocumentItemVirturalListLoader vloader = new PreviousDocumentItemVirturalListLoader();

		private ObservableCollection<PreviousDocumentItem> _selectedPreviousDocumentItems = new ObservableCollection<PreviousDocumentItem>();
        public ObservableCollection<PreviousDocumentItem> SelectedPreviousDocumentItems
        {
            get
            {
                return _selectedPreviousDocumentItems;
            }
            set
            {
                _selectedPreviousDocumentItems = value;
				BeginSendMessage(MessageToken.SelectedPreviousDocumentItemsChanged,
                                    new NotificationEventArgs(MessageToken.SelectedPreviousDocumentItemsChanged));
				 NotifyPropertyChanged(x => SelectedPreviousDocumentItems);
            }
        }

        internal void OnCurrentPreviousDocumentItemChanged(object sender, NotificationEventArgs<PreviousDocumentItem> e)
        {
            if(BaseViewModel.Instance.CurrentPreviousDocumentItem != null) BaseViewModel.Instance.CurrentPreviousDocumentItem.PropertyChanged += CurrentPreviousDocumentItem__propertyChanged;
           // NotifyPropertyChanged(x => this.CurrentPreviousDocumentItem);
        }   

            void CurrentPreviousDocumentItem__propertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
                {
                    //if (e.PropertyName == "AddPreviousDocument")
                   // {
                   //    if(PreviousDocuments.Contains(CurrentPreviousDocumentItem.PreviousDocument) == false) PreviousDocuments.Add(CurrentPreviousDocumentItem.PreviousDocument);
                    //}
                 } 
        internal void OnPreviousDocumentItemsChanged(object sender, NotificationEventArgs e)
        {
            _PreviousDocumentItems.Refresh();
			NotifyPropertyChanged(x => this.PreviousDocumentItems);
        }   


 	
		 internal void OnCurrentPreviousDocumentChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<PreviousDocument> e)
			{
			if(ViewCurrentPreviousDocument == false) return;
			if (e.Data == null || e.Data.ASYCUDA_Id == null)
                {
                    vloader.FilterExpression = "None";
                }
                else
                {
				vloader.FilterExpression = string.Format("ASYCUDA_Id == {0}", e.Data.ASYCUDA_Id.ToString());
                 }

				PreviousDocumentItems.Refresh();
				NotifyPropertyChanged(x => this.PreviousDocumentItems);
                // SendMessage(MessageToken.PreviousDocumentItemsChanged, new NotificationEventArgs(MessageToken.PreviousDocumentItemsChanged));
                			}

  			// Core Current Entities Changed
			// theorticall don't need this cuz i am inheriting from core entities baseview model so changes should flow up to here
  
// Filtering Each Field except IDs
 	
		 bool _viewCurrentPreviousDocument = true;
         public bool ViewCurrentPreviousDocument
         {
             get
             {
                 return _viewCurrentPreviousDocument;
             }
             set
             {
                 _viewCurrentPreviousDocument = value;
                 NotifyPropertyChanged(x => x.ViewCurrentPreviousDocument);
             }
         }
		public void ViewAll()
        {
			vloader.FilterExpression = "All";
			vloader.ClearNavigationExpression();
			_PreviousDocumentItems.Refresh();
			NotifyPropertyChanged(x => this.PreviousDocumentItems);
		}

		public async Task SelectAll()
        {
            IEnumerable<PreviousDocumentItem> lst = null;
            using (var ctx = new PreviousDocumentItemRepository())
            {
                lst = await ctx.GetPreviousDocumentItemsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
            SelectedPreviousDocumentItems = new ObservableCollection<PreviousDocumentItem>(lst);
        }

 

		private string _amount_deducted_from_licenceFilter;
        public string Amount_deducted_from_licenceFilter
        {
            get
            {
                return _amount_deducted_from_licenceFilter;
            }
            set
            {
                _amount_deducted_from_licenceFilter = value;
				NotifyPropertyChanged(x => Amount_deducted_from_licenceFilter);
                FilterData();
                
            }
        }	

 

		private string _licence_numberFilter;
        public string Licence_numberFilter
        {
            get
            {
                return _licence_numberFilter;
            }
            set
            {
                _licence_numberFilter = value;
				NotifyPropertyChanged(x => Licence_numberFilter);
                FilterData();
                
            }
        }	

 

		private string _free_text_1Filter;
        public string Free_text_1Filter
        {
            get
            {
                return _free_text_1Filter;
            }
            set
            {
                _free_text_1Filter = value;
				NotifyPropertyChanged(x => Free_text_1Filter);
                FilterData();
                
            }
        }	

 

		private string _free_text_2Filter;
        public string Free_text_2Filter
        {
            get
            {
                return _free_text_2Filter;
            }
            set
            {
                _free_text_2Filter = value;
				NotifyPropertyChanged(x => Free_text_2Filter);
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

 

		private Boolean? _isAssessedFilter;
        public Boolean? IsAssessedFilter
        {
            get
            {
                return _isAssessedFilter;
            }
            set
            {
                _isAssessedFilter = value;
				NotifyPropertyChanged(x => IsAssessedFilter);
                FilterData();
                
            }
        }	

 

		private Double? _dPQtyAllocatedFilter;
        public Double? DPQtyAllocatedFilter
        {
            get
            {
                return _dPQtyAllocatedFilter;
            }
            set
            {
                _dPQtyAllocatedFilter = value;
				NotifyPropertyChanged(x => DPQtyAllocatedFilter);
                FilterData();
                
            }
        }	

 

		private Double? _dFQtyAllocatedFilter;
        public Double? DFQtyAllocatedFilter
        {
            get
            {
                return _dFQtyAllocatedFilter;
            }
            set
            {
                _dFQtyAllocatedFilter = value;
				NotifyPropertyChanged(x => DFQtyAllocatedFilter);
                FilterData();
                
            }
        }	

 
		private DateTime? _startEntryTimeStampFilter = DateTime.Parse(string.Format("{0}/1/{1}", DateTime.Now.Month ,DateTime.Now.Year));
        public DateTime? StartEntryTimeStampFilter
        {
            get
            {
                return _startEntryTimeStampFilter;
            }
            set
            {
                _startEntryTimeStampFilter = value;
				NotifyPropertyChanged(x => StartEntryTimeStampFilter);
                FilterData();
                
            }
        }	

		private DateTime? _endEntryTimeStampFilter = DateTime.Parse(string.Format("{1}/{0}/{2}", DateTime.DaysInMonth( DateTime.Now.Year,DateTime.Now.Month), DateTime.Now.Month, DateTime.Now.Year));
        public DateTime? EndEntryTimeStampFilter
        {
            get
            {
                return _endEntryTimeStampFilter;
            }
            set
            {
                _endEntryTimeStampFilter = value;
				NotifyPropertyChanged(x => EndEntryTimeStampFilter);
                FilterData();
                
            }
        }
 

		private DateTime? _entryTimeStampFilter;
        public DateTime? EntryTimeStampFilter
        {
            get
            {
                return _entryTimeStampFilter;
            }
            set
            {
                _entryTimeStampFilter = value;
				NotifyPropertyChanged(x => EntryTimeStampFilter);
                FilterData();
                
            }
        }	

 

		private Boolean? _attributeOnlyAllocationFilter;
        public Boolean? AttributeOnlyAllocationFilter
        {
            get
            {
                return _attributeOnlyAllocationFilter;
            }
            set
            {
                _attributeOnlyAllocationFilter = value;
				NotifyPropertyChanged(x => AttributeOnlyAllocationFilter);
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

 

		private Boolean? _doNotEXFilter;
        public Boolean? DoNotEXFilter
        {
            get
            {
                return _doNotEXFilter;
            }
            set
            {
                _doNotEXFilter = value;
				NotifyPropertyChanged(x => DoNotEXFilter);
                FilterData();
                
            }
        }	

 

		private Double? _item_priceFilter;
        public Double? Item_priceFilter
        {
            get
            {
                return _item_priceFilter;
            }
            set
            {
                _item_priceFilter = value;
				NotifyPropertyChanged(x => Item_priceFilter);
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

 

		private Double? _dutyLiabilityFilter;
        public Double? DutyLiabilityFilter
        {
            get
            {
                return _dutyLiabilityFilter;
            }
            set
            {
                _dutyLiabilityFilter = value;
				NotifyPropertyChanged(x => DutyLiabilityFilter);
                FilterData();
                
            }
        }	

 

		private Double? _total_CIF_itmFilter;
        public Double? Total_CIF_itmFilter
        {
            get
            {
                return _total_CIF_itmFilter;
            }
            set
            {
                _total_CIF_itmFilter = value;
				NotifyPropertyChanged(x => Total_CIF_itmFilter);
                FilterData();
                
            }
        }	

 

		private Double? _freightFilter;
        public Double? FreightFilter
        {
            get
            {
                return _freightFilter;
            }
            set
            {
                _freightFilter = value;
				NotifyPropertyChanged(x => FreightFilter);
                FilterData();
                
            }
        }	

 

		private Double? _statistical_valueFilter;
        public Double? Statistical_valueFilter
        {
            get
            {
                return _statistical_valueFilter;
            }
            set
            {
                _statistical_valueFilter = value;
				NotifyPropertyChanged(x => Statistical_valueFilter);
                FilterData();
                
            }
        }	

 

		private Double? _piQuantityFilter;
        public Double? PiQuantityFilter
        {
            get
            {
                return _piQuantityFilter;
            }
            set
            {
                _piQuantityFilter = value;
				NotifyPropertyChanged(x => PiQuantityFilter);
                FilterData();
                
            }
        }	

 

		private string _description_of_goodsFilter;
        public string Description_of_goodsFilter
        {
            get
            {
                return _description_of_goodsFilter;
            }
            set
            {
                _description_of_goodsFilter = value;
				NotifyPropertyChanged(x => Description_of_goodsFilter);
                FilterData();
                
            }
        }	

 

		private string _commercial_DescriptionFilter;
        public string Commercial_DescriptionFilter
        {
            get
            {
                return _commercial_DescriptionFilter;
            }
            set
            {
                _commercial_DescriptionFilter = value;
				NotifyPropertyChanged(x => Commercial_DescriptionFilter);
                FilterData();
                
            }
        }	

 

		private string _suppplementary_unit_codeFilter;
        public string Suppplementary_unit_codeFilter
        {
            get
            {
                return _suppplementary_unit_codeFilter;
            }
            set
            {
                _suppplementary_unit_codeFilter = value;
				NotifyPropertyChanged(x => Suppplementary_unit_codeFilter);
                FilterData();
                
            }
        }	

 

		private Double? _itemQuantityFilter;
        public Double? ItemQuantityFilter
        {
            get
            {
                return _itemQuantityFilter;
            }
            set
            {
                _itemQuantityFilter = value;
				NotifyPropertyChanged(x => ItemQuantityFilter);
                FilterData();
                
            }
        }	

 

		private string _numberFilter;
        public string NumberFilter
        {
            get
            {
                return _numberFilter;
            }
            set
            {
                _numberFilter = value;
				NotifyPropertyChanged(x => NumberFilter);
                FilterData();
                
            }
        }	

 

		private string _documentTypeFilter;
        public string DocumentTypeFilter
        {
            get
            {
                return _documentTypeFilter;
            }
            set
            {
                _documentTypeFilter = value;
				NotifyPropertyChanged(x => DocumentTypeFilter);
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

			PreviousDocumentItems.Refresh();
			NotifyPropertyChanged(x => this.PreviousDocumentItems);
		}		  



		internal virtual StringBuilder GetAutoPropertyFilterString()
		{
		var res = new StringBuilder();
 

									if(string.IsNullOrEmpty(Amount_deducted_from_licenceFilter) == false)
						res.Append(" && " + string.Format("Amount_deducted_from_licence.Contains(\"{0}\")",  Amount_deducted_from_licenceFilter));						
 

									if(string.IsNullOrEmpty(Licence_numberFilter) == false)
						res.Append(" && " + string.Format("Licence_number.Contains(\"{0}\")",  Licence_numberFilter));						
 

									if(string.IsNullOrEmpty(Free_text_1Filter) == false)
						res.Append(" && " + string.Format("Free_text_1.Contains(\"{0}\")",  Free_text_1Filter));						
 

									if(string.IsNullOrEmpty(Free_text_2Filter) == false)
						res.Append(" && " + string.Format("Free_text_2.Contains(\"{0}\")",  Free_text_2Filter));						
 

					if(LineNumberFilter.HasValue)
						res.Append(" && " + string.Format("LineNumber == {0}",  LineNumberFilter.ToString()));				 

									if(IsAssessedFilter.HasValue)
						res.Append(" && " + string.Format("IsAssessed == {0}",  IsAssessedFilter));						
 

					if(DPQtyAllocatedFilter.HasValue)
						res.Append(" && " + string.Format("DPQtyAllocated == {0}",  DPQtyAllocatedFilter.ToString()));				 

					if(DFQtyAllocatedFilter.HasValue)
						res.Append(" && " + string.Format("DFQtyAllocated == {0}",  DFQtyAllocatedFilter.ToString()));				 

 

				if (Convert.ToDateTime(StartEntryTimeStampFilter).Date != DateTime.MinValue &&
		        Convert.ToDateTime(EndEntryTimeStampFilter).Date != DateTime.MinValue) res.Append(" && (");

					if (Convert.ToDateTime(StartEntryTimeStampFilter).Date != DateTime.MinValue)
						{
							if(StartEntryTimeStampFilter.HasValue)
								res.Append(
                                            (Convert.ToDateTime(EndEntryTimeStampFilter).Date != DateTime.MinValue?"":" && ") +
                                            string.Format("EntryTimeStamp >= \"{0}\"",  Convert.ToDateTime(StartEntryTimeStampFilter).Date.ToString("MM/dd/yyyy")));
						}

					if (Convert.ToDateTime(EndEntryTimeStampFilter).Date != DateTime.MinValue)
						{
							if(EndEntryTimeStampFilter.HasValue)
								res.Append(" && " + string.Format("EntryTimeStamp <= \"{0}\"",  Convert.ToDateTime(EndEntryTimeStampFilter).Date.AddHours(23).ToString("MM/dd/yyyy HH:mm:ss")));
						}

				if (Convert.ToDateTime(StartEntryTimeStampFilter).Date != DateTime.MinValue &&
		        Convert.ToDateTime(EndEntryTimeStampFilter).Date != DateTime.MinValue) res.Append(" )");

					if (Convert.ToDateTime(_entryTimeStampFilter).Date != DateTime.MinValue)
						{
							if(EntryTimeStampFilter.HasValue)
								res.Append(" && " + string.Format("EntryTimeStamp == \"{0}\"",  Convert.ToDateTime(EntryTimeStampFilter).Date.ToString("MM/dd/yyyy")));
						}
				 

									if(AttributeOnlyAllocationFilter.HasValue)
						res.Append(" && " + string.Format("AttributeOnlyAllocation == {0}",  AttributeOnlyAllocationFilter));						
 

									if(DoNotAllocateFilter.HasValue)
						res.Append(" && " + string.Format("DoNotAllocate == {0}",  DoNotAllocateFilter));						
 

									if(DoNotEXFilter.HasValue)
						res.Append(" && " + string.Format("DoNotEX == {0}",  DoNotEXFilter));						
 

					if(Item_priceFilter.HasValue)
						res.Append(" && " + string.Format("Item_price == {0}",  Item_priceFilter.ToString()));				 

									if(string.IsNullOrEmpty(ItemNumberFilter) == false)
						res.Append(" && " + string.Format("ItemNumber.Contains(\"{0}\")",  ItemNumberFilter));						
 

									if(string.IsNullOrEmpty(TariffCodeFilter) == false)
						res.Append(" && " + string.Format("TariffCode.Contains(\"{0}\")",  TariffCodeFilter));						
 

					if(DutyLiabilityFilter.HasValue)
						res.Append(" && " + string.Format("DutyLiability == {0}",  DutyLiabilityFilter.ToString()));				 

					if(Total_CIF_itmFilter.HasValue)
						res.Append(" && " + string.Format("Total_CIF_itm == {0}",  Total_CIF_itmFilter.ToString()));				 

					if(FreightFilter.HasValue)
						res.Append(" && " + string.Format("Freight == {0}",  FreightFilter.ToString()));				 

					if(Statistical_valueFilter.HasValue)
						res.Append(" && " + string.Format("Statistical_value == {0}",  Statistical_valueFilter.ToString()));				 

					if(PiQuantityFilter.HasValue)
						res.Append(" && " + string.Format("PiQuantity == {0}",  PiQuantityFilter.ToString()));				 

									if(string.IsNullOrEmpty(Description_of_goodsFilter) == false)
						res.Append(" && " + string.Format("Description_of_goods.Contains(\"{0}\")",  Description_of_goodsFilter));						
 

									if(string.IsNullOrEmpty(Commercial_DescriptionFilter) == false)
						res.Append(" && " + string.Format("Commercial_Description.Contains(\"{0}\")",  Commercial_DescriptionFilter));						
 

									if(string.IsNullOrEmpty(Suppplementary_unit_codeFilter) == false)
						res.Append(" && " + string.Format("Suppplementary_unit_code.Contains(\"{0}\")",  Suppplementary_unit_codeFilter));						
 

					if(ItemQuantityFilter.HasValue)
						res.Append(" && " + string.Format("ItemQuantity == {0}",  ItemQuantityFilter.ToString()));				 

									if(string.IsNullOrEmpty(NumberFilter) == false)
						res.Append(" && " + string.Format("Number.Contains(\"{0}\")",  NumberFilter));						
 

									if(string.IsNullOrEmpty(DocumentTypeFilter) == false)
						res.Append(" && " + string.Format("DocumentType.Contains(\"{0}\")",  DocumentTypeFilter));						
			return res.ToString().StartsWith(" &&") || res.Length == 0 ? res:  res.Insert(0," && ");		
		}

// Send to Excel Implementation


        public async Task Send2Excel()
        {
			IEnumerable<PreviousDocumentItem> lst = null;
            using (var ctx = new PreviousDocumentItemRepository())
            {
                lst = await ctx.GetPreviousDocumentItemsByExpressionNav(vloader.FilterExpression, vloader.NavigationExpression).ConfigureAwait(continueOnCapturedContext: false);
            }
             if (lst == null || !lst.Any()) 
              {
                   MessageBox.Show("No Data to Send to Excel");
                   return;
               }
            var s = new ExportToExcel<PreviousDocumentItemExcelLine, List<PreviousDocumentItemExcelLine>>
            {
                dataToPrint = lst.Select(x => new PreviousDocumentItemExcelLine
                {
 
                    Amount_deducted_from_licence = x.Amount_deducted_from_licence ,
                    
 
                    Licence_number = x.Licence_number ,
                    
 
                    Free_text_1 = x.Free_text_1 ,
                    
 
                    Free_text_2 = x.Free_text_2 ,
                    
 
                    LineNumber = x.LineNumber ,
                    
 
                    IsAssessed = x.IsAssessed ,
                    
 
                    DPQtyAllocated = x.DPQtyAllocated ,
                    
 
                    DFQtyAllocated = x.DFQtyAllocated ,
                    
 
                    EntryTimeStamp = x.EntryTimeStamp ,
                    
 
                    AttributeOnlyAllocation = x.AttributeOnlyAllocation ,
                    
 
                    DoNotAllocate = x.DoNotAllocate ,
                    
 
                    DoNotEX = x.DoNotEX ,
                    
 
                    Item_price = x.Item_price ,
                    
 
                    ItemNumber = x.ItemNumber ,
                    
 
                    TariffCode = x.TariffCode ,
                    
 
                    DutyLiability = x.DutyLiability ,
                    
 
                    Total_CIF_itm = x.Total_CIF_itm ,
                    
 
                    Freight = x.Freight ,
                    
 
                    Statistical_value = x.Statistical_value ,
                    
 
                    PiQuantity = x.PiQuantity ,
                    
 
                    Description_of_goods = x.Description_of_goods ,
                    
 
                    Commercial_Description = x.Commercial_Description ,
                    
 
                    Suppplementary_unit_code = x.Suppplementary_unit_code ,
                    
 
                    ItemQuantity = x.ItemQuantity ,
                    
 
                    Number = x.Number ,
                    
 
                    DocumentType = x.DocumentType 
                    
                }).ToList()
            };
            using (var sta = new StaTaskScheduler(numberOfThreads: 1))
            {
                await Task.Factory.StartNew(s.GenerateReport, CancellationToken.None, TaskCreationOptions.None, sta).ConfigureAwait(false);
            }
        }

        public class PreviousDocumentItemExcelLine
        {
		 
                    public string Amount_deducted_from_licence { get; set; } 
                    
 
                    public string Licence_number { get; set; } 
                    
 
                    public string Free_text_1 { get; set; } 
                    
 
                    public string Free_text_2 { get; set; } 
                    
 
                    public int LineNumber { get; set; } 
                    
 
                    public Nullable<bool> IsAssessed { get; set; } 
                    
 
                    public double DPQtyAllocated { get; set; } 
                    
 
                    public double DFQtyAllocated { get; set; } 
                    
 
                    public Nullable<System.DateTime> EntryTimeStamp { get; set; } 
                    
 
                    public Nullable<bool> AttributeOnlyAllocation { get; set; } 
                    
 
                    public Nullable<bool> DoNotAllocate { get; set; } 
                    
 
                    public Nullable<bool> DoNotEX { get; set; } 
                    
 
                    public Nullable<double> Item_price { get; set; } 
                    
 
                    public string ItemNumber { get; set; } 
                    
 
                    public string TariffCode { get; set; } 
                    
 
                    public Nullable<double> DutyLiability { get; set; } 
                    
 
                    public Nullable<double> Total_CIF_itm { get; set; } 
                    
 
                    public Nullable<double> Freight { get; set; } 
                    
 
                    public Nullable<double> Statistical_value { get; set; } 
                    
 
                    public Nullable<double> PiQuantity { get; set; } 
                    
 
                    public string Description_of_goods { get; set; } 
                    
 
                    public string Commercial_Description { get; set; } 
                    
 
                    public string Suppplementary_unit_code { get; set; } 
                    
 
                    public Nullable<double> ItemQuantity { get; set; } 
                    
 
                    public string Number { get; set; } 
                    
 
                    public string DocumentType { get; set; } 
                    
        }

		
    }
}
		
