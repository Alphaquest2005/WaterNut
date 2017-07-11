﻿// <autogenerated>
//   This file was generated by T4 code generator AllServices.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using CoreEntities.Client.DTO;
using CoreEntities.Client.Contracts;
using Core.Common.Client.Services;

using Core.Common.Contracts;
using System.ComponentModel.Composition;


namespace CoreEntities.Client.Services
{
    [Export (typeof(EntryPreviousItemsClient))]
    [Export (typeof(IEntryPreviousItemsService))]
    [Export(typeof(IClientService))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class EntryPreviousItemsClient :  ClientService<IEntryPreviousItemsService>, IEntryPreviousItemsService, IDisposable
    {
        
        public async Task<IEnumerable<DTO.EntryPreviousItems>> GetEntryPreviousItems(List<string> includesLst = null)
        {
            return await Channel.GetEntryPreviousItems(includesLst).ConfigureAwait(false);
        }

        public async Task<DTO.EntryPreviousItems> GetEntryPreviousItemsByKey(string id, List<string> includesLst = null)
        {
            return await Channel.GetEntryPreviousItemsByKey(id, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.EntryPreviousItems>> GetEntryPreviousItemsByExpression(string exp, List<string> includesLst = null)
        {
            return await Channel.GetEntryPreviousItemsByExpression(exp, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.EntryPreviousItems>> GetEntryPreviousItemsByExpressionLst(List<string> expLst, List<string> includesLst = null)
        {
            return await Channel.GetEntryPreviousItemsByExpressionLst(expLst, includesLst).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.EntryPreviousItems>> GetEntryPreviousItemsByExpressionNav(string exp,
															 Dictionary<string, string> navExp, List<string> includesLst = null)
		{
			return await Channel.GetEntryPreviousItemsByExpressionNav(exp, navExp, includesLst).ConfigureAwait(false);
		}

        public async Task<IEnumerable<EntryPreviousItems>> GetEntryPreviousItemsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null)
        {
            return await Channel.GetEntryPreviousItemsByBatch(exp, totalrow, includesLst).ConfigureAwait(false);
        }

        public async Task<IEnumerable<EntryPreviousItems>> GetEntryPreviousItemsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null)
        {
            return await Channel.GetEntryPreviousItemsByBatchExpressionLst(expLst, totalrow, includesLst).ConfigureAwait(false);
        }

        public async Task<DTO.EntryPreviousItems> UpdateEntryPreviousItems(DTO.EntryPreviousItems entity)
        {
           return await Channel.UpdateEntryPreviousItems(entity).ConfigureAwait(false);
        }

        public async Task<DTO.EntryPreviousItems> CreateEntryPreviousItems(DTO.EntryPreviousItems entity)
        {
           return await Channel.CreateEntryPreviousItems(entity).ConfigureAwait(false);
        }

        public async Task<bool> DeleteEntryPreviousItems(string id)
        {
            return await Channel.DeleteEntryPreviousItems(id).ConfigureAwait(false);
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

        public async Task<IEnumerable<DTO.EntryPreviousItems>> LoadRange(int startIndex, int count, string exp)
        {
            return await Channel.LoadRange(startIndex,count,exp).ConfigureAwait(false);
        }

		public async Task<IEnumerable<DTO.EntryPreviousItems>>  LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null)
        {
            return await Channel.LoadRangeNav(startIndex,count,exp, navExp, includeLst).ConfigureAwait(false);
        }
		public async Task<IEnumerable<DTO.EntryPreviousItems>> GetEntryPreviousItemsByPreviousItem_Id(string PreviousItem_Id, List<string> includesLst = null)
        {
            return  await Channel.GetEntryPreviousItemsByPreviousItem_Id(PreviousItem_Id, includesLst).ConfigureAwait(false);
        }
			 
  		public async Task<IEnumerable<DTO.EntryPreviousItems>> GetEntryPreviousItemsByItem_Id(string Item_Id, List<string> includesLst = null)
        {
            return  await Channel.GetEntryPreviousItemsByItem_Id(Item_Id, includesLst).ConfigureAwait(false);
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

