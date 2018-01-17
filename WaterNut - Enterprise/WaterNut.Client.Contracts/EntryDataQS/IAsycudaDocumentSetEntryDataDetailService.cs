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
using EntryDataQS.Client.DTO;


namespace EntryDataQS.Client.Contracts
{
    [ServiceContract (Namespace="http://www.insight-software.com/WaterNut")]
    public partial interface IAsycudaDocumentSetEntryDataDetailService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> GetAsycudaDocumentSetEntryDataDetails(List<string> includesLst = null);

        [OperationContract]
        Task<AsycudaDocumentSetEntryDataDetail> GetAsycudaDocumentSetEntryDataDetailByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> GetAsycudaDocumentSetEntryDataDetailsByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> GetAsycudaDocumentSetEntryDataDetailsByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> GetAsycudaDocumentSetEntryDataDetailsByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> GetAsycudaDocumentSetEntryDataDetailsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> GetAsycudaDocumentSetEntryDataDetailsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<AsycudaDocumentSetEntryDataDetail> UpdateAsycudaDocumentSetEntryDataDetail(AsycudaDocumentSetEntryDataDetail entity);

        [OperationContract]
        Task<AsycudaDocumentSetEntryDataDetail> CreateAsycudaDocumentSetEntryDataDetail(AsycudaDocumentSetEntryDataDetail entity);

        [OperationContract]
        Task<bool> DeleteAsycudaDocumentSetEntryDataDetail(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				[OperationContract]
		Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> GetAsycudaDocumentSetEntryDataDetailByAsycudaDocumentSetId(string AsycudaDocumentSetId, List<string> includesLst = null);
        
  		[OperationContract]
		Task<IEnumerable<AsycudaDocumentSetEntryDataDetail>> GetAsycudaDocumentSetEntryDataDetailByEntryDataDetailsId(string EntryDataDetailsId, List<string> includesLst = null);
        
  		
    }
}

