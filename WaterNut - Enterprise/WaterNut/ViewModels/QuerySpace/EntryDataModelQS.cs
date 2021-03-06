﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CoreEntities.Client.Entities;
using CoreEntities.Client.Repositories;
using EntryDataQS.Client.Repositories;
using Microsoft.Win32;
using SimpleMvvmToolkit;

namespace WaterNut.QuerySpace.EntryDataQS.ViewModels
{
    public partial class EntryDataModel : EntryDataExViewModel_AutoGen
	{
        private static readonly EntryDataModel instance;
        static EntryDataModel()
        {
            instance = new EntryDataModel();

        }

        public static EntryDataModel Instance
        {
            get { return instance; }
        }

        private EntryDataModel()
        {
            RegisterToReceiveMessages<AsycudaDocumentSetEx>(CoreEntities.MessageToken.CurrentAsycudaDocumentSetExChanged, OnCurrentAsycudaDocumentSetExChanged);
            RegisterToReceiveMessages<AsycudaDocument>(CoreEntities.MessageToken.CurrentAsycudaDocumentChanged, OnCurrentAsycudaDocumentChanged);

        }

        private void OnCurrentAsycudaDocumentChanged(object sender, NotificationEventArgs<AsycudaDocument> e)
        {
            if (e.Data != null)
            {
                vloader.FilterExpression = "All";
                // vloader.NavExpression = string.Format("AsycudaDocumentSetId = {0}", e.Data.AsycudaDocumentSetId);
                vloader.SetNavigationExpression("AsycudaDocuments", string.Format("AsycudaDocumentId == {0}", e.Data.ASYCUDA_Id));
                EntryDataEx.Refresh();
            }
        }



        private new void OnCurrentAsycudaDocumentSetExChanged(object sender, NotificationEventArgs<AsycudaDocumentSetEx> e)
        {

            if (e.Data != null)
            {
                vloader.FilterExpression = "All";
                vloader.SetNavigationExpression("AsycudaDocumentSets", string.Format("AsycudaDocumentSetId == {0}", e.Data.AsycudaDocumentSetId));
                EntryDataEx.Refresh();
            }
        }




        internal async Task RemoveEntryData(global::EntryDataQS.Client.Entities.EntryDataEx entryDataEx)
        {
           await EntryDataExRepository.Instance.RemoveEntryData(entryDataEx.InvoiceNo).ConfigureAwait(false);
            
            MessageBus.Default.BeginNotify(CoreEntities.MessageToken.AsycudaDocumentsChanged, null,
                       new NotificationEventArgs(CoreEntities.MessageToken.AsycudaDocumentsChanged));

            MessageBus.Default.BeginNotify(CoreEntities.MessageToken.AsycudaDocumentSetExsChanged, null,
                            new NotificationEventArgs(CoreEntities.MessageToken.AsycudaDocumentSetExsChanged));

            MessageBus.Default.BeginNotify(CounterPointQS.MessageToken.CounterPointPOsChanged, null,
                           new NotificationEventArgs(CounterPointQS.MessageToken.CounterPointPOsChanged));

            MessageBus.Default.BeginNotify(MessageToken.EntryDataExChanged, null,
                            new NotificationEventArgs(MessageToken.EntryDataExChanged));
        }

        internal async Task AddDocToEntry(System.Collections.Generic.List<global::EntryDataQS.Client.Entities.EntryDataEx> lst, bool perInvoice = false)
        {
            var docSet = CoreEntities.ViewModels.BaseViewModel.Instance.CurrentAsycudaDocumentSetEx;
            if ( docSet == null)
            {
                MessageBox.Show("Please select a Document Set.");
                return;
            }
            await EntryDataExRepository.Instance.AddDocToEntry(lst.Select(x => x.InvoiceNo),docSet.AsycudaDocumentSetId, perInvoice).ConfigureAwait(false);
            await AsycudaDocumentSetExRepository.Instance.SaveAsycudaDocumentSetEx(docSet).ConfigureAwait(false);
            MessageBus.Default.BeginNotify(CoreEntities.MessageToken.AsycudaDocumentsChanged, null,
              new NotificationEventArgs(CoreEntities.MessageToken.AsycudaDocumentsChanged));
            MessageBus.Default.BeginNotify(CoreEntities.MessageToken.AsycudaDocumentSetExsChanged, null,
                new NotificationEventArgs(CoreEntities.MessageToken.AsycudaDocumentSetExsChanged));

            MessageBox.Show("Complete");
        }

        public async Task SaveCSV(string fileType)
        {
            await QuerySpace.SaveCSV.Instance.SaveCSVFile(fileType,
                CoreEntities.ViewModels.BaseViewModel.Instance.CurrentAsycudaDocumentSetEx).ConfigureAwait(false);

            MessageBus.Default.BeginNotify(MessageToken.EntryDataExChanged, null,
                         new NotificationEventArgs(MessageToken.EntryDataExChanged));
        }

        internal async Task RemoveSelectedEntryData(
            System.Collections.Generic.List<global::EntryDataQS.Client.Entities.EntryDataEx> list)
        {
            var res = MessageBox.Show("Are you sure you want to delete all Selected Items?", "Delete selected Items",
                MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
               await EntryDataExRepository.Instance.RemoveSelectedEntryData(SelectedEntryDataEx.Select(x => x.InvoiceNo)).ConfigureAwait(false);

                MessageBus.Default.BeginNotify(CoreEntities.MessageToken.AsycudaDocumentsChanged, null,
                    new NotificationEventArgs(CoreEntities.MessageToken.AsycudaDocumentsChanged));

                MessageBus.Default.BeginNotify(CoreEntities.MessageToken.AsycudaDocumentSetExsChanged, null,
                    new NotificationEventArgs(CoreEntities.MessageToken.AsycudaDocumentSetExsChanged));

                MessageBus.Default.BeginNotify(CounterPointQS.MessageToken.CounterPointPOsChanged, null,
                    new NotificationEventArgs(CounterPointQS.MessageToken.CounterPointPOsChanged));

                MessageBus.Default.BeginNotify(MessageToken.EntryDataExChanged, null,
                    new NotificationEventArgs(MessageToken.EntryDataExChanged));

                MessageBus.Default.BeginNotify(MessageToken.EntryDataExFilterExpressionChanged, null,
                   new NotificationEventArgs(MessageToken.EntryDataExFilterExpressionChanged));

                MessageBox.Show("Complete");

                //EntryDataEx.Refresh();
            }
        }
	}
}