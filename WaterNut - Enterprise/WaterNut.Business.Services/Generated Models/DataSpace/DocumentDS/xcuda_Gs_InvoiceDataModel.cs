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
	public partial class xcuda_Gs_InvoiceDataModel_AutoGen 
	{
        private static readonly xcuda_Gs_InvoiceDataModel_AutoGen instance;
        static xcuda_Gs_InvoiceDataModel_AutoGen()
        {
            instance = new xcuda_Gs_InvoiceDataModel_AutoGen();
        }

        public static  xcuda_Gs_InvoiceDataModel_AutoGen Instance
        {
            get { return instance; }
        }

       //Search Entities 
        public async Task<IEnumerable<xcuda_Gs_Invoice>> Searchxcuda_Gs_Invoice(List<string> lst, List<string> includeLst = null )
        {
            using (var ctx = new xcuda_Gs_InvoiceService())
            {
                return await ctx.Getxcuda_Gs_InvoiceByExpressionLst(lst, includeLst).ConfigureAwait(false);
            }
        }

    }
}
		
