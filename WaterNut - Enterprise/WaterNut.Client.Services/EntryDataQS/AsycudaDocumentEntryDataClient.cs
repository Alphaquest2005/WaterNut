﻿// <autogenerated>
//   This file was generated by T4 code generator AllServices.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using EntryDataQS.Client.DTO;
using EntryDataQS.Client.Contracts;
using Core.Common.Client.Services;


using Core.Common.Contracts;
using System.ComponentModel.Composition;


namespace EntryDataQS.Client.Services
{
    [Export (typeof(AsycudaDocumentEntryDataClient))]
    [Export (typeof(IAsycudaDocumentEntryDataService))]
    [Export(typeof(IClientService))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AsycudaDocumentEntryDataClient :  ClientService<IAsycudaDocumentEntryDataService>, IAsycudaDocumentEntryDataService, IDisposable
    {
        
        public async Task<IEnumerable<AsycudaDocumentEntryData>> GetAsycudaDocumentEntryDatas(List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentEntryDatas(includesLst).ConfigureAwait(false);
        }

        public async Task<AsycudaDocumentEntryData> GetAsycudaDocumentEntryDataByKey(string id, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentEntryDataByKey(id, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<AsycudaDocumentEntryData>> GetAsycudaDocumentEntryDatasByExpression(string exp, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentEntryDatasByExpression(exp, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<AsycudaDocumentEntryData>> GetAsycudaDocumentEntryDatasByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentEntryDatasByExpressionLst(expLst, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<AsycudaDocumentEntryData>> GetAsycudaDocumentEntryDatasByExpressionNav(string exp,
															 Dictionary<string, string> navExp, List<string> includesLst = null)
		{
			return await Channel.GetAsycudaDocumentEntryDatasByExpressionNav(exp, navExp, includesLst).ConfigureAwait(false);
		}

        public async Task<IEnumerable<AsycudaDocumentEntryData>> GetAsycudaDocumentEntryDatasByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentEntryDatasByBatch(exp, totalrow, includesLst).ConfigureAwait(false);
        }

        public async Task<IEnumerable<AsycudaDocumentEntryData>> GetAsycudaDocumentEntryDatasByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentEntryDatasByBatchExpressionLst(expLst, totalrow, includesLst).ConfigureAwait(false);
        }

        public async Task<AsycudaDocumentEntryData> UpdateAsycudaDocumentEntryData(AsycudaDocumentEntryData entity)
        {
           return await Channel.UpdateAsycudaDocumentEntryData(entity).ConfigureAwait(false);
        }

        public async Task<AsycudaDocumentEntryData> CreateAsycudaDocumentEntryData(AsycudaDocumentEntryData entity)
        {
           return await Channel.CreateAsycudaDocumentEntryData(entity).ConfigureAwait(false);
        }

        public async Task<bool> DeleteAsycudaDocumentEntryData(string id)
        {
            return await Channel.DeleteAsycudaDocumentEntryData(id).ConfigureAwait(false);
        }

       // Virtural List implementation

        public async Task<int> CountByExpressionLst(List<string> expLst)
        {
            return await Channel.CountByExpressionLst(expLst).ConfigureAwait(continueOnCapturedContext: false);
        }
        
	    public async Task<int> Count(string exp)
        {
            return await Channel.Count(exp).ConfigureAwait(continueOnCapturedContext: false);
        }

		public async Task<int> CountNav(string exp, Dictionary<string, string> navExp)
        {
           return await Channel.CountNav(exp, navExp).ConfigureAwait(false);
        }

        public async Task<IEnumerable<AsycudaDocumentEntryData>> LoadRange(int startIndex, int count, string exp)
        {
            return await Channel.LoadRange(startIndex,count,exp).ConfigureAwait(false);
        }

		public async Task<IEnumerable<AsycudaDocumentEntryData>>  LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
            return await Channel.LoadRangeNav(startIndex,count,exp, navExp, includeLst).ConfigureAwait(false);
        }
		public async Task<IEnumerable<AsycudaDocumentEntryData>> GetAsycudaDocumentEntryDataByAsycudaDocumentId(string AsycudaDocumentId, List<string> includesLst = null)
        {
            return  await Channel.GetAsycudaDocumentEntryDataByAsycudaDocumentId(AsycudaDocumentId, includesLst).ConfigureAwait(false);
        }
			 
  		public async Task<IEnumerable<AsycudaDocumentEntryData>> GetAsycudaDocumentEntryDataByEntryDataId(string EntryDataId, List<string> includesLst = null)
        {
            return  await Channel.GetAsycudaDocumentEntryDataByEntryDataId(EntryDataId, includesLst).ConfigureAwait(false);
        }
			 
          public decimal SumField(string whereExp, string sumExp)
		{
			return Channel.SumField(whereExp,sumExp);
		}

        public async Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field)
        {
            return await Channel.SumNav(exp,navExp,field);
        }

		public string MinField(string whereExp, string sumExp)
		{
			return Channel.MinField(whereExp,sumExp);
		}

		#region IDisposable implementation

            /// <summary>
            /// IDisposable.Dispose implementation, calls Dispose(true).
            /// </summary>
            void IDisposable.Dispose()
            {
                Dispose(true);
            }

            /// <summary>
            /// Dispose worker method. Handles graceful shutdown of the
            /// client even if it is an faulted state.
            /// </summary>
            /// <param name="disposing">Are we disposing (alternative
            /// is to be finalizing)</param>
            protected new void Dispose(bool disposing)
            {
                if (disposing)
                {
                    try
                    {
                        if (State != CommunicationState.Faulted)
                        {
                            Close();
                        }
                    }
                    finally
                    {
                        if (State != CommunicationState.Closed)
                        {
                            Abort();
                        }
                        GC.SuppressFinalize(this);
                    }
                }
            }



            #endregion
    }
}

