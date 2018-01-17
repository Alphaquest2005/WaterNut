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
using AllocationQS.Client.DTO;


namespace AllocationQS.Client.Contracts
{
    [ServiceContract (Namespace="http://www.insight-software.com/WaterNut")]
    public partial interface IAsycudaSalesAllocationsExService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExs(List<string> includesLst = null);

        [OperationContract]
        Task<AsycudaSalesAllocationsEx> GetAsycudaSalesAllocationsExByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExsByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExsByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExsByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<AsycudaSalesAllocationsEx> UpdateAsycudaSalesAllocationsEx(AsycudaSalesAllocationsEx entity);

        [OperationContract]
        Task<AsycudaSalesAllocationsEx> CreateAsycudaSalesAllocationsEx(AsycudaSalesAllocationsEx entity);

        [OperationContract]
        Task<bool> DeleteAsycudaSalesAllocationsEx(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<AsycudaSalesAllocationsEx>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<AsycudaSalesAllocationsEx>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				[OperationContract]
		Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExByPreviousItem_Id(string PreviousItem_Id, List<string> includesLst = null);
        
  		[OperationContract]
		Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExByEntryDataDetailsId(string EntryDataDetailsId, List<string> includesLst = null);
        
  		[OperationContract]
		Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExByxBond_Item_Id(string xBond_Item_Id, List<string> includesLst = null);
        
  		[OperationContract]
		Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExByxASYCUDA_Id(string xASYCUDA_Id, List<string> includesLst = null);
        
  		[OperationContract]
		Task<IEnumerable<AsycudaSalesAllocationsEx>> GetAsycudaSalesAllocationsExBypASYCUDA_Id(string pASYCUDA_Id, List<string> includesLst = null);
        
  		
    }
}

