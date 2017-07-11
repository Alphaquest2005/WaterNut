﻿// <autogenerated>
//   This file was generated by T4 code generator AllServices.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Core.Common.Contracts;
using OversShortQS.Client.DTO;

namespace OversShortQS.Client.Contracts
{
    [ServiceContract (Namespace="http://www.insight-software.com/WaterNut")]
    public partial interface IOverShortDetailAllocationService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<OverShortDetailAllocation>> GetOverShortDetailAllocations(List<string> includesLst = null);

        [OperationContract]
        Task<OverShortDetailAllocation> GetOverShortDetailAllocationByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<OverShortDetailAllocation>> GetOverShortDetailAllocationsByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<OverShortDetailAllocation>> GetOverShortDetailAllocationsByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<OverShortDetailAllocation>> GetOverShortDetailAllocationsByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<OverShortDetailAllocation>> GetOverShortDetailAllocationsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<OverShortDetailAllocation>> GetOverShortDetailAllocationsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<OverShortDetailAllocation> UpdateOverShortDetailAllocation(DTO.OverShortDetailAllocation entity);

        [OperationContract]
        Task<OverShortDetailAllocation> CreateOverShortDetailAllocation(DTO.OverShortDetailAllocation entity);

        [OperationContract]
        Task<bool> DeleteOverShortDetailAllocation(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<OverShortDetailAllocation>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<OverShortDetailAllocation>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				[OperationContract]
		Task<IEnumerable<OverShortDetailAllocation>> GetOverShortDetailAllocationByOverShortDetailId(string OverShortDetailId, List<string> includesLst = null);
        
  		[OperationContract]
		Task<IEnumerable<OverShortDetailAllocation>> GetOverShortDetailAllocationByItem_Id(string Item_Id, List<string> includesLst = null);
        
  		
    }
}
