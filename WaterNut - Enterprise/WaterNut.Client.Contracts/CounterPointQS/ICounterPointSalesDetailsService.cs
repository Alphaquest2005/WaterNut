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
using CounterPointQS.Client.DTO;

namespace CounterPointQS.Client.Contracts
{
    [ServiceContract (Namespace="http://www.insight-software.com/WaterNut")]
    public partial interface ICounterPointSalesDetailsService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<CounterPointSalesDetails>> GetCounterPointSalesDetails(List<string> includesLst = null);

        [OperationContract]
        Task<CounterPointSalesDetails> GetCounterPointSalesDetailsByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<CounterPointSalesDetails>> GetCounterPointSalesDetailsByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<CounterPointSalesDetails>> GetCounterPointSalesDetailsByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<CounterPointSalesDetails>> GetCounterPointSalesDetailsByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<CounterPointSalesDetails>> GetCounterPointSalesDetailsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<CounterPointSalesDetails>> GetCounterPointSalesDetailsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<CounterPointSalesDetails> UpdateCounterPointSalesDetails(DTO.CounterPointSalesDetails entity);

        [OperationContract]
        Task<CounterPointSalesDetails> CreateCounterPointSalesDetails(DTO.CounterPointSalesDetails entity);

        [OperationContract]
        Task<bool> DeleteCounterPointSalesDetails(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<CounterPointSalesDetails>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<CounterPointSalesDetails>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				
    }
}

