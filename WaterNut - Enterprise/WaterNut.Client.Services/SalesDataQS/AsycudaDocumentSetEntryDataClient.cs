﻿// <autogenerated>
//   This file was generated by T4 code generator AllServices.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using SalesDataQS.Client.DTO;
using SalesDataQS.Client.Contracts;
using Core.Common.Client.Services;

using Core.Common.Contracts;
using System.ComponentModel.Composition;


namespace SalesDataQS.Client.Services
{
    [Export (typeof(AsycudaDocumentSetEntryDataClient))]
    [Export (typeof(IAsycudaDocumentSetEntryDataService))]
    [Export(typeof(IClientService))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class AsycudaDocumentSetEntryDataClient :  ClientService<IAsycudaDocumentSetEntryDataService>, IAsycudaDocumentSetEntryDataService, IDisposable
    {
        
        public async Task<IEnumerable<DTO.AsycudaDocumentSetEntryData>> GetAsycudaDocumentSetEntryData(List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentSetEntryData(includesLst).ConfigureAwait(false);
        }

        public async Task<DTO.AsycudaDocumentSetEntryData> GetAsycudaDocumentSetEntryDataByKey(string id, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentSetEntryDataByKey(id, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.AsycudaDocumentSetEntryData>> GetAsycudaDocumentSetEntryDataByExpression(string exp, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentSetEntryDataByExpression(exp, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.AsycudaDocumentSetEntryData>> GetAsycudaDocumentSetEntryDataByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentSetEntryDataByExpressionLst(expLst, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.AsycudaDocumentSetEntryData>> GetAsycudaDocumentSetEntryDataByExpressionNav(string exp,
															 Dictionary<string, string> navExp, List<string> includesLst = null)
		{
			return await Channel.GetAsycudaDocumentSetEntryDataByExpressionNav(exp, navExp, includesLst).ConfigureAwait(false);
		}

        public async Task<IEnumerable<AsycudaDocumentSetEntryData>> GetAsycudaDocumentSetEntryDataByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentSetEntryDataByBatch(exp, totalrow, includesLst).ConfigureAwait(false);
        }

        public async Task<IEnumerable<AsycudaDocumentSetEntryData>> GetAsycudaDocumentSetEntryDataByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null)
        {
            return await Channel.GetAsycudaDocumentSetEntryDataByBatchExpressionLst(expLst, totalrow, includesLst).ConfigureAwait(false);
        }

        public async Task<DTO.AsycudaDocumentSetEntryData> UpdateAsycudaDocumentSetEntryData(DTO.AsycudaDocumentSetEntryData entity)
        {
           return await Channel.UpdateAsycudaDocumentSetEntryData(entity).ConfigureAwait(false);
        }

        public async Task<DTO.AsycudaDocumentSetEntryData> CreateAsycudaDocumentSetEntryData(DTO.AsycudaDocumentSetEntryData entity)
        {
           return await Channel.CreateAsycudaDocumentSetEntryData(entity).ConfigureAwait(false);
        }

        public async Task<bool> DeleteAsycudaDocumentSetEntryData(string id)
        {
            return await Channel.DeleteAsycudaDocumentSetEntryData(id).ConfigureAwait(false);
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

        public async Task<IEnumerable<DTO.AsycudaDocumentSetEntryData>> LoadRange(int startIndex, int count, string exp)
        {
            return await Channel.LoadRange(startIndex,count,exp).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.AsycudaDocumentSetEntryData>>  LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
            return await Channel.LoadRangeNav(startIndex,count,exp, navExp, includeLst).ConfigureAwait(false);
        }
		public async Task<IEnumerable<DTO.AsycudaDocumentSetEntryData>> GetAsycudaDocumentSetEntryDataByAsycudaDocumentSetId(string AsycudaDocumentSetId, List<string> includesLst = null)
        {
            return  await Channel.GetAsycudaDocumentSetEntryDataByAsycudaDocumentSetId(AsycudaDocumentSetId, includesLst).ConfigureAwait(false);
        }
			 
  		public async Task<IEnumerable<DTO.AsycudaDocumentSetEntryData>> GetAsycudaDocumentSetEntryDataByEntryDataId(string EntryDataId, List<string> includesLst = null)
        {
            return  await Channel.GetAsycudaDocumentSetEntryDataByEntryDataId(EntryDataId, includesLst).ConfigureAwait(false);
        }
			 
          public decimal SumField(string whereExp, string sumExp)
		{
			return Channel.SumField(whereExp,sumExp);
		}

        public async Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field)
        {
            return await Channel.SumNav(exp,navExp,field).ConfigureAwait(false);
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
