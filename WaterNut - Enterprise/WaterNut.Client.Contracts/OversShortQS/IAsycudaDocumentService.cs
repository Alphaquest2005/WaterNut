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
    public partial interface IAsycudaDocumentService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<AsycudaDocument>> GetAsycudaDocuments(List<string> includesLst = null);

        [OperationContract]
        Task<AsycudaDocument> GetAsycudaDocumentByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<AsycudaDocument>> GetAsycudaDocumentsByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<AsycudaDocument>> GetAsycudaDocumentsByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<AsycudaDocument>> GetAsycudaDocumentsByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<AsycudaDocument>> GetAsycudaDocumentsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<AsycudaDocument>> GetAsycudaDocumentsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<AsycudaDocument> UpdateAsycudaDocument(AsycudaDocument entity);

        [OperationContract]
        Task<AsycudaDocument> CreateAsycudaDocument(AsycudaDocument entity);

        [OperationContract]
        Task<bool> DeleteAsycudaDocument(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<AsycudaDocument>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<AsycudaDocument>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				[OperationContract]
		Task<IEnumerable<AsycudaDocument>> GetAsycudaDocumentByAsycudaDocumentSetId(string AsycudaDocumentSetId, List<string> includesLst = null);
        
  		[OperationContract]
		Task<IEnumerable<AsycudaDocument>> GetAsycudaDocumentByDocument_TypeId(string Document_TypeId, List<string> includesLst = null);
        
  		[OperationContract]
		Task<IEnumerable<AsycudaDocument>> GetAsycudaDocumentByCustoms_ProcedureId(string Customs_ProcedureId, List<string> includesLst = null);
        
  		
    }
}

