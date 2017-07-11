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
    public partial interface ICounterPointPODetailsService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<CounterPointPODetails>> GetCounterPointPODetails(List<string> includesLst = null);

        [OperationContract]
        Task<CounterPointPODetails> GetCounterPointPODetailsByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<CounterPointPODetails>> GetCounterPointPODetailsByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<CounterPointPODetails>> GetCounterPointPODetailsByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<CounterPointPODetails>> GetCounterPointPODetailsByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<CounterPointPODetails>> GetCounterPointPODetailsByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<CounterPointPODetails>> GetCounterPointPODetailsByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<CounterPointPODetails> UpdateCounterPointPODetails(DTO.CounterPointPODetails entity);

        [OperationContract]
        Task<CounterPointPODetails> CreateCounterPointPODetails(DTO.CounterPointPODetails entity);

        [OperationContract]
        Task<bool> DeleteCounterPointPODetails(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<CounterPointPODetails>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<CounterPointPODetails>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				
    }
}
