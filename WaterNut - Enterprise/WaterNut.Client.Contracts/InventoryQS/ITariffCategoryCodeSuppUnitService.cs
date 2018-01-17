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
using InventoryQS.Client.DTO;


namespace InventoryQS.Client.Contracts
{
    [ServiceContract (Namespace="http://www.insight-software.com/WaterNut")]
    public partial interface ITariffCategoryCodeSuppUnitService : IClientService
    {
        [OperationContract]
        Task<IEnumerable<TariffCategoryCodeSuppUnit>> GetTariffCategoryCodeSuppUnit(List<string> includesLst = null);

        [OperationContract]
        Task<TariffCategoryCodeSuppUnit> GetTariffCategoryCodeSuppUnitByKey(string id, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<TariffCategoryCodeSuppUnit>> GetTariffCategoryCodeSuppUnitByExpression(string exp, List<string> includesLst = null);

		[OperationContract]
        Task<IEnumerable<TariffCategoryCodeSuppUnit>> GetTariffCategoryCodeSuppUnitByExpressionLst(List<string> expLst, List<string> includesLst = null);

		[OperationContract]
		Task<IEnumerable<TariffCategoryCodeSuppUnit>> GetTariffCategoryCodeSuppUnitByExpressionNav(string exp,
														 Dictionary<string, string> navExp, List<string> includesLst = null);        
        [OperationContract]
        Task<IEnumerable<TariffCategoryCodeSuppUnit>> GetTariffCategoryCodeSuppUnitByBatch(string exp,
                                                                        int totalrow, List<string> includesLst = null);
        [OperationContract]
        Task<IEnumerable<TariffCategoryCodeSuppUnit>> GetTariffCategoryCodeSuppUnitByBatchExpressionLst(List<string> expLst,
                                                                        int totalrow, List<string> includesLst = null);

		[OperationContract]
        Task<TariffCategoryCodeSuppUnit> UpdateTariffCategoryCodeSuppUnit(TariffCategoryCodeSuppUnit entity);

        [OperationContract]
        Task<TariffCategoryCodeSuppUnit> CreateTariffCategoryCodeSuppUnit(TariffCategoryCodeSuppUnit entity);

        [OperationContract]
        Task<bool> DeleteTariffCategoryCodeSuppUnit(string id);

		// Virtural List Implementation

        [OperationContract]
        Task<int> CountByExpressionLst(List<string> expLst);
    
		[OperationContract]
        Task<int> Count(string exp);

		[OperationContract]
        Task<int> CountNav(string exp, Dictionary<string, string> navExp);

        [OperationContract]
        Task<IEnumerable<TariffCategoryCodeSuppUnit>> LoadRange(int startIndex, int count, string exp);

		[OperationContract]
		Task<IEnumerable<TariffCategoryCodeSuppUnit>> LoadRangeNav(int startIndex, int count, string exp,
                                                                                 Dictionary<string, string> navExp, IEnumerable<string> includeLst = null);

		[OperationContract]
		decimal SumField(string whereExp, string field);
        
        [OperationContract]
        Task<decimal> SumNav( string exp, Dictionary<string, string> navExp, string field);

		[OperationContract]
		string MinField(string whereExp, string field);

				[OperationContract]
		Task<IEnumerable<TariffCategoryCodeSuppUnit>> GetTariffCategoryCodeSuppUnitByTariffSupUnitId(string TariffSupUnitId, List<string> includesLst = null);
        
  		
    }
}
