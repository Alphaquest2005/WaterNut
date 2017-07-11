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
    [Export (typeof(EntryDataExClient))]
    [Export (typeof(IEntryDataExService))]
    [Export(typeof(IClientService))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class EntryDataExClient :  ClientService<IEntryDataExService>, IEntryDataExService, IDisposable
    {
        
        public async Task<IEnumerable<DTO.EntryDataEx>> GetEntryDataEx(List<string> includesLst = null)
        {
            return await Channel.GetEntryDataEx(includesLst).ConfigureAwait(false);
        }

        public async Task<DTO.EntryDataEx> GetEntryDataExByKey(string id, List<string> includesLst = null)
        {
            return await Channel.GetEntryDataExByKey(id, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.EntryDataEx>> GetEntryDataExByExpression(string exp, List<string> includesLst = null)
        {
            return await Channel.GetEntryDataExByExpression(exp, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.EntryDataEx>> GetEntryDataExByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            return await Channel.GetEntryDataExByExpressionLst(expLst, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.EntryDataEx>> GetEntryDataExByExpressionNav(string exp,
															 Dictionary<string, string> navExp, List<string> includesLst = null)
		{
			return await Channel.GetEntryDataExByExpressionNav(exp, navExp, includesLst).ConfigureAwait(false);
		}

        public async Task<IEnumerable<EntryDataEx>> GetEntryDataExByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null)
        {
            return await Channel.GetEntryDataExByBatch(exp, totalrow, includesLst).ConfigureAwait(false);
        }

        public async Task<IEnumerable<EntryDataEx>> GetEntryDataExByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null)
        {
            return await Channel.GetEntryDataExByBatchExpressionLst(expLst, totalrow, includesLst).ConfigureAwait(false);
        }

        public async Task<DTO.EntryDataEx> UpdateEntryDataEx(DTO.EntryDataEx entity)
        {
           return await Channel.UpdateEntryDataEx(entity).ConfigureAwait(false);
        }

        public async Task<DTO.EntryDataEx> CreateEntryDataEx(DTO.EntryDataEx entity)
        {
           return await Channel.CreateEntryDataEx(entity).ConfigureAwait(false);
        }

        public async Task<bool> DeleteEntryDataEx(string id)
        {
            return await Channel.DeleteEntryDataEx(id).ConfigureAwait(false);
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

        public async Task<IEnumerable<DTO.EntryDataEx>> LoadRange(int startIndex, int count, string exp)
        {
            return await Channel.LoadRange(startIndex,count,exp).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.EntryDataEx>>  LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
            return await Channel.LoadRangeNav(startIndex,count,exp, navExp, includeLst).ConfigureAwait(false);
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

