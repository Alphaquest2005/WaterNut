﻿// <autogenerated>
//   This file was generated by T4 code generator AllDataSpaceViewModels.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System.Collections.Generic;
using System.Threading.Tasks;
//using SimpleMvvmToolkit;
using DocumentDS.Business.Entities;
using DocumentDS.Business.Services;




namespace WaterNut.DataSpace.DocumentDS.DataModels
{
	public partial class xcuda_Traders_FinancialDataModel_AutoGen 
	{
        private static readonly xcuda_Traders_FinancialDataModel_AutoGen instance;
        static xcuda_Traders_FinancialDataModel_AutoGen()
        {
            instance = new xcuda_Traders_FinancialDataModel_AutoGen();
        }

        public static  xcuda_Traders_FinancialDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Traders_Financial>> Searchxcuda_Traders_Financial(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Traders_FinancialService())
            {
                return await ctx.Getxcuda_Traders_FinancialByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
