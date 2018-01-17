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
using CoreEntities.Client.DTO;


namespace CoreEntities.Client.Contracts
{
    [ServiceContract (Namespace="http://www.insight-software.com/WaterNut")]
    public partial interface ICustoms_ProcedureService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<Customs_Procedure>> GetCustoms_Procedure(List<string> includesLst = null);

        [OperationContract]
        Task<Customs_Procedure> GetCustoms_ProcedureByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<Customs_Procedure>> GetCustoms_ProcedureByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<Customs_Procedure>> GetCustoms_ProcedureByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<Customs_Procedure>> GetCustoms_ProcedureByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<Customs_Procedure>> GetCustoms_ProcedureByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<Customs_Procedure>> GetCustoms_ProcedureByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<Customs_Procedure> UpdateCustoms_Procedure(Customs_Procedure entity);

        [OperationContract]
        Task<Customs_Procedure> CreateCustoms_Procedure(Customs_Procedure entity);

        [OperationContract]
        Task<bool> DeleteCustoms_Procedure(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<Customs_Procedure>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<Customs_Procedure>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				[OperationContract]
		Task<IEnumerable<Customs_Procedure>> GetCustoms_ProcedureByDocument_TypeId(string Document_TypeId, List<string> includesLst = null);
        
  		
    }
}

