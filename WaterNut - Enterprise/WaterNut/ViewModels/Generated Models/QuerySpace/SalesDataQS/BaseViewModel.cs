﻿// <autogenerated>
//   This file was generated by T4 code generator AllQuerySpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Linq;
using SimpleMvvmToolkit;
using System;
using System.ComponentModel;
using Core.Common.Data;
using Core.Common.UI.DataVirtualization;
using SalesDataQS.Client.Entities;
using SalesDataQS.Client.Repositories;
//using WaterNut.Client.Repositories;
using CoreEntities.Client.Entities;



namespace WaterNut.QuerySpace.SalesDataQS.ViewModels
{
	 public partial class BaseViewModel : ViewModelBase<BaseViewModel> // CoreEntities.ViewModels.BaseViewModel
	{
         private static readonly BaseViewModel _instance;
         static BaseViewModel()
        {
            _instance = new BaseViewModel();
             Initialization = InitializationAsync();
        }

        public static BaseViewModel Instance
        {
            get { return _instance; }
        }

        public static Task Initialization {get; private set; }
        private static async Task InitializationAsync()
        {
                    }

 

        
        class SalesDataQSOnCreated: BaseViewModel
        {
           // Load Repository
                public SalesDataQSOnCreated()
                    {
                        try
                            {
                                 if (System.ComponentModel.LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
 

                        RegisterToReceiveMessages<string>(MessageToken.CurrentAsycudaDocumentEntryDataIDChanged, OnCurrentAsycudaDocumentEntryDataIDChanged);
                        RegisterToReceiveMessages<string>(MessageToken.CurrentAsycudaDocumentSetEntryDataIDChanged, OnCurrentAsycudaDocumentSetEntryDataIDChanged);
                        RegisterToReceiveMessages<string>(MessageToken.CurrentAsycudaDocumentSetEntryDataDetailsIDChanged, OnCurrentAsycudaDocumentSetEntryDataDetailsIDChanged);
                        RegisterToReceiveMessages<string>(MessageToken.CurrentSalesDataIDChanged, OnCurrentSalesDataIDChanged);
                        RegisterToReceiveMessages<string>(MessageToken.CurrentSalesDataAllocationsIDChanged, OnCurrentSalesDataAllocationsIDChanged);
                        RegisterToReceiveMessages<string>(MessageToken.CurrentSalesDataDetailIDChanged, OnCurrentSalesDataDetailIDChanged);
       

			// Recieve messages for Current Object Changed
                        RegisterToReceiveMessages<AsycudaDocumentEntryData>(MessageToken.CurrentAsycudaDocumentEntryDataChanged, OnCurrentAsycudaDocumentEntryDataChanged);
                        RegisterToReceiveMessages<AsycudaDocumentSetEntryData>(MessageToken.CurrentAsycudaDocumentSetEntryDataChanged, OnCurrentAsycudaDocumentSetEntryDataChanged);
                        RegisterToReceiveMessages<AsycudaDocumentSetEntryDataDetails>(MessageToken.CurrentAsycudaDocumentSetEntryDataDetailsChanged, OnCurrentAsycudaDocumentSetEntryDataDetailsChanged);
                        RegisterToReceiveMessages<SalesData>(MessageToken.CurrentSalesDataChanged, OnCurrentSalesDataChanged);
                        RegisterToReceiveMessages<SalesDataAllocations>(MessageToken.CurrentSalesDataAllocationsChanged, OnCurrentSalesDataAllocationsChanged);
                        RegisterToReceiveMessages<SalesDataDetail>(MessageToken.CurrentSalesDataDetailChanged, OnCurrentSalesDataDetailChanged);
    
                // Receive messages for cached collections for purpose of refreshing cache
             

              }
            catch (Exception)
            {
                throw;
            }  
            }

        }







                        internal async void OnCurrentAsycudaDocumentEntryDataIDChanged(object sender, NotificationEventArgs<string> e)
                        {
                            using (AsycudaDocumentEntryDataRepository ctx = new AsycudaDocumentEntryDataRepository())
                            {
                                CurrentAsycudaDocumentEntryData = await ctx.GetAsycudaDocumentEntryData(e.Data).ConfigureAwait(continueOnCapturedContext: false);
                            }
                            NotifyPropertyChanged(m => CurrentAsycudaDocumentEntryData);
                        }

                        private  string _currentAsycudaDocumentEntryDataID = "";
                        public string CurrentAsycudaDocumentEntryDataID
                        {
                            get
                            {
                                return _currentAsycudaDocumentEntryDataID;
                            }
                            set
                            {
                                if (_currentAsycudaDocumentEntryDataID != value)
                                {
                                    _currentAsycudaDocumentEntryDataID = value;
                                    if (!string.IsNullOrEmpty(_currentAsycudaDocumentEntryDataID)) BeginSendMessage(MessageToken.CurrentAsycudaDocumentEntryDataIDChanged,
                                                     new NotificationEventArgs<string>(MessageToken.CurrentAsycudaDocumentEntryDataIDChanged, _currentAsycudaDocumentEntryDataID));
                                    NotifyPropertyChanged(x => this.CurrentAsycudaDocumentEntryDataID);  
                                }
                            }
                        }
                        internal async void OnCurrentAsycudaDocumentSetEntryDataIDChanged(object sender, NotificationEventArgs<string> e)
                        {
                            using (AsycudaDocumentSetEntryDataRepository ctx = new AsycudaDocumentSetEntryDataRepository())
                            {
                                CurrentAsycudaDocumentSetEntryData = await ctx.GetAsycudaDocumentSetEntryData(e.Data).ConfigureAwait(continueOnCapturedContext: false);
                            }
                            NotifyPropertyChanged(m => CurrentAsycudaDocumentSetEntryData);
                        }

                        private  string _currentAsycudaDocumentSetEntryDataID = "";
                        public string CurrentAsycudaDocumentSetEntryDataID
                        {
                            get
                            {
                                return _currentAsycudaDocumentSetEntryDataID;
                            }
                            set
                            {
                                if (_currentAsycudaDocumentSetEntryDataID != value)
                                {
                                    _currentAsycudaDocumentSetEntryDataID = value;
                                    if (!string.IsNullOrEmpty(_currentAsycudaDocumentSetEntryDataID)) BeginSendMessage(MessageToken.CurrentAsycudaDocumentSetEntryDataIDChanged,
                                                     new NotificationEventArgs<string>(MessageToken.CurrentAsycudaDocumentSetEntryDataIDChanged, _currentAsycudaDocumentSetEntryDataID));
                                    NotifyPropertyChanged(x => this.CurrentAsycudaDocumentSetEntryDataID);  
                                }
                            }
                        }
                        internal async void OnCurrentAsycudaDocumentSetEntryDataDetailsIDChanged(object sender, NotificationEventArgs<string> e)
                        {
                            using (AsycudaDocumentSetEntryDataDetailsRepository ctx = new AsycudaDocumentSetEntryDataDetailsRepository())
                            {
                                CurrentAsycudaDocumentSetEntryDataDetails = await ctx.GetAsycudaDocumentSetEntryDataDetails(e.Data).ConfigureAwait(continueOnCapturedContext: false);
                            }
                            NotifyPropertyChanged(m => CurrentAsycudaDocumentSetEntryDataDetails);
                        }

                        private  string _currentAsycudaDocumentSetEntryDataDetailsID = "";
                        public string CurrentAsycudaDocumentSetEntryDataDetailsID
                        {
                            get
                            {
                                return _currentAsycudaDocumentSetEntryDataDetailsID;
                            }
                            set
                            {
                                if (_currentAsycudaDocumentSetEntryDataDetailsID != value)
                                {
                                    _currentAsycudaDocumentSetEntryDataDetailsID = value;
                                    if (!string.IsNullOrEmpty(_currentAsycudaDocumentSetEntryDataDetailsID)) BeginSendMessage(MessageToken.CurrentAsycudaDocumentSetEntryDataDetailsIDChanged,
                                                     new NotificationEventArgs<string>(MessageToken.CurrentAsycudaDocumentSetEntryDataDetailsIDChanged, _currentAsycudaDocumentSetEntryDataDetailsID));
                                    NotifyPropertyChanged(x => this.CurrentAsycudaDocumentSetEntryDataDetailsID);  
                                }
                            }
                        }
                        internal async void OnCurrentSalesDataIDChanged(object sender, NotificationEventArgs<string> e)
                        {
                            using (SalesDataRepository ctx = new SalesDataRepository())
                            {
                                CurrentSalesData = await ctx.GetSalesData(e.Data).ConfigureAwait(continueOnCapturedContext: false);
                            }
                            NotifyPropertyChanged(m => CurrentSalesData);
                        }

                        private  string _currentSalesDataID = "";
                        public string CurrentSalesDataID
                        {
                            get
                            {
                                return _currentSalesDataID;
                            }
                            set
                            {
                                if (_currentSalesDataID != value)
                                {
                                    _currentSalesDataID = value;
                                    if (!string.IsNullOrEmpty(_currentSalesDataID)) BeginSendMessage(MessageToken.CurrentSalesDataIDChanged,
                                                     new NotificationEventArgs<string>(MessageToken.CurrentSalesDataIDChanged, _currentSalesDataID));
                                    NotifyPropertyChanged(x => this.CurrentSalesDataID);  
                                }
                            }
                        }
                        internal async void OnCurrentSalesDataAllocationsIDChanged(object sender, NotificationEventArgs<string> e)
                        {
                            using (SalesDataAllocationsRepository ctx = new SalesDataAllocationsRepository())
                            {
                                CurrentSalesDataAllocations = await ctx.GetSalesDataAllocations(e.Data).ConfigureAwait(continueOnCapturedContext: false);
                            }
                            NotifyPropertyChanged(m => CurrentSalesDataAllocations);
                        }

                        private  string _currentSalesDataAllocationsID = "";
                        public string CurrentSalesDataAllocationsID
                        {
                            get
                            {
                                return _currentSalesDataAllocationsID;
                            }
                            set
                            {
                                if (_currentSalesDataAllocationsID != value)
                                {
                                    _currentSalesDataAllocationsID = value;
                                    if (!string.IsNullOrEmpty(_currentSalesDataAllocationsID)) BeginSendMessage(MessageToken.CurrentSalesDataAllocationsIDChanged,
                                                     new NotificationEventArgs<string>(MessageToken.CurrentSalesDataAllocationsIDChanged, _currentSalesDataAllocationsID));
                                    NotifyPropertyChanged(x => this.CurrentSalesDataAllocationsID);  
                                }
                            }
                        }
                        internal async void OnCurrentSalesDataDetailIDChanged(object sender, NotificationEventArgs<string> e)
                        {
                            using (SalesDataDetailRepository ctx = new SalesDataDetailRepository())
                            {
                                CurrentSalesDataDetail = await ctx.GetSalesDataDetail(e.Data).ConfigureAwait(continueOnCapturedContext: false);
                            }
                            NotifyPropertyChanged(m => CurrentSalesDataDetail);
                        }

                        private  string _currentSalesDataDetailID = "";
                        public string CurrentSalesDataDetailID
                        {
                            get
                            {
                                return _currentSalesDataDetailID;
                            }
                            set
                            {
                                if (_currentSalesDataDetailID != value)
                                {
                                    _currentSalesDataDetailID = value;
                                    if (!string.IsNullOrEmpty(_currentSalesDataDetailID)) BeginSendMessage(MessageToken.CurrentSalesDataDetailIDChanged,
                                                     new NotificationEventArgs<string>(MessageToken.CurrentSalesDataDetailIDChanged, _currentSalesDataDetailID));
                                    NotifyPropertyChanged(x => this.CurrentSalesDataDetailID);  
                                }
                            }
                        }
 



                     
       

        internal void OnCurrentAsycudaDocumentEntryDataChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<AsycudaDocumentEntryData> e)
        {
            //CurrentAsycudaDocumentEntryData = e.Data;
            NotifyPropertyChanged(m => this.CurrentAsycudaDocumentEntryData);
        }

        private  AsycudaDocumentEntryData _currentAsycudaDocumentEntryData;
        public AsycudaDocumentEntryData CurrentAsycudaDocumentEntryData
        {
            get
            {
                return _currentAsycudaDocumentEntryData;
            }
            set
            {
                if (_currentAsycudaDocumentEntryData != value)
                {
                    _currentAsycudaDocumentEntryData = value;
                    BeginSendMessage(MessageToken.CurrentAsycudaDocumentEntryDataChanged,
                                                     new NotificationEventArgs<AsycudaDocumentEntryData>(MessageToken.CurrentAsycudaDocumentEntryDataChanged, _currentAsycudaDocumentEntryData)); 
                    NotifyPropertyChanged(x => this.CurrentAsycudaDocumentEntryData);    
                    // all current navigation properties = null
   
                }
            }
        }

		VirtualListItem<AsycudaDocumentEntryData> _vcurrentAsycudaDocumentEntryData;
        public VirtualListItem<AsycudaDocumentEntryData> VCurrentAsycudaDocumentEntryData
        {
            get
            {
                return _vcurrentAsycudaDocumentEntryData;
            }
            set
            {
                if (_vcurrentAsycudaDocumentEntryData != value)
                {
                    _vcurrentAsycudaDocumentEntryData = value;
					if(_vcurrentAsycudaDocumentEntryData != null) CurrentAsycudaDocumentEntryData = value.Data;
                    NotifyPropertyChanged(x => this.VCurrentAsycudaDocumentEntryData);                    
                }
            }
        }



                     
       

        internal void OnCurrentAsycudaDocumentSetEntryDataChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<AsycudaDocumentSetEntryData> e)
        {
            //CurrentAsycudaDocumentSetEntryData = e.Data;
            NotifyPropertyChanged(m => this.CurrentAsycudaDocumentSetEntryData);
        }

        private  AsycudaDocumentSetEntryData _currentAsycudaDocumentSetEntryData;
        public AsycudaDocumentSetEntryData CurrentAsycudaDocumentSetEntryData
        {
            get
            {
                return _currentAsycudaDocumentSetEntryData;
            }
            set
            {
                if (_currentAsycudaDocumentSetEntryData != value)
                {
                    _currentAsycudaDocumentSetEntryData = value;
                    BeginSendMessage(MessageToken.CurrentAsycudaDocumentSetEntryDataChanged,
                                                     new NotificationEventArgs<AsycudaDocumentSetEntryData>(MessageToken.CurrentAsycudaDocumentSetEntryDataChanged, _currentAsycudaDocumentSetEntryData)); 
                    NotifyPropertyChanged(x => this.CurrentAsycudaDocumentSetEntryData);    
                    // all current navigation properties = null
   
                }
            }
        }

		VirtualListItem<AsycudaDocumentSetEntryData> _vcurrentAsycudaDocumentSetEntryData;
        public VirtualListItem<AsycudaDocumentSetEntryData> VCurrentAsycudaDocumentSetEntryData
        {
            get
            {
                return _vcurrentAsycudaDocumentSetEntryData;
            }
            set
            {
                if (_vcurrentAsycudaDocumentSetEntryData != value)
                {
                    _vcurrentAsycudaDocumentSetEntryData = value;
					if(_vcurrentAsycudaDocumentSetEntryData != null) CurrentAsycudaDocumentSetEntryData = value.Data;
                    NotifyPropertyChanged(x => this.VCurrentAsycudaDocumentSetEntryData);                    
                }
            }
        }



                     
       

        internal void OnCurrentAsycudaDocumentSetEntryDataDetailsChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<AsycudaDocumentSetEntryDataDetails> e)
        {
            //CurrentAsycudaDocumentSetEntryDataDetails = e.Data;
            NotifyPropertyChanged(m => this.CurrentAsycudaDocumentSetEntryDataDetails);
        }

        private  AsycudaDocumentSetEntryDataDetails _currentAsycudaDocumentSetEntryDataDetails;
        public AsycudaDocumentSetEntryDataDetails CurrentAsycudaDocumentSetEntryDataDetails
        {
            get
            {
                return _currentAsycudaDocumentSetEntryDataDetails;
            }
            set
            {
                if (_currentAsycudaDocumentSetEntryDataDetails != value)
                {
                    _currentAsycudaDocumentSetEntryDataDetails = value;
                    BeginSendMessage(MessageToken.CurrentAsycudaDocumentSetEntryDataDetailsChanged,
                                                     new NotificationEventArgs<AsycudaDocumentSetEntryDataDetails>(MessageToken.CurrentAsycudaDocumentSetEntryDataDetailsChanged, _currentAsycudaDocumentSetEntryDataDetails)); 
                    NotifyPropertyChanged(x => this.CurrentAsycudaDocumentSetEntryDataDetails);    
                    // all current navigation properties = null
   
                }
            }
        }

		VirtualListItem<AsycudaDocumentSetEntryDataDetails> _vcurrentAsycudaDocumentSetEntryDataDetails;
        public VirtualListItem<AsycudaDocumentSetEntryDataDetails> VCurrentAsycudaDocumentSetEntryDataDetails
        {
            get
            {
                return _vcurrentAsycudaDocumentSetEntryDataDetails;
            }
            set
            {
                if (_vcurrentAsycudaDocumentSetEntryDataDetails != value)
                {
                    _vcurrentAsycudaDocumentSetEntryDataDetails = value;
					if(_vcurrentAsycudaDocumentSetEntryDataDetails != null) CurrentAsycudaDocumentSetEntryDataDetails = value.Data;
                    NotifyPropertyChanged(x => this.VCurrentAsycudaDocumentSetEntryDataDetails);                    
                }
            }
        }



                     
       

        internal void OnCurrentSalesDataChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<SalesData> e)
        {
            //CurrentSalesData = e.Data;
            NotifyPropertyChanged(m => this.CurrentSalesData);
        }

        private  SalesData _currentSalesData;
        public SalesData CurrentSalesData
        {
            get
            {
                return _currentSalesData;
            }
            set
            {
                if (_currentSalesData != value)
                {
                    _currentSalesData = value;
                    BeginSendMessage(MessageToken.CurrentSalesDataChanged,
                                                     new NotificationEventArgs<SalesData>(MessageToken.CurrentSalesDataChanged, _currentSalesData)); 
                    NotifyPropertyChanged(x => this.CurrentSalesData);    
                    // all current navigation properties = null
                 CurrentSalesDataDetail = null;
                 CurrentAsycudaDocumentSetEntryData = null;
                 CurrentSalesDataAllocations = null;
                 CurrentAsycudaDocumentEntryData = null;
   
                }
            }
        }

		VirtualListItem<SalesData> _vcurrentSalesData;
        public VirtualListItem<SalesData> VCurrentSalesData
        {
            get
            {
                return _vcurrentSalesData;
            }
            set
            {
                if (_vcurrentSalesData != value)
                {
                    _vcurrentSalesData = value;
					if(_vcurrentSalesData != null) CurrentSalesData = value.Data;
                    NotifyPropertyChanged(x => this.VCurrentSalesData);                    
                }
            }
        }



                     
       

        internal void OnCurrentSalesDataAllocationsChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<SalesDataAllocations> e)
        {
            //CurrentSalesDataAllocations = e.Data;
            NotifyPropertyChanged(m => this.CurrentSalesDataAllocations);
        }

        private  SalesDataAllocations _currentSalesDataAllocations;
        public SalesDataAllocations CurrentSalesDataAllocations
        {
            get
            {
                return _currentSalesDataAllocations;
            }
            set
            {
                if (_currentSalesDataAllocations != value)
                {
                    _currentSalesDataAllocations = value;
                    BeginSendMessage(MessageToken.CurrentSalesDataAllocationsChanged,
                                                     new NotificationEventArgs<SalesDataAllocations>(MessageToken.CurrentSalesDataAllocationsChanged, _currentSalesDataAllocations)); 
                    NotifyPropertyChanged(x => this.CurrentSalesDataAllocations);    
                    // all current navigation properties = null
   
                }
            }
        }

		VirtualListItem<SalesDataAllocations> _vcurrentSalesDataAllocations;
        public VirtualListItem<SalesDataAllocations> VCurrentSalesDataAllocations
        {
            get
            {
                return _vcurrentSalesDataAllocations;
            }
            set
            {
                if (_vcurrentSalesDataAllocations != value)
                {
                    _vcurrentSalesDataAllocations = value;
					if(_vcurrentSalesDataAllocations != null) CurrentSalesDataAllocations = value.Data;
                    NotifyPropertyChanged(x => this.VCurrentSalesDataAllocations);                    
                }
            }
        }



                     
       

        internal void OnCurrentSalesDataDetailChanged(object sender, SimpleMvvmToolkit.NotificationEventArgs<SalesDataDetail> e)
        {
            //CurrentSalesDataDetail = e.Data;
            NotifyPropertyChanged(m => this.CurrentSalesDataDetail);
        }

        private  SalesDataDetail _currentSalesDataDetail;
        public SalesDataDetail CurrentSalesDataDetail
        {
            get
            {
                return _currentSalesDataDetail;
            }
            set
            {
                if (_currentSalesDataDetail != value)
                {
                    _currentSalesDataDetail = value;
                    BeginSendMessage(MessageToken.CurrentSalesDataDetailChanged,
                                                     new NotificationEventArgs<SalesDataDetail>(MessageToken.CurrentSalesDataDetailChanged, _currentSalesDataDetail)); 
                    NotifyPropertyChanged(x => this.CurrentSalesDataDetail);    
                    // all current navigation properties = null
                 CurrentAsycudaDocumentSetEntryDataDetails = null;
   
                }
            }
        }

		VirtualListItem<SalesDataDetail> _vcurrentSalesDataDetail;
        public VirtualListItem<SalesDataDetail> VCurrentSalesDataDetail
        {
            get
            {
                return _vcurrentSalesDataDetail;
            }
            set
            {
                if (_vcurrentSalesDataDetail != value)
                {
                    _vcurrentSalesDataDetail = value;
					if(_vcurrentSalesDataDetail != null) CurrentSalesDataDetail = value.Data;
                    NotifyPropertyChanged(x => this.VCurrentSalesDataDetail);                    
                }
            }
        }






        static SalesDataQSOnCreated newSalesDataQSOnCreated = new SalesDataQSOnCreated();
    }		
}
